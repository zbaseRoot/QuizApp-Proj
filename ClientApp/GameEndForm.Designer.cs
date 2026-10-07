namespace ClientApp
{
    partial class GameEndForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lPodium = new Label();
            panel1 = new Panel();
            l2place = new Label();
            panel2 = new Panel();
            l1Place = new Label();
            panel4 = new Panel();
            l3place = new Label();
            panel5 = new Panel();
            l1PlayerWin = new Label();
            l3PlayerWin = new Label();
            l2PlayerWin = new Label();
            l2placePoints = new Label();
            l1placePoints = new Label();
            l3placePoints = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // lPodium
            // 
            lPodium.AutoSize = true;
            lPodium.BackColor = Color.Transparent;
            lPodium.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lPodium.ForeColor = Color.White;
            lPodium.Location = new Point(339, 9);
            lPodium.Name = "lPodium";
            lPodium.Size = new Size(132, 37);
            lPodium.TabIndex = 16;
            lPodium.Text = "PODIUM";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(l2placePoints);
            panel1.Controls.Add(l2place);
            panel1.Location = new Point(110, 268);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 110);
            panel1.TabIndex = 17;
            // 
            // l2place
            // 
            l2place.AutoSize = true;
            l2place.Font = new Font("Segoe UI Black", 40F, FontStyle.Bold);
            l2place.Location = new Point(73, 0);
            l2place.Name = "l2place";
            l2place.Size = new Size(62, 72);
            l2place.TabIndex = 1;
            l2place.Text = "2";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(l1placePoints);
            panel2.Controls.Add(l1Place);
            panel2.Location = new Point(306, 197);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 181);
            panel2.TabIndex = 18;
            // 
            // l1Place
            // 
            l1Place.AutoSize = true;
            l1Place.Font = new Font("Segoe UI Black", 40F, FontStyle.Bold);
            l1Place.Location = new Point(72, 0);
            l1Place.Name = "l1Place";
            l1Place.Size = new Size(56, 72);
            l1Place.TabIndex = 0;
            l1Place.Text = "1";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(l3placePoints);
            panel4.Controls.Add(l3place);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(506, 268);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 110);
            panel4.TabIndex = 20;
            // 
            // l3place
            // 
            l3place.AutoSize = true;
            l3place.Font = new Font("Segoe UI Black", 40F, FontStyle.Bold);
            l3place.Location = new Point(71, 0);
            l3place.Name = "l3place";
            l3place.Size = new Size(62, 72);
            l3place.TabIndex = 2;
            l3place.Text = "3";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(197, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 157);
            panel5.TabIndex = 19;
            // 
            // l1PlayerWin
            // 
            l1PlayerWin.AutoSize = true;
            l1PlayerWin.BackColor = Color.Transparent;
            l1PlayerWin.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            l1PlayerWin.ForeColor = Color.White;
            l1PlayerWin.Location = new Point(309, 157);
            l1PlayerWin.Name = "l1PlayerWin";
            l1PlayerWin.Size = new Size(192, 37);
            l1PlayerWin.TabIndex = 21;
            l1PlayerWin.Text = "PlayerName1";
            // 
            // l3PlayerWin
            // 
            l3PlayerWin.AutoSize = true;
            l3PlayerWin.BackColor = Color.Transparent;
            l3PlayerWin.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            l3PlayerWin.ForeColor = Color.White;
            l3PlayerWin.Location = new Point(506, 232);
            l3PlayerWin.Name = "l3PlayerWin";
            l3PlayerWin.Size = new Size(195, 37);
            l3PlayerWin.TabIndex = 22;
            l3PlayerWin.Text = "PlayerName2";
            // 
            // l2PlayerWin
            // 
            l2PlayerWin.AutoSize = true;
            l2PlayerWin.BackColor = Color.Transparent;
            l2PlayerWin.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            l2PlayerWin.ForeColor = Color.White;
            l2PlayerWin.Location = new Point(110, 232);
            l2PlayerWin.Name = "l2PlayerWin";
            l2PlayerWin.Size = new Size(195, 37);
            l2PlayerWin.TabIndex = 23;
            l2PlayerWin.Text = "PlayerName3";
            // 
            // l2placePoints
            // 
            l2placePoints.AutoSize = true;
            l2placePoints.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold);
            l2placePoints.Location = new Point(3, 82);
            l2placePoints.Name = "l2placePoints";
            l2placePoints.Size = new Size(85, 28);
            l2placePoints.TabIndex = 2;
            l2placePoints.Text = "000 pts";
            // 
            // l1placePoints
            // 
            l1placePoints.AutoSize = true;
            l1placePoints.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold);
            l1placePoints.Location = new Point(0, 153);
            l1placePoints.Name = "l1placePoints";
            l1placePoints.Size = new Size(85, 28);
            l1placePoints.TabIndex = 3;
            l1placePoints.Text = "000 pts";
            // 
            // l3placePoints
            // 
            l3placePoints.AutoSize = true;
            l3placePoints.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold);
            l3placePoints.Location = new Point(0, 82);
            l3placePoints.Name = "l3placePoints";
            l3placePoints.Size = new Size(85, 28);
            l3placePoints.TabIndex = 4;
            l3placePoints.Text = "000 pts";
            // 
            // GameEndForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(808, 450);
            Controls.Add(l2PlayerWin);
            Controls.Add(l3PlayerWin);
            Controls.Add(l1PlayerWin);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lPodium);
            Name = "GameEndForm";
            Text = "Quiz ClientApp - Results";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lPodium;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private Label l1Place;
        private Label l2place;
        private Label l3place;
        private Label l1PlayerWin;
        private Label l3PlayerWin;
        private Label l2PlayerWin;
        private Label l2placePoints;
        private Label l1placePoints;
        private Label l3placePoints;
    }
}