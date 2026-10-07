namespace ServerApp
{
    partial class InGameQuestionForm
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
            btnRedOption = new Button();
            btnBlueOption = new Button();
            btnYellowOption = new Button();
            btnGreenOption = new Button();
            lQuestion = new Label();
            btnNext = new Button();
            btnStopQuiz = new Button();
            lTimer = new Label();
            SuspendLayout();
            // 
            // btnRedOption
            // 
            btnRedOption.BackColor = Color.FromArgb(225, 40, 60);
            btnRedOption.Enabled = false;
            btnRedOption.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnRedOption.ForeColor = Color.White;
            btnRedOption.Location = new Point(12, 208);
            btnRedOption.Name = "btnRedOption";
            btnRedOption.Size = new Size(377, 90);
            btnRedOption.TabIndex = 27;
            btnRedOption.Text = "Red option";
            btnRedOption.UseVisualStyleBackColor = false;
            btnRedOption.Click += btnRedOption_Click;
            // 
            // btnBlueOption
            // 
            btnBlueOption.BackColor = Color.FromArgb(0, 119, 255);
            btnBlueOption.Enabled = false;
            btnBlueOption.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnBlueOption.ForeColor = Color.White;
            btnBlueOption.Location = new Point(411, 208);
            btnBlueOption.Name = "btnBlueOption";
            btnBlueOption.Size = new Size(377, 90);
            btnBlueOption.TabIndex = 28;
            btnBlueOption.Text = "Blue option";
            btnBlueOption.UseVisualStyleBackColor = false;
            btnBlueOption.Click += btnBlueOption_Click;
            // 
            // btnYellowOption
            // 
            btnYellowOption.BackColor = Color.FromArgb(255, 204, 0);
            btnYellowOption.Enabled = false;
            btnYellowOption.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnYellowOption.ForeColor = Color.White;
            btnYellowOption.Location = new Point(12, 334);
            btnYellowOption.Name = "btnYellowOption";
            btnYellowOption.Size = new Size(377, 90);
            btnYellowOption.TabIndex = 29;
            btnYellowOption.Text = "Yellow option";
            btnYellowOption.UseVisualStyleBackColor = false;
            btnYellowOption.Click += btnYellowOption_Click;
            // 
            // btnGreenOption
            // 
            btnGreenOption.BackColor = Color.FromArgb(4, 191, 14);
            btnGreenOption.Enabled = false;
            btnGreenOption.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnGreenOption.ForeColor = Color.White;
            btnGreenOption.Location = new Point(411, 334);
            btnGreenOption.Name = "btnGreenOption";
            btnGreenOption.Size = new Size(377, 90);
            btnGreenOption.TabIndex = 30;
            btnGreenOption.Text = "Green option";
            btnGreenOption.UseVisualStyleBackColor = false;
            btnGreenOption.Click += btnGreenOption_Click;
            // 
            // lQuestion
            // 
            lQuestion.AutoSize = true;
            lQuestion.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lQuestion.ForeColor = Color.White;
            lQuestion.Location = new Point(242, 47);
            lQuestion.Name = "lQuestion";
            lQuestion.Size = new Size(295, 37);
            lQuestion.TabIndex = 31;
            lQuestion.Text = "Question must be here";
            lQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.White;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.ForeColor = SystemColors.ControlText;
            btnNext.Location = new Point(701, 12);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 33;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // btnStopQuiz
            // 
            btnStopQuiz.BackColor = Color.White;
            btnStopQuiz.FlatStyle = FlatStyle.Flat;
            btnStopQuiz.ForeColor = SystemColors.ControlText;
            btnStopQuiz.Location = new Point(29, 12);
            btnStopQuiz.Name = "btnStopQuiz";
            btnStopQuiz.Size = new Size(75, 23);
            btnStopQuiz.TabIndex = 32;
            btnStopQuiz.Text = "Stop";
            btnStopQuiz.UseVisualStyleBackColor = false;
            btnStopQuiz.Click += btnStopQuiz_Click;
            // 
            // lTimer
            // 
            lTimer.AutoSize = true;
            lTimer.Font = new Font("Segoe UI", 20F);
            lTimer.ForeColor = Color.White;
            lTimer.Location = new Point(12, 118);
            lTimer.Name = "lTimer";
            lTimer.Size = new Size(58, 37);
            lTimer.TabIndex = 34;
            lTimer.Text = "00s";
            lTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InGameQuestionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(800, 450);
            Controls.Add(lTimer);
            Controls.Add(btnNext);
            Controls.Add(btnStopQuiz);
            Controls.Add(lQuestion);
            Controls.Add(btnGreenOption);
            Controls.Add(btnYellowOption);
            Controls.Add(btnBlueOption);
            Controls.Add(btnRedOption);
            Name = "InGameQuestionForm";
            Text = "InGameQuestionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRedOption;
        private Button btnBlueOption;
        private Button btnYellowOption;
        private Button btnGreenOption;
        private Label lQuestion;
        private Button btnNext;
        private Button btnStopQuiz;
        private Label lTimer;
    }
}