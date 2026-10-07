namespace ClientApp
{
    partial class WaitForm
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
            lNicknameOnScreen = new Label();
            lNameIs = new Label();
            lWait = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lNicknameOnScreen
            // 
            lNicknameOnScreen.AutoSize = true;
            lNicknameOnScreen.BackColor = Color.Transparent;
            lNicknameOnScreen.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lNicknameOnScreen.ForeColor = Color.Black;
            lNicknameOnScreen.Location = new Point(107, 19);
            lNicknameOnScreen.Name = "lNicknameOnScreen";
            lNicknameOnScreen.Size = new Size(565, 37);
            lNicknameOnScreen.TabIndex = 8;
            lNicknameOnScreen.Text = "Do you see your nickname on the screen?";
            // 
            // lNameIs
            // 
            lNameIs.AutoSize = true;
            lNameIs.BackColor = Color.Transparent;
            lNameIs.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold);
            lNameIs.ForeColor = Color.Black;
            lNameIs.Location = new Point(112, 56);
            lNameIs.Name = "lNameIs";
            lNameIs.Size = new Size(142, 28);
            lNameIs.TabIndex = 9;
            lNameIs.Text = "Your name is";
            // 
            // lWait
            // 
            lWait.AutoSize = true;
            lWait.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold);
            lWait.ForeColor = Color.White;
            lWait.Location = new Point(-6, 219);
            lWait.Name = "lWait";
            lWait.Size = new Size(810, 51);
            lWait.TabIndex = 10;
            lWait.Text = "Wait for the organizer to start the game...";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lNicknameOnScreen);
            panel1.Controls.Add(lNameIs);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 113);
            panel1.TabIndex = 11;
            // 
            // WaitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(800, 450);
            Controls.Add(lWait);
            Controls.Add(panel1);
            Name = "WaitForm";
            Text = "Quiz ClientApp - Wait";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lNicknameOnScreen;
        private Label lNameIs;
        private Label lWait;
        private Panel panel1;
    }
}