using System;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Network;

namespace ClientApp
{
    public partial class MainForm : Form
    {
        private Client _client;
        private string gameCode = "-";
        private string playerName = "Player--";
        private string question = "";
        private string optionA = "";
        private string optionB = "";
        private string optionC = "";
        private string optionD = "";
        private string correct = "";
        private int score = -1;
        private int position = -1;
        private int seconds = 5;

        private string winner1Name = "None";
        private int winner1Score = -1;
        private string winner2Name = "None";
        private int winner2Score = -1;
        private string winner3Name = "None";
        private int winner3Score = -1;

        public MainForm()
        {
            InitializeComponent();
            this.Opacity = 0;
            this.ShowInTaskbar = false;
            _client = new Client();
            _client.MessageReceive += MessageReceived;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await ConnectLogic();
        }

        private void SwitchView(Form form)
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Dispose();
            }
            this.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;

            int widthDiff = form.Width - this.ClientSize.Width;
            int heightDiff = form.Height - this.ClientSize.Height;

            this.ClientSize = form.Size;
            this.Location = new System.Drawing.Point(this.Location.X - widthDiff / 2, this.Location.Y - heightDiff / 2);
            form.Dock = DockStyle.Fill;
            this.Controls.Add(form);
            form.Show();
            this.Opacity = 1;
            this.ShowInTaskbar = true;
        }

        private async Task ConnectLogic()
        {
            using (JoinForm joinForm = new JoinForm())
            {
                if (joinForm.ShowDialog() == DialogResult.OK)
                {
                    gameCode = joinForm.GameCode;
                    playerName = joinForm.PlayerName;

                    if (_client != null)
                    {
                        _client.MessageReceive -= MessageReceived;
                        _client.CloseConnection();
                    }

                    _client = new Client();

                    try
                    {
                        await _client.ConnectAsync();
                    }
                    catch
                    {
                        MessageBox.Show("No connection!", "Quiz ClientApp - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        await ConnectLogic(); 
                        return;
                    }

                    _client.MessageReceive += MessageReceived;
                    _ = _client.ReceiveMessagesAsync();

                    JoinRoomPacket joinPacket = new JoinRoomPacket
                    {
                        RoomCode = gameCode,
                        PlayerName = playerName
                    };

                    await _client.SendPacketAsync(joinPacket);
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }

        private void MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ProcessNetworkMessage(e.Message)));
            }
            else
            {
                ProcessNetworkMessage(e.Message);
            }
        }

        private async void ProcessNetworkMessage(string message)
        {
            string[] messages = message.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            foreach (string msg in messages)
            {
                PacketWrapper wrapper = JsonSerializer.Deserialize<PacketWrapper>(msg);

                if (wrapper.PacketType == nameof(JoinResultPacket))
                {
                    JoinResultPacket joinRes = JsonSerializer.Deserialize<JoinResultPacket>(wrapper.JsonData);

                    if (joinRes.IsSuccess)
                    {
                        SwitchView(new WaitForm(playerName));
                    }
                    else
                    {
                        MessageBox.Show("Game code is wrong!", "Quiz ClientApp - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        await ConnectLogic();
                    }
                }
                else if (wrapper.PacketType == nameof(QuestionPacket))
                {
                    QuestionPacket qPacket = JsonSerializer.Deserialize<QuestionPacket>(wrapper.JsonData);

                    question = qPacket.Text;
                    optionA = qPacket.OptionA;
                    optionB = qPacket.OptionB;
                    optionC = qPacket.OptionC;
                    optionD = qPacket.OptionD;
                    seconds = qPacket.SecondsToAnswer;

                    QuestionForm qForm = new QuestionForm(question, seconds, optionA, optionB, optionC, optionD);

                    qForm.OnAnswerSubmitted += async (selectedOption) =>
                    {
                        string letter = "None";
                        if (selectedOption == optionA) letter = "A";
                        else if (selectedOption == optionB) letter = "B";
                        else if (selectedOption == optionC) letter = "C";
                        else if (selectedOption == optionD) letter = "D";

                        AnswerPacket ansPacket = new AnswerPacket
                        {
                            QuestionId = qPacket.QuestionId,
                            SelectedOption = letter,
                            TimeSpentSeconds = 0
                        };

                        await _client.SendPacketAsync(ansPacket);
                    };

                    SwitchView(qForm);
                }
                else if (wrapper.PacketType == nameof(ResultPacket))
                {
                    ResultPacket rPacket = JsonSerializer.Deserialize<ResultPacket>(wrapper.JsonData);

                    if (rPacket.IsCorrect)
                    {
                        correct = "You're correct!";
                    }
                    else
                    {
                        correct = $"You're wrong! - Correct: {rPacket.CorrectOptionText}";

                    }
                    score = rPacket.TotalScore;
                    position = rPacket.AddedPoints;

                    SwitchView(new AnswerForm(correct, score, position));
                }
                else if (wrapper.PacketType == nameof(LeaderboardPacket))
                {
                    LeaderboardPacket lPacket = JsonSerializer.Deserialize<LeaderboardPacket>(wrapper.JsonData);

                    if (lPacket.Records.Count > 0)
                    {
                        winner1Name = lPacket.Records[0].Username;
                        winner1Score = lPacket.Records[0].Score;
                    }
                    if (lPacket.Records.Count > 1)
                    {
                        winner2Name = lPacket.Records[1].Username;
                        winner2Score = lPacket.Records[1].Score;
                    }
                    if (lPacket.Records.Count > 2)
                    {
                        winner3Name = lPacket.Records[2].Username;
                        winner3Score = lPacket.Records[2].Score;
                    }

                    SwitchView(new GameEndForm(winner1Name, winner1Score, winner2Name, winner2Score, winner3Name, winner3Score));
                }
            }
        }
    }
}