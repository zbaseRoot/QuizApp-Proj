using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Network;
using ServerApp.Database;

namespace ServerApp
{
    public partial class InGameQuestionForm : Form
    {
        private MainForm _main;
        private string _quizName;
        private List<Question> _questions;
        private int _currentIndex;
        private CancellationTokenSource _cts;
        private int _answeredCount;
        private bool _isStopped = false;
        private bool _isFinished = false;

        public InGameQuestionForm(MainForm main, string quizName, List<Question> questions, int currentIndex)
        {
            InitializeComponent();
            _main = main;
            _quizName = quizName;
            _questions = questions;
            _currentIndex = currentIndex;

            btnRedOption.Paint += CustomDisabledButton_Paint;
            btnBlueOption.Paint += CustomDisabledButton_Paint;
            btnYellowOption.Paint += CustomDisabledButton_Paint;
            btnGreenOption.Paint += CustomDisabledButton_Paint;

            btnNext.Click -= btnNext_Click;
            btnNext.Click += btnNext_Click;

            this.Load += InGameQuestionForm_Load;
        }



        private async void InGameQuestionForm_Load(object sender, EventArgs e)
        {
            btnRedOption.Paint += CustomDisabledButton_Paint;
            btnBlueOption.Paint += CustomDisabledButton_Paint;
            btnYellowOption.Paint += CustomDisabledButton_Paint;
            btnGreenOption.Paint += CustomDisabledButton_Paint;
            _cts = new CancellationTokenSource();
            _answeredCount = 0;
            var q = _questions[_currentIndex];

            lQuestion.Text = q.Text;
            btnRedOption.Text = q.OptionRed;
            btnBlueOption.Text = q.OptionBlue;
            btnYellowOption.Text = q.OptionYellow;
            btnGreenOption.Text = q.OptionGreen;

            foreach (var p in _main.Server.Players) p.LastAnswer = null;

            var qPacket = new QuestionPacket
            {
                QuestionId = q.Id,
                Text = q.Text,
                OptionA = q.OptionRed,
                OptionB = q.OptionBlue,
                OptionC = q.OptionYellow,
                OptionD = q.OptionGreen,
                SecondsToAnswer = 10
            };

            await _main.Server.BroadcastPacketAsync(qPacket);
            _main.Server.OnMessageReceived += Server_OnMessageReceived;

            try
            {
                for (int i = 10; i >= 0; i--)
                {
                    if (_cts.Token.IsCancellationRequested) break;

                    if (lTimer != null) lTimer.Text = $"{i.ToString()}s";

                    await Task.Delay(1000, _cts.Token);
                }
            }
            catch (TaskCanceledException) { }
            if (_isStopped) return;
            FinishQuestion();
        }

        private void Server_OnMessageReceived(ConnectedPlayer player, string message)
        {
            string[] messages = message.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            foreach (string msg in messages)
            {
                PacketWrapper wrapper = JsonSerializer.Deserialize<PacketWrapper>(msg);
                if (wrapper.PacketType == nameof(AnswerPacket))
                {
                    AnswerPacket ans = JsonSerializer.Deserialize<AnswerPacket>(wrapper.JsonData);
                    if (player.LastAnswer == null && !_isFinished)
                    {
                        player.LastAnswer = ans.SelectedOption;
                        FinishUser(player);
                        Interlocked.Increment(ref _answeredCount);

                        if (_answeredCount >= _main.Server.Players.Count)
                        {
                            _cts?.Cancel();
                        }
                    }
                }
            }
        }



        private void FinishUser(ConnectedPlayer cp)
        {
            var q = _questions[_currentIndex];
            string correctLetter = "None";
            if (q.CorrectOption == "Red") correctLetter = "A";
            else if (q.CorrectOption == "Blue") correctLetter = "B";
            else if (q.CorrectOption == "Yellow") correctLetter = "C";
            else if (q.CorrectOption == "Green") correctLetter = "D";

            string correctText = q.CorrectOption == "Red" ? q.OptionRed :
                                 q.CorrectOption == "Blue" ? q.OptionBlue :
                                 q.CorrectOption == "Yellow" ? q.OptionYellow : q.OptionGreen;
            bool correct = (cp.LastAnswer == correctLetter);
            int pts = correct ? 1000 : 0;
            cp.TotalScore += pts;

            _ = _main.Server.SendPacketAsync(new ResultPacket
            {
                IsCorrect = correct,
                AddedPoints = pts,
                TotalScore = cp.TotalScore,
                CorrectOptionText = correctText
            }, cp);
        }


        private void FinishQuestion()
        {
            if (_isFinished) return;
            _isFinished = true;

            _main.Server.OnMessageReceived -= Server_OnMessageReceived;
            var q = _questions[_currentIndex];

            string correctLetter = "None";
            if (q.CorrectOption == "Red") correctLetter = "A";
            else if (q.CorrectOption == "Blue") correctLetter = "B";
            else if (q.CorrectOption == "Yellow") correctLetter = "C";
            else if (q.CorrectOption == "Green") correctLetter = "D";

            string correctText = q.CorrectOption == "Red" ? q.OptionRed :
                                 q.CorrectOption == "Blue" ? q.OptionBlue :
                                 q.CorrectOption == "Yellow" ? q.OptionYellow : q.OptionGreen;


            foreach (var p in _main.Server.Players)
            {
                if (p.LastAnswer == null)
                {
                    _ = _main.Server.SendPacketAsync(new ResultPacket
                    {
                        IsCorrect = false,
                        AddedPoints = 0,
                        TotalScore = p.TotalScore,
                        CorrectOptionText = correctText
                    }, p);
                }
            }

            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => _main.SwitchView(new LeaderboardForm(_main, _quizName, _questions, _currentIndex))));
            }
            else
            {
                _main.SwitchView(new LeaderboardForm(_main, _quizName, _questions, _currentIndex));
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _cts?.Cancel();
        }

        private void btnStopQuiz_Click(object sender, EventArgs e)
        {
            _isStopped = true;
            _cts?.Cancel();
            _main.Server.OnMessageReceived -= Server_OnMessageReceived;
            _main.Server.Stop();
            _main.SwitchView(new QuestionsForm(_main, _quizName));
        }

        private void CustomDisabledButton_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;

            if (btn != null && !btn.Enabled)
            {
                using (SolidBrush brush = new SolidBrush(btn.BackColor))
                {
                    e.Graphics.FillRectangle(brush, btn.ClientRectangle);
                }

                TextRenderer.DrawText(
                    e.Graphics,
                    btn.Text,
                    btn.Font,
                    btn.ClientRectangle,
                    Color.White,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak
                );
            }
        }

        private void btnRedOption_Click(object sender, EventArgs e) { }
        private void btnBlueOption_Click(object sender, EventArgs e) { }
        private void btnYellowOption_Click(object sender, EventArgs e) { }
        private void btnGreenOption_Click(object sender, EventArgs e) { }
    }
}