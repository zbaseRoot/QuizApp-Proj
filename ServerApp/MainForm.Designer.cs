namespace ServerApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ILoading = new Label();
            SuspendLayout();
            // 
            // ILoading
            // 
            ILoading.AutoSize = true;
            ILoading.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ILoading.ForeColor = Color.White;
            ILoading.Location = new Point(273, 139);
            ILoading.Name = "ILoading";
            ILoading.Size = new Size(150, 37);
            ILoading.TabIndex = 9;
            ILoading.Text = "Loading...";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(700, 338);
            Controls.Add(ILoading);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Quiz ServerApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ILoading;
    }
}
