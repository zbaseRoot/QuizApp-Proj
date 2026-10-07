using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class QuestionForm : Form
    {
        public string SelectedOption { get; private set; }
        public event Action<string> OnAnswerSubmitted;
        private int _s = 0;

        public QuestionForm()
        {
            InitializeComponent();
        }

        public QuestionForm(string question, int seconds, string optionA, string optionB, string optionC, string optionD) : this()
        {
            lQuestion.Text = question;
            btnAOption1.Text = optionA;
            btnBOption2.Text = optionB;
            btnCOption3.Text = optionC;
            btnDOption4.Text = optionD;
            _s = seconds;
        }

        private async void QuestionForm_Load(object sender, EventArgs e)
        {
            await SecondsCounter(_s);
        }

        private async Task SecondsCounter(int s)
        {
            string t = lSeconds.Text;
            for (int i = s; i >= 0; i--)
            {
                lSeconds.Text = $"{t} {i}s";
                await Task.Delay(1000);
            }
        }

        private void btnAOption1_Click(object sender, EventArgs e)
        {
            SubmitAnswer(btnAOption1.Text);
        }

        private void btnBOption2_Click(object sender, EventArgs e)
        {
            SubmitAnswer(btnBOption2.Text);
        }

        private void btnCOption3_Click(object sender, EventArgs e)
        {
            SubmitAnswer(btnCOption3.Text);
        }

        private void btnDOption4_Click(object sender, EventArgs e)
        {
            SubmitAnswer(btnDOption4.Text);
        }

        private void SubmitAnswer(string option)
        {
            SelectedOption = option;
            OnAnswerSubmitted?.Invoke(option);
        }
    }
}