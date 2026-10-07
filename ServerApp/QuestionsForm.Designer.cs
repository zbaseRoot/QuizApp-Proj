namespace ServerApp
{
    partial class QuestionsForm
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
            flowLayoutPanelQuestions = new FlowLayoutPanel();
            label2 = new Label();
            btnBackToMain = new Button();
            btnStartQuiz = new Button();
            btnAddQuestion = new Button();
            btnDeleteQuiz = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanelQuestions
            // 
            flowLayoutPanelQuestions.AutoScroll = true;
            flowLayoutPanelQuestions.Dock = DockStyle.Bottom;
            flowLayoutPanelQuestions.Location = new Point(0, 71);
            flowLayoutPanelQuestions.Name = "flowLayoutPanelQuestions";
            flowLayoutPanelQuestions.Size = new Size(809, 379);
            flowLayoutPanelQuestions.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(254, 9);
            label2.Name = "label2";
            label2.Size = new Size(290, 37);
            label2.TabIndex = 7;
            label2.Text = "Select or add question";
            // 
            // btnBackToMain
            // 
            btnBackToMain.BackColor = Color.White;
            btnBackToMain.FlatStyle = FlatStyle.Flat;
            btnBackToMain.ForeColor = SystemColors.ControlText;
            btnBackToMain.Location = new Point(29, 23);
            btnBackToMain.Name = "btnBackToMain";
            btnBackToMain.Size = new Size(75, 23);
            btnBackToMain.TabIndex = 8;
            btnBackToMain.Text = "Back";
            btnBackToMain.UseVisualStyleBackColor = false;
            btnBackToMain.Click += btnBackToMain_Click;
            // 
            // btnStartQuiz
            // 
            btnStartQuiz.BackColor = Color.White;
            btnStartQuiz.FlatStyle = FlatStyle.Flat;
            btnStartQuiz.ForeColor = SystemColors.ControlText;
            btnStartQuiz.Location = new Point(707, 23);
            btnStartQuiz.Name = "btnStartQuiz";
            btnStartQuiz.Size = new Size(75, 23);
            btnStartQuiz.TabIndex = 9;
            btnStartQuiz.Text = "Start quiz";
            btnStartQuiz.UseVisualStyleBackColor = false;
            btnStartQuiz.Click += btnStartQuiz_Click;
            // 
            // btnAddQuestion
            // 
            btnAddQuestion.BackColor = Color.White;
            btnAddQuestion.FlatStyle = FlatStyle.Flat;
            btnAddQuestion.ForeColor = SystemColors.ControlText;
            btnAddQuestion.Location = new Point(591, 23);
            btnAddQuestion.Name = "btnAddQuestion";
            btnAddQuestion.Size = new Size(90, 23);
            btnAddQuestion.TabIndex = 10;
            btnAddQuestion.Text = "Add question";
            btnAddQuestion.UseVisualStyleBackColor = false;
            btnAddQuestion.Click += btnAddQuestion_Click;
            // 
            // btnDeleteQuiz
            // 
            btnDeleteQuiz.BackColor = Color.White;
            btnDeleteQuiz.FlatStyle = FlatStyle.Flat;
            btnDeleteQuiz.ForeColor = SystemColors.ControlText;
            btnDeleteQuiz.Location = new Point(132, 23);
            btnDeleteQuiz.Name = "btnDeleteQuiz";
            btnDeleteQuiz.Size = new Size(75, 23);
            btnDeleteQuiz.TabIndex = 11;
            btnDeleteQuiz.Text = "Delete quiz";
            btnDeleteQuiz.UseVisualStyleBackColor = false;
            btnDeleteQuiz.Click += btnDeleteQuiz_Click;
            // 
            // QuestionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(809, 450);
            Controls.Add(btnDeleteQuiz);
            Controls.Add(btnAddQuestion);
            Controls.Add(btnStartQuiz);
            Controls.Add(btnBackToMain);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanelQuestions);
            ForeColor = Color.Black;
            Location = new Point(200, 200);
            Name = "QuestionsForm";
            Text = "QuestionsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelQuestions;
        private Label label2;
        private Button btnBackToMain;
        private Button btnStartQuiz;
        private Button btnAddQuestion;
        private Button btnDeleteQuiz;
    }
}