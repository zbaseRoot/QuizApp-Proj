using System;
using System.Windows.Forms;

namespace ServerApp
{
    public partial class LoginForm : Form
    {
        private MainForm _main;
        public LoginForm(MainForm main)
        {
            InitializeComponent();
            _main = main;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_main.DB.LoginUser(tbLoginUsername.Text, tbLoginPass.Text))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Login or password inccorect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (_main.DB.RegisterUser(tbRegUsername.Text, tbRegPass.Text))
            {
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("User with same name is exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}