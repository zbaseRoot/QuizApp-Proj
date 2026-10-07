using System;
using System.Drawing;
using System.Windows.Forms;

namespace ServerApp
{
    public partial class DashboardForm : Form
    {
        private MainForm _main;

        public DashboardForm(MainForm main)
        {
            InitializeComponent();
            _main = main;
            LoadQuizzes();
        }

        private void btnCreateQuiz_Click(object sender, EventArgs e)
        {
            if (_main.DB.GetQuizzes().Contains(tbCreateQuizName.Text))
            {
                MessageBox.Show("Quiz with same name is exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(tbCreateQuizName.Text))
            {
                MessageBox.Show("Enter quiz name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _main.DB.CreateQuiz(tbCreateQuizName.Text);
            tbCreateQuizName.Clear();
            LoadQuizzes();
        }

        private void LoadQuizzes()
        {
            flowLayoutPanelQuizs.Controls.Clear();

            foreach (var quiz in _main.DB.GetQuizzes())
            {
                Button btnQuizOpen = new Button();
                btnQuizOpen.Size = new Size(797, 23);
                btnQuizOpen.Text = quiz;
                btnQuizOpen.BackColor = Color.White;
                btnQuizOpen.FlatStyle = FlatStyle.Flat;
                btnQuizOpen.Click += (s, e) => _main.SwitchView(new QuestionsForm(_main, quiz));

                flowLayoutPanelQuizs.Controls.Add(btnQuizOpen);
            }
        }
    }
}