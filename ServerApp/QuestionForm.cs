using System;
using System.Windows.Forms;
using ServerApp.Database;

namespace ServerApp
{
    public partial class QuestionForm : Form
    {
        private MainForm _main;
        private string _quizName;
        private int? _questionId = null;

        public QuestionForm(MainForm main, string quizName, Question existingQuestion = null)
        {
            InitializeComponent();
            _main = main;
            _quizName = quizName;

            if (existingQuestion != null)
            {
                _questionId = existingQuestion.Id;
                tbQuestion.Text = existingQuestion.Text;
                tbRedOption.Text = existingQuestion.OptionRed;
                tbBlueOption.Text = existingQuestion.OptionBlue;
                tbYellowOption.Text = existingQuestion.OptionYellow;
                tbGreenOption.Text = existingQuestion.OptionGreen;

                if (existingQuestion.CorrectOption == "Red") rbRedOption.Checked = true;
                else if (existingQuestion.CorrectOption == "Blue") rbBlueOption.Checked = true;
                else if (existingQuestion.CorrectOption == "Yellow") rbYellowOption.Checked = true;
                else if (existingQuestion.CorrectOption == "Green") rbGreenOption.Checked = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string correct = "";

            if (rbRedOption.Checked) correct = "Red";
            else if (rbBlueOption.Checked) correct = "Blue";
            else if (rbYellowOption.Checked) correct = "Yellow";
            else if (rbGreenOption.Checked) correct = "Green";

            if (_questionId.HasValue)
            {
                _main.DB.UpdateQuestion(
                    _questionId.Value,
                    tbQuestion.Text,
                    tbRedOption.Text,
                    tbBlueOption.Text,
                    tbYellowOption.Text,
                    tbGreenOption.Text,
                    correct
                );
            }
            else
            {
                _main.DB.CreateQuestion(
                    _quizName,
                    tbQuestion.Text,
                    tbRedOption.Text,
                    tbBlueOption.Text,
                    tbYellowOption.Text,
                    tbGreenOption.Text,
                    correct
                );
            }

            _main.SwitchView(new QuestionsForm(_main, _quizName));
        }

        private void btnBackQuestions_Click(object sender, EventArgs e)
        {
            _main.SwitchView(new QuestionsForm(_main, _quizName));
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (_questionId.HasValue)
            {
                _main.DB.DeleteQuestion(_questionId.Value);
            }
            _main.SwitchView(new QuestionsForm(_main, _quizName));
        }
    }
}