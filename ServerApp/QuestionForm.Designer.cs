namespace ServerApp
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
            tbRedOption = new TextBox();
            tbBlueOption = new TextBox();
            tbYellowOption = new TextBox();
            tbGreenOption = new TextBox();
            rbYellowOption = new RadioButton();
            rbGreenOption = new RadioButton();
            rbRedOption = new RadioButton();
            rbBlueOption = new RadioButton();
            label2 = new Label();
            tbQuestion = new TextBox();
            label1 = new Label();
            btnSave = new Button();
            btnBackQuestions = new Button();
            btnDeleteQuestion = new Button();
            SuspendLayout();
            // 
            // tbRedOption
            // 
            tbRedOption.BackColor = Color.FromArgb(225, 40, 60);
            tbRedOption.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbRedOption.ForeColor = Color.White;
            tbRedOption.Location = new Point(12, 186);
            tbRedOption.Multiline = true;
            tbRedOption.Name = "tbRedOption";
            tbRedOption.PlaceholderText = "Red option";
            tbRedOption.Size = new Size(377, 90);
            tbRedOption.TabIndex = 0;
            tbRedOption.Text = "Red option";
            // 
            // tbBlueOption
            // 
            tbBlueOption.BackColor = Color.FromArgb(0, 119, 255);
            tbBlueOption.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbBlueOption.ForeColor = Color.White;
            tbBlueOption.Location = new Point(411, 186);
            tbBlueOption.Multiline = true;
            tbBlueOption.Name = "tbBlueOption";
            tbBlueOption.PlaceholderText = "Blue option";
            tbBlueOption.Size = new Size(377, 90);
            tbBlueOption.TabIndex = 1;
            tbBlueOption.Text = "Blue option";
            // 
            // tbYellowOption
            // 
            tbYellowOption.BackColor = Color.FromArgb(255, 204, 0);
            tbYellowOption.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbYellowOption.ForeColor = Color.White;
            tbYellowOption.Location = new Point(12, 312);
            tbYellowOption.Multiline = true;
            tbYellowOption.Name = "tbYellowOption";
            tbYellowOption.PlaceholderText = "Yellow option";
            tbYellowOption.Size = new Size(377, 90);
            tbYellowOption.TabIndex = 2;
            tbYellowOption.Text = "Yellow option";
            // 
            // tbGreenOption
            // 
            tbGreenOption.BackColor = Color.FromArgb(4, 191, 14);
            tbGreenOption.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbGreenOption.ForeColor = Color.White;
            tbGreenOption.Location = new Point(411, 312);
            tbGreenOption.Multiline = true;
            tbGreenOption.Name = "tbGreenOption";
            tbGreenOption.PlaceholderText = "Green option";
            tbGreenOption.Size = new Size(377, 90);
            tbGreenOption.TabIndex = 3;
            tbGreenOption.Text = "Green option";
            // 
            // rbYellowOption
            // 
            rbYellowOption.AutoSize = true;
            rbYellowOption.ForeColor = Color.White;
            rbYellowOption.Location = new Point(476, 12);
            rbYellowOption.Name = "rbYellowOption";
            rbYellowOption.Size = new Size(97, 19);
            rbYellowOption.TabIndex = 4;
            rbYellowOption.Text = "Yellow option";
            rbYellowOption.UseVisualStyleBackColor = true;
            // 
            // rbGreenOption
            // 
            rbGreenOption.AutoSize = true;
            rbGreenOption.ForeColor = Color.White;
            rbGreenOption.Location = new Point(579, 12);
            rbGreenOption.Name = "rbGreenOption";
            rbGreenOption.Size = new Size(94, 19);
            rbGreenOption.TabIndex = 5;
            rbGreenOption.Text = "Green option";
            rbGreenOption.UseVisualStyleBackColor = true;
            // 
            // rbRedOption
            // 
            rbRedOption.AutoSize = true;
            rbRedOption.Checked = true;
            rbRedOption.ForeColor = Color.White;
            rbRedOption.Location = new Point(295, 12);
            rbRedOption.Name = "rbRedOption";
            rbRedOption.Size = new Size(83, 19);
            rbRedOption.TabIndex = 6;
            rbRedOption.TabStop = true;
            rbRedOption.Text = "Red option";
            rbRedOption.UseVisualStyleBackColor = true;
            // 
            // rbBlueOption
            // 
            rbBlueOption.AutoSize = true;
            rbBlueOption.ForeColor = Color.White;
            rbBlueOption.Location = new Point(384, 12);
            rbBlueOption.Name = "rbBlueOption";
            rbBlueOption.Size = new Size(86, 19);
            rbBlueOption.TabIndex = 7;
            rbBlueOption.Text = "Blue option";
            rbBlueOption.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(142, 12);
            label2.Name = "label2";
            label2.Size = new Size(137, 19);
            label2.TabIndex = 8;
            label2.Text = "Select correct option:";
            // 
            // tbQuestion
            // 
            tbQuestion.BackColor = Color.White;
            tbQuestion.Location = new Point(96, 101);
            tbQuestion.Multiline = true;
            tbQuestion.Name = "tbQuestion";
            tbQuestion.PlaceholderText = "Enter question";
            tbQuestion.Size = new Size(615, 60);
            tbQuestion.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(370, 79);
            label1.Name = "label1";
            label1.Size = new Size(65, 19);
            label1.TabIndex = 10;
            label1.Text = "Question";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(713, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnBackQuestions
            // 
            btnBackQuestions.BackColor = Color.White;
            btnBackQuestions.FlatStyle = FlatStyle.Flat;
            btnBackQuestions.Location = new Point(12, 5);
            btnBackQuestions.Name = "btnBackQuestions";
            btnBackQuestions.Size = new Size(75, 23);
            btnBackQuestions.TabIndex = 16;
            btnBackQuestions.Text = "Back";
            btnBackQuestions.UseVisualStyleBackColor = false;
            btnBackQuestions.Click += btnBackQuestions_Click;
            // 
            // btnDeleteQuestion
            // 
            btnDeleteQuestion.BackColor = Color.White;
            btnDeleteQuestion.FlatStyle = FlatStyle.Flat;
            btnDeleteQuestion.Location = new Point(713, 34);
            btnDeleteQuestion.Name = "btnDeleteQuestion";
            btnDeleteQuestion.Size = new Size(75, 23);
            btnDeleteQuestion.TabIndex = 17;
            btnDeleteQuestion.Text = "Delete";
            btnDeleteQuestion.UseVisualStyleBackColor = false;
            btnDeleteQuestion.Click += btnDeleteQuestion_Click;
            // 
            // QuestionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteQuestion);
            Controls.Add(btnBackQuestions);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(tbQuestion);
            Controls.Add(label2);
            Controls.Add(rbBlueOption);
            Controls.Add(rbRedOption);
            Controls.Add(rbGreenOption);
            Controls.Add(rbYellowOption);
            Controls.Add(tbGreenOption);
            Controls.Add(tbYellowOption);
            Controls.Add(tbBlueOption);
            Controls.Add(tbRedOption);
            Name = "QuestionForm";
            Text = "QuestionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbRedOption;
        private TextBox tbBlueOption;
        private TextBox tbYellowOption;
        private TextBox tbGreenOption;
        private RadioButton rbYellowOption;
        private RadioButton rbGreenOption;
        private RadioButton rbRedOption;
        private RadioButton rbBlueOption;
        private Label label2;
        private TextBox tbQuestion;
        private Label label1;
        private Button btnSave;
        private Button btnBackQuestions;
        private Button btnDeleteQuestion;
    }
}