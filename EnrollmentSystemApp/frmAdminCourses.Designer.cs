
namespace EnrollmentSystemApp
{
    partial class frmAdminCourses
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
            this.lbTo = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.btnEnding = new System.Windows.Forms.Button();
            this.btnReady = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnAllCourses = new System.Windows.Forms.Button();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnStarting = new System.Windows.Forms.Button();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.cbbSubject = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.lbTo);
            this.panel2.Controls.Add(this.lbFrom);
            this.panel2.Controls.Add(this.btnEnding);
            this.panel2.Controls.Add(this.btnReady);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.lbTitle);
            this.panel2.Controls.Add(this.btnFilter);
            this.panel2.Controls.Add(this.btnAllCourses);
            this.panel2.Controls.Add(this.txtCourseID);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.btnStarting);
            this.panel2.Controls.Add(this.dtpFrom);
            this.panel2.Controls.Add(this.dtpTo);
            this.panel2.Controls.Add(this.cbbSubject);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1095, 205);
            this.panel2.TabIndex = 17;
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Location = new System.Drawing.Point(198, 56);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(25, 20);
            this.lbTo.TabIndex = 33;
            this.lbTo.Text = "To";
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Location = new System.Drawing.Point(14, 56);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(43, 20);
            this.lbFrom.TabIndex = 32;
            this.lbFrom.Text = "From";
            // 
            // btnEnding
            // 
            this.btnEnding.BackColor = System.Drawing.Color.LightGray;
            this.btnEnding.FlatAppearance.BorderSize = 2;
            this.btnEnding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnding.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnEnding.Location = new System.Drawing.Point(180, 167);
            this.btnEnding.Name = "btnEnding";
            this.btnEnding.Size = new System.Drawing.Size(64, 35);
            this.btnEnding.TabIndex = 12;
            this.btnEnding.Text = "Ended";
            this.btnEnding.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnding.UseVisualStyleBackColor = false;
            this.btnEnding.Click += new System.EventHandler(this.btnEnding_Click);
            // 
            // btnReady
            // 
            this.btnReady.BackColor = System.Drawing.Color.LightGray;
            this.btnReady.FlatAppearance.BorderSize = 2;
            this.btnReady.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReady.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReady.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnReady.Location = new System.Drawing.Point(38, 167);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(79, 35);
            this.btnReady.TabIndex = 29;
            this.btnReady.Text = "Waiting";
            this.btnReady.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReady.UseVisualStyleBackColor = false;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightGray;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnDelete.Location = new System.Drawing.Point(644, 167);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 35);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete Course";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightGray;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnUpdate.Location = new System.Drawing.Point(495, 167);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 35);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update Course";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGray;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnAdd.Location = new System.Drawing.Point(331, 167);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 35);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Create New Course";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.Color.Black;
            this.lbTitle.Location = new System.Drawing.Point(3, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(165, 42);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "Courses";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.LightGray;
            this.btnFilter.FlatAppearance.BorderSize = 2;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnFilter.Location = new System.Drawing.Point(229, 87);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(123, 41);
            this.btnFilter.TabIndex = 15;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnAllCourses
            // 
            this.btnAllCourses.BackColor = System.Drawing.Color.LightGray;
            this.btnAllCourses.FlatAppearance.BorderSize = 2;
            this.btnAllCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllCourses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAllCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnAllCourses.Location = new System.Drawing.Point(3, 167);
            this.btnAllCourses.Name = "btnAllCourses";
            this.btnAllCourses.Size = new System.Drawing.Size(44, 35);
            this.btnAllCourses.TabIndex = 10;
            this.btnAllCourses.Text = "All";
            this.btnAllCourses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllCourses.UseVisualStyleBackColor = false;
            this.btnAllCourses.Click += new System.EventHandler(this.btnAllCourses_Click);
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(180, 101);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(24, 27);
            this.txtCourseID.TabIndex = 14;
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
            // btnStarting
            // 
            this.btnStarting.BackColor = System.Drawing.Color.LightGray;
            this.btnStarting.FlatAppearance.BorderSize = 2;
            this.btnStarting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStarting.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStarting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnStarting.Location = new System.Drawing.Point(112, 167);
            this.btnStarting.Name = "btnStarting";
            this.btnStarting.Size = new System.Drawing.Size(75, 35);
            this.btnStarting.TabIndex = 13;
            this.btnStarting.Text = "Started";
            this.btnStarting.UseVisualStyleBackColor = false;
            this.btnStarting.Click += new System.EventHandler(this.btnStarting_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(63, 54);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(129, 27);
            this.dtpFrom.TabIndex = 8;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(229, 54);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(123, 27);
            this.dtpTo.TabIndex = 9;
            // 
            // cbbSubject
            // 
            this.cbbSubject.FormattingEnabled = true;
            this.cbbSubject.Location = new System.Drawing.Point(0, 133);
            this.cbbSubject.Name = "cbbSubject";
            this.cbbSubject.Size = new System.Drawing.Size(244, 28);
            this.cbbSubject.TabIndex = 11;
            this.cbbSubject.SelectedIndexChanged += new System.EventHandler(this.cbbSubject_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.dgvCourses);
            this.panel1.Location = new System.Drawing.Point(12, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 539);
            this.panel1.TabIndex = 18;
            // 
            // dgvCourses
            // 
            this.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Location = new System.Drawing.Point(3, 3);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.RowHeadersWidth = 51;
            this.dgvCourses.RowTemplate.Height = 29;
            this.dgvCourses.Size = new System.Drawing.Size(1089, 533);
            this.dgvCourses.TabIndex = 0;
            // 
            // frmAdminCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1119, 774);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminCourses";
            this.Load += new System.EventHandler(this.frmAdminCourses_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnAllCourses;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnStarting;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button btnEnding;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.ComboBox cbbSubject;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.Label lbFrom;
    }
}