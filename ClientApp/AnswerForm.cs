using System.Windows.Forms;

namespace ClientApp
{
    public partial class AnswerForm : Form
    {
        public AnswerForm()
        {
            InitializeComponent();
        }

        public AnswerForm(string correct, int score, int position) : this()
        {
            lScore.Text += $" {score}";
            lPosition.Text += $" {position}";
            lAnswer.Text = $"{correct}";
        }
    }
}