
namespace EnrollmentSystemApp
{
    partial class frmAdminStudents
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.lbTitle);
            this.panel2.Controls.Add(this.txtUserID);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.cbCourse);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1095, 205);
            this.panel2.TabIndex = 18;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(948, 173);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 29);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete Student";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(798, 173);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 29);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Update Student";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(670, 173);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 29);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Create Student";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.Color.Black;
            this.lbTitle.Location = new System.Drawing.Point(3, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(174, 42);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "Students";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(551, 101);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(24, 27);
            this.txtUserID.TabIndex = 14;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.LightGray;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(670, 54);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search course";
            this.txtSearch.Size = new System.Drawing.Size(422, 27);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cbCourse
            // 
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Location = new System.Drawing.Point(0, 173);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(250, 28);
            this.cbCourse.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvStudents);
            this.panel1.Location = new System.Drawing.Point(12, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 539);
            this.panel1.TabIndex = 19;
            // 
            // dgvStudents
            // 
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(3, 3);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 29;
            this.dgvStudents.Size = new System.Drawing.Size(1089, 533);
            this.dgvStudents.TabIndex = 0;
            // 
            // frmAdminStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1119, 774);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminStudents";
            this.Load += new System.EventHandler(this.frmAdminStudents_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}