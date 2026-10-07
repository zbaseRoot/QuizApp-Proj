namespace ClientApp
{
    partial class QuestionForm
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
            lQuestion = new Label();
            panel1 = new Panel();
            btnAOption1 = new Button();
            btnBOption2 = new Button();
            btnCOption3 = new Button();
            btnDOption4 = new Button();
            lSeconds = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lQuestion
            // 
            lQuestion.AutoSize = true;
            lQuestion.BackColor = Color.Transparent;
            lQuestion.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lQuestion.ForeColor = Color.Black;
            lQuestion.Location = new Point(3, 35);
            lQuestion.Name = "lQuestion";
            lQuestion.Size = new Size(270, 37);
            lQuestion.TabIndex = 8;
            lQuestion.Text = "Question be here...";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lQuestion);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(765, 113);
            panel1.TabIndex = 12;
            // 
            // btnAOption1
            // 
            btnAOption1.BackColor = Color.FromArgb(225, 40, 60);
            btnAOption1.FlatStyle = FlatStyle.Flat;
            btnAOption1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAOption1.ForeColor = Color.White;
            btnAOption1.Location = new Point(12, 215);
            btnAOption1.Name = "btnAOption1";
            btnAOption1.Size = new Size(373, 104);
            btnAOption1.TabIndex = 13;
            btnAOption1.Text = "option1";
            btnAOption1.UseVisualStyleBackColor = false;
            btnAOption1.Click += btnAOption1_Click;
            // 
            // btnBOption2
            // 
            btnBOption2.BackColor = Color.FromArgb(0, 119, 255);
            btnBOption2.FlatStyle = FlatStyle.Flat;
            btnBOption2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnBOption2.ForeColor = Color.White;
            btnBOption2.Location = new Point(404, 215);
            btnBOption2.Name = "btnBOption2";
            btnBOption2.Size = new Size(373, 104);
            btnBOption2.TabIndex = 14;
            btnBOption2.Text = "option2";
            btnBOption2.UseVisualStyleBackColor = false;
            btnBOption2.Click += btnBOption2_Click;
            // 
            // btnCOption3
            // 
            btnCOption3.BackColor = Color.FromArgb(255, 204, 0);
            btnCOption3.FlatStyle = FlatStyle.Flat;
            btnCOption3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCOption3.ForeColor = Color.White;
            btnCOption3.Location = new Point(12, 334);
            btnCOption3.Name = "btnCOption3";
            btnCOption3.Size = new Size(373, 104);
            btnCOption3.TabIndex = 15;
            btnCOption3.Text = "option3";
            btnCOption3.UseVisualStyleBackColor = false;
            btnCOption3.Click += btnCOption3_Click;
            // 
            // btnDOption4
            // 
            btnDOption4.BackColor = Color.FromArgb(4, 191, 14);
            btnDOption4.FlatStyle = FlatStyle.Flat;
            btnDOption4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnDOption4.ForeColor = Color.White;
            btnDOption4.Location = new Point(404, 334);
            btnDOption4.Name = "btnDOption4";
            btnDOption4.Size = new Size(373, 104);
            btnDOption4.TabIndex = 16;
            btnDOption4.Text = "option4";
            btnDOption4.UseVisualStyleBackColor = false;
            btnDOption4.Click += btnDOption4_Click;
            // 
            // lSeconds
            // 
            lSeconds.AutoSize = true;
            lSeconds.BackColor = Color.Transparent;
            lSeconds.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lSeconds.ForeColor = Color.Black;
            lSeconds.Location = new Point(0, 0);
            lSeconds.Name = "lSeconds";
            lSeconds.Size = new Size(141, 37);
            lSeconds.TabIndex = 8;
            lSeconds.Text = "Seconds: ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lSeconds);
            panel2.Location = new Point(12, 149);
            panel2.Name = "panel2";
            panel2.Size = new Size(206, 40);
            panel2.TabIndex = 13;
            // 
            // QuestionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(788, 450);
            Controls.Add(panel2);
            Controls.Add(btnDOption4);
            Controls.Add(btnCOption3);
            Controls.Add(btnBOption2);
            Controls.Add(btnAOption1);
            Controls.Add(panel1);
            Name = "QuestionForm";
            Text = "Quiz ClientApp - Question";
            Load += QuestionForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lQuestion;
        private Panel panel1;
        private Button btnAOption1;
        private Button btnBOption2;
        private Button btnCOption3;
        private Button btnDOption4;
        private Panel panel2;
        private Label lSeconds;
    }
}