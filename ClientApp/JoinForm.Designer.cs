namespace ClientApp
{
    partial class JoinForm
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
            tbUserName = new TextBox();
            tbGameCode = new TextBox();
            btnJoin = new Button();
            lEnterGameCodeName = new Label();
            SuspendLayout();
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(235, 235);
            tbUserName.Multiline = true;
            tbUserName.Name = "tbUserName";
            tbUserName.PlaceholderText = "Enter name...";
            tbUserName.Size = new Size(188, 30);
            tbUserName.TabIndex = 10;
            // 
            // tbGameCode
            // 
            tbGameCode.Location = new Point(235, 190);
            tbGameCode.Multiline = true;
            tbGameCode.Name = "tbGameCode";
            tbGameCode.PlaceholderText = "Enter code...";
            tbGameCode.Size = new Size(188, 30);
            tbGameCode.TabIndex = 9;
            // 
            // btnJoin
            // 
            btnJoin.BackColor = Color.FromArgb(51, 51, 51);
            btnJoin.FlatStyle = FlatStyle.Flat;
            btnJoin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnJoin.ForeColor = Color.White;
            btnJoin.Location = new Point(264, 285);
            btnJoin.Name = "btnJoin";
            btnJoin.Size = new Size(131, 43);
            btnJoin.TabIndex = 8;
            btnJoin.Text = "Join";
            btnJoin.UseVisualStyleBackColor = false;
            btnJoin.Click += btnJoin_Click;
            // 
            // lEnterGameCodeName
            // 
            lEnterGameCodeName.AutoSize = true;
            lEnterGameCodeName.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lEnterGameCodeName.ForeColor = Color.White;
            lEnterGameCodeName.Location = new Point(144, 123);
            lEnterGameCodeName.Name = "lEnterGameCodeName";
            lEnterGameCodeName.Size = new Size(376, 37);
            lEnterGameCodeName.TabIndex = 7;
            lEnterGameCodeName.Text = "Enter game code and name";
            // 
            // JoinForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(666, 451);
            Controls.Add(tbUserName);
            Controls.Add(tbGameCode);
            Controls.Add(btnJoin);
            Controls.Add(lEnterGameCodeName);
            Name = "JoinForm";
            Text = "Quiz ClientApp - Join";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUserName;
        private TextBox tbGameCode;
        private Button btnJoin;
        private Label lEnterGameCodeName;
    }
}