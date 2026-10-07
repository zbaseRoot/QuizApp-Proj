using System;
using System.Linq;
using System.Windows.Forms;
using Network;

namespace ServerApp
{
    public partial class PodiumForm : Form
    {
        private MainForm _main;
        private string _quizName;

        public PodiumForm(MainForm main, string quizName)
        {
            InitializeComponent();
            _main = main;
            _quizName = quizName;

            this.Load += PodiumForm_Load;
        }

        private async void PodiumForm_Load(object sender, EventArgs e)
        {
            var records = _main.Server.Players.OrderByDescending(p => p.TotalScore).ToList();

            var lbs = records.Take(3).ToList();
            try
            {
                l1PlayerWin.Text = lbs[0].Name;
                l1placePoints.Text = lbs[0].TotalScore.ToString() + " pts";
            }
            catch (Exception)
            {

                l1PlayerWin.Text = "None";
                l1placePoints.Text = "-1 pts";
            }

            try
            {
                l2PlayerWin.Text = lbs[1].Name;
                l2placePoints.Text = lbs[1].TotalScore.ToString() + " pts";
            }
            catch (Exception)
            {

                l2PlayerWin.Text = "None";
                l2placePoints.Text = "-1 pts";
            }

            try
            {
                l3PlayerWin.Text = lbs[2].Name;
                l3placePoints.Text = lbs[2].TotalScore.ToString() + " pts"; 
            }
            catch (Exception)
            {

                l3PlayerWin.Text = "None";
                l3placePoints.Text = "-1 pts";
            }


            var packetRecords = records.Select((p, i) => new LeaderboardItem { Position = i + 1, Username = p.Name, Score = p.TotalScore }).ToList();
            await _main.Server.BroadcastPacketAsync(new LeaderboardPacket { QuizTitle = _quizName, Records = packetRecords });
        }

        private void btnBackPodium_Click(object sender, EventArgs e)
        {
            _main.Server.Stop();
            _main.SwitchView(new QuestionsForm(_main, _quizName));
        }
    }
}