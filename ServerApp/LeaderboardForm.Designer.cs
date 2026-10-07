namespace ServerApp
{
    partial class LeaderboardForm
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
            btnNext = new Button();
            btnStopQuiz = new Button();
            label2 = new Label();
            lbLeaderbord = new ListBox();
            SuspendLayout();
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.White;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Location = new Point(699, 22);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 13;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnStopQuiz
            // 
            btnStopQuiz.BackColor = Color.White;
            btnStopQuiz.FlatStyle = FlatStyle.Flat;
            btnStopQuiz.Location = new Point(27, 22);
            btnStopQuiz.Name = "btnStopQuiz";
            btnStopQuiz.Size = new Size(75, 23);
            btnStopQuiz.TabIndex = 12;
            btnStopQuiz.Text = "Stop";
            btnStopQuiz.UseVisualStyleBackColor = false;
            btnStopQuiz.Click += btnStopQuiz_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(314, 9);
            label2.Name = "label2";
            label2.Size = new Size(181, 37);
            label2.TabIndex = 11;
            label2.Text = "Leaderboard";
            // 
            // lbLeaderbord
            // 
            lbLeaderbord.FormattingEnabled = true;
            lbLeaderbord.Location = new Point(27, 63);
            lbLeaderbord.Name = "lbLeaderbord";
            lbLeaderbord.Size = new Size(747, 379);
            lbLeaderbord.TabIndex = 10;
            // 
            // LeaderboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNext);
            Controls.Add(btnStopQuiz);
            Controls.Add(label2);
            Controls.Add(lbLeaderbord);
            Name = "LeaderboardForm";
            Text = "LeaderboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNext;
        private Button btnStopQuiz;
        private Label label2;
        private ListBox lbLeaderbord;
    }
}