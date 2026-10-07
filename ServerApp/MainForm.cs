using System;
using System.Drawing;
using System.Windows.Forms;

namespace ServerApp
{
    public partial class MainForm : Form
    {
        public Server Server { get; private set; }
        public DatabaseManager DB { get; private set; }

        public MainForm()
        {
            InitializeComponent();
            Server = new Server();
            DB = new DatabaseManager();

            this.Opacity = 0;
            this.ShowInTaskbar = false;

            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (LoginForm loginForm = new LoginForm(this))
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    SwitchView(new DashboardForm(this));
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }

        public void SwitchView(Form form)
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
            this.Location = new Point(this.Location.X - widthDiff / 2, this.Location.Y - heightDiff / 2);

            form.Dock = DockStyle.Fill;
            this.Controls.Add(form);
            form.Show();

            this.Opacity = 1;
            this.ShowInTaskbar = true;
        }
    }
}