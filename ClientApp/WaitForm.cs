using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class WaitForm : Form
    {
        public WaitForm()
        {
            InitializeComponent();
        }

        public WaitForm(string playerName) : this()
        {
            lNameIs.Text += $" {playerName.ToUpper()}";
        }
    }
}
