namespace _14_CreateDialogWinForms
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
            this.btnShowLoginForm = new System.Windows.Forms.Button();
            this.btnShowRegisterForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowLoginForm
            // 
            this.btnShowLoginForm.Location = new System.Drawing.Point(26, 35);
            this.btnShowLoginForm.Name = "btnShowLoginForm";
            this.btnShowLoginForm.Size = new System.Drawing.Size(123, 63);
            this.btnShowLoginForm.TabIndex = 0;
            this.btnShowLoginForm.Text = "Відкрити форму для входу";
            this.btnShowLoginForm.UseVisualStyleBackColor = true;
            this.btnShowLoginForm.Click += new System.EventHandler(this.btnShowLoginForm_Click);
            // 
            // btnShowRegisterForm
            // 
            this.btnShowRegisterForm.Location = new System.Drawing.Point(26, 117);
            this.btnShowRegisterForm.Name = "btnShowRegisterForm";
            this.btnShowRegisterForm.Size = new System.Drawing.Size(123, 63);
            this.btnShowRegisterForm.TabIndex = 1;
            this.btnShowRegisterForm.Text = "Реєструватися";
            this.btnShowRegisterForm.UseVisualStyleBackColor = true;
            this.btnShowRegisterForm.Click += new System.EventHandler(this.btnShowRegisterForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 374);
            this.Controls.Add(this.btnShowRegisterForm);
            this.Controls.Add(this.btnShowLoginForm);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Головна форма";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnShowLoginForm;
        private Button btnShowRegisterForm;
    }
}