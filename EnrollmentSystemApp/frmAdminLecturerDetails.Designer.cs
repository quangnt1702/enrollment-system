
namespace EnrollmentSystemApp
{
    partial class frmAdminLecturerDetails
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLecturerName = new System.Windows.Forms.TextBox();
            this.txtLecturerID = new System.Windows.Forms.TextBox();
            this.lbStatusID = new System.Windows.Forms.Label();
            this.lbRoleID = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbLecturerName = new System.Windows.Forms.Label();
            this.lbLecturerID = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtRoleID = new System.Windows.Forms.TextBox();
            this.txtStatusID = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnCancel.Location = new System.Drawing.Point(383, 490);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 59);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGray;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnSave.Location = new System.Drawing.Point(171, 490);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 59);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(271, 298);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(329, 38);
            this.txtEmail.TabIndex = 30;
            // 
            // txtLecturerName
            // 
            this.txtLecturerName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLecturerName.Location = new System.Drawing.Point(271, 136);
            this.txtLecturerName.Name = "txtLecturerName";
            this.txtLecturerName.Size = new System.Drawing.Size(329, 38);
            this.txtLecturerName.TabIndex = 27;
            // 
            // txtLecturerID
            // 
            this.txtLecturerID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLecturerID.Location = new System.Drawing.Point(271, 77);
            this.txtLecturerID.Name = "txtLecturerID";
            this.txtLecturerID.Size = new System.Drawing.Size(329, 38);
            this.txtLecturerID.TabIndex = 26;
            // 
            // lbStatusID
            // 
            this.lbStatusID.AutoSize = true;
            this.lbStatusID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStatusID.Location = new System.Drawing.Point(72, 420);
            this.lbStatusID.Name = "lbStatusID";
            this.lbStatusID.Size = new System.Drawing.Size(76, 31);
            this.lbStatusID.TabIndex = 25;
            this.lbStatusID.Text = "Status";
            // 
            // lbRoleID
            // 
            this.lbRoleID.AutoSize = true;
            this.lbRoleID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRoleID.Location = new System.Drawing.Point(72, 356);
            this.lbRoleID.Name = "lbRoleID";
            this.lbRoleID.Size = new System.Drawing.Size(58, 31);
            this.lbRoleID.TabIndex = 24;
            this.lbRoleID.Text = "Role";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.Location = new System.Drawing.Point(72, 301);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(70, 31);
            this.lbEmail.TabIndex = 23;
            this.lbEmail.Text = "Email";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPhone.Location = new System.Drawing.Point(72, 245);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(78, 31);
            this.lbPhone.TabIndex = 22;
            this.lbPhone.Text = "Phone";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.Location = new System.Drawing.Point(72, 192);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(110, 31);
            this.lbPassword.TabIndex = 20;
            this.lbPassword.Text = "Password";
            // 
            // lbLecturerName
            // 
            this.lbLecturerName.AutoSize = true;
            this.lbLecturerName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLecturerName.Location = new System.Drawing.Point(68, 139);
            this.lbLecturerName.Name = "lbLecturerName";
            this.lbLecturerName.Size = new System.Drawing.Size(164, 31);
            this.lbLecturerName.TabIndex = 19;
            this.lbLecturerName.Text = "Lecturer Name";
            // 
            // lbLecturerID
            // 
            this.lbLecturerID.AutoSize = true;
            this.lbLecturerID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLecturerID.Location = new System.Drawing.Point(72, 80);
            this.lbLecturerID.Name = "lbLecturerID";
            this.lbLecturerID.Size = new System.Drawing.Size(125, 31);
            this.lbLecturerID.TabIndex = 18;
            this.lbLecturerID.Text = "Lecturer ID";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(271, 189);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(329, 38);
            this.txtPassword.TabIndex = 36;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhone.Location = new System.Drawing.Point(271, 245);
            this.txtPhone.Mask = "00000000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(329, 38);
            this.txtPhone.TabIndex = 37;
            // 
            // txtRoleID
            // 
            this.txtRoleID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRoleID.Location = new System.Drawing.Point(271, 353);
            this.txtRoleID.Name = "txtRoleID";
            this.txtRoleID.Size = new System.Drawing.Size(329, 38);
            this.txtRoleID.TabIndex = 38;
            // 
            // txtStatusID
            // 
            this.txtStatusID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStatusID.Location = new System.Drawing.Point(271, 417);
            this.txtStatusID.Name = "txtStatusID";
            this.txtStatusID.Size = new System.Drawing.Size(329, 38);
            this.txtStatusID.TabIndex = 39;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(280, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(113, 45);
            this.lbTitle.TabIndex = 40;
            this.lbTitle.Text = "Create";
            // 
            // frmAdminLecturerDetails
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(736, 577);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.txtStatusID);
            this.Controls.Add(this.txtRoleID);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLecturerName);
            this.Controls.Add(this.txtLecturerID);
            this.Controls.Add(this.lbStatusID);
            this.Controls.Add(this.lbRoleID);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbLecturerName);
            this.Controls.Add(this.lbLecturerID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminLecturerDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminLecturerDetails";
            this.Load += new System.EventHandler(this.frmAdminLecturerDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLecturerName;
        private System.Windows.Forms.TextBox txtLecturerID;
        private System.Windows.Forms.Label lbStatusID;
        private System.Windows.Forms.Label lbRoleID;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbLecturerName;
        private System.Windows.Forms.Label lbLecturerID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.TextBox txtRoleID;
        private System.Windows.Forms.TextBox txtStatusID;
        private System.Windows.Forms.Label lbTitle;
    }
}