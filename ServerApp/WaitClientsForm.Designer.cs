namespace ServerApp
{
    partial class WaitClientsForm
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
            lbConnectedClients = new ListBox();
            label2 = new Label();
            btnStopQuiz = new Button();
            btnStartQuiz = new Button();
            SuspendLayout();
            // 
            // lbConnectedClients
            // 
            lbConnectedClients.FormattingEnabled = true;
            lbConnectedClients.Location = new Point(28, 64);
            lbConnectedClients.Name = "lbConnectedClients";
            lbConnectedClients.Size = new Size(747, 379);
            lbConnectedClients.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(276, 9);
            label2.Name = "label2";
            label2.Size = new Size(249, 37);
            label2.TabIndex = 7;
            label2.Text = "Connected clients";
            // 
            // btnStopQuiz
            // 
            btnStopQuiz.BackColor = Color.White;
            btnStopQuiz.FlatStyle = FlatStyle.Flat;
            btnStopQuiz.Location = new Point(28, 23);
            btnStopQuiz.Name = "btnStopQuiz";
            btnStopQuiz.Size = new Size(75, 23);
            btnStopQuiz.TabIndex = 8;
            btnStopQuiz.Text = "Stop";
            btnStopQuiz.UseVisualStyleBackColor = false;
            btnStopQuiz.Click += btnStopQuiz_Click;
            // 
            // btnStartQuiz
            // 
            btnStartQuiz.BackColor = Color.White;
            btnStartQuiz.FlatStyle = FlatStyle.Flat;
            btnStartQuiz.Location = new Point(700, 23);
            btnStartQuiz.Name = "btnStartQuiz";
            btnStartQuiz.Size = new Size(75, 23);
            btnStartQuiz.TabIndex = 9;
            btnStartQuiz.Text = "Start";
            btnStartQuiz.UseVisualStyleBackColor = false;
            btnStartQuiz.Click += btnStartQuiz_Click;
            // 
            // WaitClientsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStartQuiz);
            Controls.Add(btnStopQuiz);
            Controls.Add(label2);
            Controls.Add(lbConnectedClients);
            Name = "WaitClientsForm";
            Text = "WaitClientsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbConnectedClients;
        private Label label2;
        private Button btnStopQuiz;
        private Button btnStartQuiz;
    }
}