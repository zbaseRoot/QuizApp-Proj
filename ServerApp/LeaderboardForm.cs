using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Network;
using ServerApp.Database;

namespace ServerApp
{
    public partial class LeaderboardForm : Form
    {
        private MainForm _main;
        private string _quizName;
        private List<Question> _questions;
        private int _currentIndex;

        public LeaderboardForm(MainForm main, string quizName, List<Question> questions, int currentIndex)
        {
            InitializeComponent();
            _main = main;
            _quizName = quizName;
            _questions = questions;
            _currentIndex = currentIndex;

            this.Load += LeaderboardForm_Load;
        }

        private void LeaderboardForm_Load(object sender, EventArgs e)
        {
            var records = _main.Server.Players.OrderByDescending(p => p.TotalScore)
                .Select((p, i) => new LeaderboardItem { Position = i + 1, Username = p.Name, Score = p.TotalScore })
                .ToList();

            foreach (var r in records)
            {
                lbLeaderbord.Items.Add($"{r.Position}. {r.Username} - {r.Score} pts");
            }
        }

        private void btnStopQuiz_Click(object sender, EventArgs e)
        {
            _main.Server.Stop();
            _main.SwitchView(new QuestionsForm(_main, _quizName));
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentIndex + 1 < _questions.Count)
            {
                _main.SwitchView(new InGameQuestionForm(_main, _quizName, _questions, _currentIndex + 1));
            }
            else
            {
                _main.SwitchView(new PodiumForm(_main, _quizName));
            }
        }
    }
}