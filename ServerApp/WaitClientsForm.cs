using System;
using System.Text.Json;
using System.Windows.Forms;
using Network;

namespace ServerApp
{
    public partial class WaitClientsForm : Form
    {
        private MainForm _main;
        private string _quizName;
        private string _gameCode;

        public WaitClientsForm(MainForm main, string quizName)
        {
            InitializeComponent();
            _main = main;
            _quizName = quizName;

            Random rnd = new Random();
            _gameCode = rnd.Next(1000, 10000).ToString();
            label2.Text = $"Game code: {_gameCode}";

            _main.Server.Start();
            _main.Server.OnMessageReceived += Server_OnMessageReceived;
        }

        private void Server_OnMessageReceived(ConnectedPlayer player, string message)
        {
            string[] messages = message.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            foreach (string msg in messages)
            {
                PacketWrapper wrapper = JsonSerializer.Deserialize<PacketWrapper>(msg);

                if (wrapper.PacketType == nameof(JoinRoomPacket))
                {
                    JoinRoomPacket join = JsonSerializer.Deserialize<JoinRoomPacket>(wrapper.JsonData);

                    if (join.RoomCode == _gameCode)
                    {
                        player.Name = join.PlayerName;
                        _main.Server.Players.Add(player);

                        if (this.InvokeRequired)
                        {
                            this.Invoke(new Action(() => lbConnectedClients.Items.Add(player.Name)));
                        }
                        else
                        {
                            lbConnectedClients.Items.Add(player.Name);
                        }

                        _ = _main.Server.SendPacketAsync(new JoinResultPacket { IsSuccess = true }, player);
                    }
                    else
                    {
                        _ = _main.Server.SendPacketAsync(new JoinResultPacket { IsSuccess = false, ErrorMessage = "Wrong game code!" }, player);
                    }
                }
            }
        }

        private void btnStopQuiz_Click(object sender, EventArgs e)
        {
            _main.Server.OnMessageReceived -= Server_OnMessageReceived;
            _main.Server.Stop();
            _main.SwitchView(new QuestionsForm(_main, _quizName));
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            var questions = _main.DB.GetQuestions(_quizName);
            if (questions.Count == 0) return;

            _main.Server.OnMessageReceived -= Server_OnMessageReceived;
            _main.SwitchView(new InGameQuestionForm(_main, _quizName, questions, 0));
        }
    }
}