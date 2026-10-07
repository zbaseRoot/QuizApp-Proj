using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class GameEndForm : Form
    {
        public GameEndForm()
        {
            InitializeComponent();
        }

        public GameEndForm(string player1, int score1, string player2, int score2, string player3, int score3) : this()
        {
            l1PlayerWin.Text = player1;
            l1placePoints.Text = $"{score1} pts";

            l2PlayerWin.Text = player2;
            l2placePoints.Text = $"{score2} pts";

            l3PlayerWin.Text = player3;
            l3placePoints.Text = $"{score3} pts";
        }
    }
}