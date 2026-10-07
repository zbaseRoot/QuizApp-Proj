using System;
using System.Drawing;
using System.Windows.Forms;

namespace ServerApp
{
    public partial class QuestionsForm : Form
    {
        private MainForm _main;
        private string _quizName;

        public QuestionsForm(MainForm main, string quizName)
        {
            InitializeComponent();
            _main = main;
            _quizName = quizName;
            LoadQuestions();
        }

        private void LoadQuestions()
        {
            try
            {
                flowLayoutPanelQuestions.Controls.Clear();

                foreach (var q in _main.DB.GetQuestions(_quizName))
                {
                    Button btnQ = new Button();
                    btnQ.Size = new Size(797, 23);
                    btnQ.Text = q.Text;
                    btnQ.BackColor = Color.White;
                    btnQ.FlatStyle = FlatStyle.Flat;
                    btnQ.Click += (s, e) => _main.SwitchView(new QuestionForm(_main, _quizName, q));
                    flowLayoutPanelQuestions.Controls.Add(btnQ);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            try
            {
                _main.SwitchView(new DashboardForm(_main));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                _main.SwitchView(new QuestionForm(_main, _quizName));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            try
            {
                var questions = _main.DB.GetQuestions(_quizName);
                if (questions == null || questions.Count == 0)
                {
                    MessageBox.Show("Cannot start a quiz without questions!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _main.SwitchView(new WaitClientsForm(_main, _quizName));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteQuiz_Click(object sender, EventArgs e)
        {
            try
            {
                _main.DB.DeleteQuiz(_quizName);
                _main.SwitchView(new DashboardForm(_main));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}