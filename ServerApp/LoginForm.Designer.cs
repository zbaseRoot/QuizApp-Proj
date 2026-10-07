namespace ServerApp
{
    partial class LoginForm
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
            tbRegUsername = new TextBox();
            tbRegPass = new TextBox();
            tbLoginPass = new TextBox();
            tbLoginUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            btnReg = new Button();
            SuspendLayout();
            // 
            // tbRegUsername
            // 
            tbRegUsername.Location = new Point(530, 144);
            tbRegUsername.Multiline = true;
            tbRegUsername.Name = "tbRegUsername";
            tbRegUsername.PlaceholderText = "Username";
            tbRegUsername.Size = new Size(205, 44);
            tbRegUsername.TabIndex = 0;
            // 
            // tbRegPass
            // 
            tbRegPass.Location = new Point(530, 213);
            tbRegPass.Multiline = true;
            tbRegPass.Name = "tbRegPass";
            tbRegPass.PlaceholderText = "Password";
            tbRegPass.Size = new Size(205, 44);
            tbRegPass.TabIndex = 1;
            // 
            // tbLoginPass
            // 
            tbLoginPass.Location = new Point(64, 213);
            tbLoginPass.Multiline = true;
            tbLoginPass.Name = "tbLoginPass";
            tbLoginPass.PlaceholderText = "Password";
            tbLoginPass.Size = new Size(205, 44);
            tbLoginPass.TabIndex = 3;
            // 
            // tbLoginUsername
            // 
            tbLoginUsername.Location = new Point(64, 144);
            tbLoginUsername.Multiline = true;
            tbLoginUsername.Name = "tbLoginUsername";
            tbLoginUsername.PlaceholderText = "Username";
            tbLoginUsername.Size = new Size(205, 44);
            tbLoginUsername.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(122, 104);
            label1.Name = "label1";
            label1.Size = new Size(85, 37);
            label1.TabIndex = 4;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(571, 104);
            label2.Name = "label2";
            label2.Size = new Size(116, 37);
            label2.TabIndex = 5;
            label2.Text = "Register";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(51, 51, 51);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(109, 263);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(117, 36);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnReg
            // 
            btnReg.BackColor = Color.FromArgb(51, 51, 51);
            btnReg.FlatStyle = FlatStyle.Flat;
            btnReg.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReg.ForeColor = Color.White;
            btnReg.Location = new Point(580, 263);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(117, 36);
            btnReg.TabIndex = 7;
            btnReg.Text = "Register";
            btnReg.UseVisualStyleBackColor = false;
            btnReg.Click += btnReg_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReg);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbLoginPass);
            Controls.Add(tbLoginUsername);
            Controls.Add(tbRegPass);
            Controls.Add(tbRegUsername);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbRegUsername;
        private TextBox tbRegPass;
        private TextBox tbLoginPass;
        private TextBox tbLoginUsername;
        private Label label1;
        private Label label2;
        private Button btnLogin;
        private Button btnReg;
    }
}