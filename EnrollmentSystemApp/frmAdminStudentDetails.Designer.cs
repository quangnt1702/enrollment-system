
namespace EnrollmentSystemApp
{
    partial class frmAdminStudentDetails
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
            this.txtStatusID = new System.Windows.Forms.TextBox();
            this.txtRoleID = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lbStatusID = new System.Windows.Forms.Label();
            this.lbRoleID = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbLecturerName = new System.Windows.Forms.Label();
            this.lbLecturerID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStatusID
            // 
            this.txtStatusID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStatusID.Location = new System.Drawing.Point(277, 403);
            this.txtStatusID.Name = "txtStatusID";
            this.txtStatusID.Size = new System.Drawing.Size(325, 38);
            this.txtStatusID.TabIndex = 53;
            // 
            // txtRoleID
            // 
            this.txtRoleID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRoleID.Location = new System.Drawing.Point(277, 337);
            this.txtRoleID.Name = "txtRoleID";
            this.txtRoleID.Size = new System.Drawing.Size(325, 38);
            this.txtRoleID.TabIndex = 52;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhone.Location = new System.Drawing.Point(277, 225);
            this.txtPhone.Mask = "00000000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(325, 38);
            this.txtPhone.TabIndex = 50;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(277, 169);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(325, 38);
            this.txtPassword.TabIndex = 49;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnCancel.Location = new System.Drawing.Point(418, 473);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 68);
            this.btnCancel.TabIndex = 55;
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
            this.btnSave.Location = new System.Drawing.Point(193, 473);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 68);
            this.btnSave.TabIndex = 54;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(277, 282);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(325, 38);
            this.txtEmail.TabIndex = 51;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStudentName.Location = new System.Drawing.Point(277, 109);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(325, 38);
            this.txtStudentName.TabIndex = 48;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStudentID.Location = new System.Drawing.Point(277, 50);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(325, 38);
            this.txtStudentID.TabIndex = 47;
            // 
            // lbStatusID
            // 
            this.lbStatusID.AutoSize = true;
            this.lbStatusID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStatusID.Location = new System.Drawing.Point(78, 406);
            this.lbStatusID.Name = "lbStatusID";
            this.lbStatusID.Size = new System.Drawing.Size(76, 31);
            this.lbStatusID.TabIndex = 46;
            this.lbStatusID.Text = "Status";
            // 
            // lbRoleID
            // 
            this.lbRoleID.AutoSize = true;
            this.lbRoleID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRoleID.Location = new System.Drawing.Point(78, 340);
            this.lbRoleID.Name = "lbRoleID";
            this.lbRoleID.Size = new System.Drawing.Size(58, 31);
            this.lbRoleID.TabIndex = 45;
            this.lbRoleID.Text = "Role";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.Location = new System.Drawing.Point(78, 285);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(70, 31);
            this.lbEmail.TabIndex = 44;
            this.lbEmail.Text = "Email";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPhone.Location = new System.Drawing.Point(78, 228);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(78, 31);
            this.lbPhone.TabIndex = 43;
            this.lbPhone.Text = "Phone";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.Location = new System.Drawing.Point(78, 172);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(110, 31);
            this.lbPassword.TabIndex = 42;
            this.lbPassword.Text = "Password";
            // 
            // lbLecturerName
            // 
            this.lbLecturerName.AutoSize = true;
            this.lbLecturerName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLecturerName.Location = new System.Drawing.Point(78, 112);
            this.lbLecturerName.Name = "lbLecturerName";
            this.lbLecturerName.Size = new System.Drawing.Size(160, 31);
            this.lbLecturerName.TabIndex = 41;
            this.lbLecturerName.Text = "Student Name";
            // 
            // lbLecturerID
            // 
            this.lbLecturerID.AutoSize = true;
            this.lbLecturerID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLecturerID.Location = new System.Drawing.Point(78, 53);
            this.lbLecturerID.Name = "lbLecturerID";
            this.lbLecturerID.Size = new System.Drawing.Size(121, 31);
            this.lbLecturerID.TabIndex = 40;
            this.lbLecturerID.Text = "Student ID";
            // 
            // frmAdminStudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(719, 572);
            this.Controls.Add(this.txtStatusID);
            this.Controls.Add(this.txtRoleID);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lbStatusID);
            this.Controls.Add(this.lbRoleID);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbLecturerName);
            this.Controls.Add(this.lbLecturerID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminStudentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminStudentDetails";
            this.Load += new System.EventHandler(this.frmAdminStudentDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStatusID;
        private System.Windows.Forms.TextBox txtRoleID;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lbStatusID;
        private System.Windows.Forms.Label lbRoleID;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbLecturerName;
        private System.Windows.Forms.Label lbLecturerID;
    }
}