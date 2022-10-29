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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowLoginForm
            // 
            this.btnShowLoginForm.Location = new System.Drawing.Point(523, 12);
            this.btnShowLoginForm.Name = "btnShowLoginForm";
            this.btnShowLoginForm.Size = new System.Drawing.Size(123, 63);
            this.btnShowLoginForm.TabIndex = 0;
            this.btnShowLoginForm.Text = "Відкрити форму для входу";
            this.btnShowLoginForm.UseVisualStyleBackColor = true;
            this.btnShowLoginForm.Click += new System.EventHandler(this.btnShowLoginForm_Click);
            // 
            // btnShowRegisterForm
            // 
            this.btnShowRegisterForm.Location = new System.Drawing.Point(652, 12);
            this.btnShowRegisterForm.Name = "btnShowRegisterForm";
            this.btnShowRegisterForm.Size = new System.Drawing.Size(123, 63);
            this.btnShowRegisterForm.TabIndex = 1;
            this.btnShowRegisterForm.Text = "Реєструватися";
            this.btnShowRegisterForm.UseVisualStyleBackColor = true;
            this.btnShowRegisterForm.Click += new System.EventHandler(this.btnShowRegisterForm_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColFullName,
            this.ColPhone,
            this.ColGender,
            this.ColImage});
            this.dgvUsers.Location = new System.Drawing.Point(12, 95);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowTemplate.Height = 50;
            this.dgvUsers.Size = new System.Drawing.Size(765, 241);
            this.dgvUsers.TabIndex = 2;
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
            // 
            // ColFullName
            // 
            this.ColFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColFullName.HeaderText = "ПІБ";
            this.ColFullName.Name = "ColFullName";
            this.ColFullName.ReadOnly = true;
            // 
            // ColPhone
            // 
            this.ColPhone.HeaderText = "Телефон";
            this.ColPhone.Name = "ColPhone";
            this.ColPhone.ReadOnly = true;
            this.ColPhone.Width = 150;
            // 
            // ColGender
            // 
            this.ColGender.HeaderText = "Стать";
            this.ColGender.Name = "ColGender";
            this.ColGender.ReadOnly = true;
            // 
            // ColImage
            // 
            this.ColImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColImage.HeaderText = "Фото";
            this.ColImage.Name = "ColImage";
            this.ColImage.ReadOnly = true;
            this.ColImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 60);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 29);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Видалити";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(105, 60);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 29);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Редагувати";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 374);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnShowRegisterForm);
            this.Controls.Add(this.btnShowLoginForm);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Головна форма";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnShowLoginForm;
        private Button btnShowRegisterForm;
        private DataGridView dgvUsers;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColFullName;
        private DataGridViewTextBoxColumn ColPhone;
        private DataGridViewTextBoxColumn ColGender;
        private DataGridViewImageColumn ColImage;
        private Button btnDelete;
        private Button btnEdit;
    }
}