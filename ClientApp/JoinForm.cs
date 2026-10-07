using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace ClientApp
{
    public partial class JoinForm : Form
    {
        public string GameCode { get; private set; }
        public string PlayerName { get; private set; }
        public JoinForm()
        {
            InitializeComponent();
        }
        private void btnJoin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbGameCode.Text) && !string.IsNullOrWhiteSpace(tbUserName.Text))
            {
                GameCode = tbGameCode.Text.Trim();
                PlayerName = tbUserName.Text.Trim();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please enter all values", "Quiz ClientApp - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
