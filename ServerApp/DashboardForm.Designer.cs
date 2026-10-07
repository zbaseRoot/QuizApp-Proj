namespace ServerApp
{
    partial class DashboardForm
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
            tbCreateQuizName = new TextBox();
            flowLayoutPanelQuizs = new FlowLayoutPanel();
            btnCreateQuiz = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // tbCreateQuizName
            // 
            tbCreateQuizName.Location = new Point(26, 48);
            tbCreateQuizName.Multiline = true;
            tbCreateQuizName.Name = "tbCreateQuizName";
            tbCreateQuizName.PlaceholderText = "Enter quiz name";
            tbCreateQuizName.Size = new Size(750, 34);
            tbCreateQuizName.TabIndex = 0;
            // 
            // flowLayoutPanelQuizs
            // 
            flowLayoutPanelQuizs.AutoScroll = true;
            flowLayoutPanelQuizs.Dock = DockStyle.Bottom;
            flowLayoutPanelQuizs.Location = new Point(0, 215);
            flowLayoutPanelQuizs.Name = "flowLayoutPanelQuizs";
            flowLayoutPanelQuizs.Size = new Size(807, 235);
            flowLayoutPanelQuizs.TabIndex = 1;
            // 
            // btnCreateQuiz
            // 
            btnCreateQuiz.BackColor = Color.White;
            btnCreateQuiz.FlatStyle = FlatStyle.Flat;
            btnCreateQuiz.Location = new Point(328, 88);
            btnCreateQuiz.Name = "btnCreateQuiz";
            btnCreateQuiz.Size = new Size(149, 37);
            btnCreateQuiz.TabIndex = 2;
            btnCreateQuiz.Text = "Create";
            btnCreateQuiz.UseVisualStyleBackColor = false;
            btnCreateQuiz.Click += btnCreateQuiz_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(328, 175);
            label1.Name = "label1";
            label1.Size = new Size(149, 37);
            label1.TabIndex = 5;
            label1.Text = "Select quiz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(322, 8);
            label2.Name = "label2";
            label2.Size = new Size(155, 37);
            label2.TabIndex = 6;
            label2.Text = "Create quiz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(372, 138);
            label3.Name = "label3";
            label3.Size = new Size(54, 37);
            label3.TabIndex = 7;
            label3.Text = "OR";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(807, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCreateQuiz);
            Controls.Add(flowLayoutPanelQuizs);
            Controls.Add(tbCreateQuizName);
            Location = new Point(200, 200);
            Name = "DashboardForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbCreateQuizName;
        private FlowLayoutPanel flowLayoutPanelQuizs;
        private Button btnCreateQuiz;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}