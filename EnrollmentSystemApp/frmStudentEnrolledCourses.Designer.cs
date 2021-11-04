
namespace EnrollmentSystemApp
{
    partial class frmStudentEnrolledCourses
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
            this.label10 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLecturer = new System.Windows.Forms.TextBox();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtCourseId = new System.Windows.Forms.TextBox();
            this.btnGiveFeedback = new FontAwesome.Sharp.IconButton();
            this.btnViewGradeList = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.cboSubject = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCourseList = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cboStatus);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtLecturer);
            this.panel2.Controls.Add(this.txtFeedback);
            this.panel2.Controls.Add(this.txtCourseName);
            this.panel2.Controls.Add(this.txtSubject);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtStatus);
            this.panel2.Controls.Add(this.txtCourseId);
            this.panel2.Controls.Add(this.btnGiveFeedback);
            this.panel2.Controls.Add(this.btnViewGradeList);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbTitle);
            this.panel2.Controls.Add(this.btnFilter);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.dtpFrom);
            this.panel2.Controls.Add(this.dtpTo);
            this.panel2.Controls.Add(this.cboSubject);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1095, 205);
            this.panel2.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(448, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 20);
            this.label10.TabIndex = 44;
            this.label10.Text = "Your Feedback";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(140, 164);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(112, 28);
            this.cboStatus.TabIndex = 43;
            this.cboStatus.SelectionChangeCommitted += new System.EventHandler(this.cboStatus_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 42;
            this.label9.Text = "Filter By Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Filter By Subject";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Search By Name";
            // 
            // txtLecturer
            // 
            this.txtLecturer.Enabled = false;
            this.txtLecturer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLecturer.Location = new System.Drawing.Point(852, 20);
            this.txtLecturer.Name = "txtLecturer";
            this.txtLecturer.Size = new System.Drawing.Size(238, 27);
            this.txtLecturer.TabIndex = 39;
            // 
            // txtFeedback
            // 
            this.txtFeedback.Location = new System.Drawing.Point(562, 88);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.PlaceholderText = " Write feedback here ...";
            this.txtFeedback.Size = new System.Drawing.Size(377, 112);
            this.txtFeedback.TabIndex = 38;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Enabled = false;
            this.txtCourseName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCourseName.Location = new System.Drawing.Point(562, 19);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(203, 27);
            this.txtCourseName.TabIndex = 37;
            // 
            // txtSubject
            // 
            this.txtSubject.Enabled = false;
            this.txtSubject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSubject.Location = new System.Drawing.Point(852, 53);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(238, 27);
            this.txtSubject.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(784, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Subject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(784, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Lecturer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Course Name";
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtStatus.Location = new System.Drawing.Point(562, 49);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(203, 27);
            this.txtStatus.TabIndex = 30;
            // 
            // txtCourseId
            // 
            this.txtCourseId.Location = new System.Drawing.Point(321, 9);
            this.txtCourseId.Name = "txtCourseId";
            this.txtCourseId.Size = new System.Drawing.Size(47, 27);
            this.txtCourseId.TabIndex = 29;
            // 
            // btnGiveFeedback
            // 
            this.btnGiveFeedback.BackColor = System.Drawing.Color.LightGray;
            this.btnGiveFeedback.FlatAppearance.BorderSize = 2;
            this.btnGiveFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiveFeedback.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGiveFeedback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnGiveFeedback.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGiveFeedback.IconColor = System.Drawing.Color.Black;
            this.btnGiveFeedback.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGiveFeedback.Location = new System.Drawing.Point(975, 101);
            this.btnGiveFeedback.Name = "btnGiveFeedback";
            this.btnGiveFeedback.Size = new System.Drawing.Size(91, 73);
            this.btnGiveFeedback.TabIndex = 28;
            this.btnGiveFeedback.Text = "Send";
            this.btnGiveFeedback.UseVisualStyleBackColor = false;
            this.btnGiveFeedback.Click += new System.EventHandler(this.btnGiveFeedback_Click);
            // 
            // btnViewGradeList
            // 
            this.btnViewGradeList.BackColor = System.Drawing.Color.LightGray;
            this.btnViewGradeList.FlatAppearance.BorderSize = 2;
            this.btnViewGradeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewGradeList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewGradeList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnViewGradeList.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnViewGradeList.IconColor = System.Drawing.Color.Black;
            this.btnViewGradeList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnViewGradeList.Location = new System.Drawing.Point(258, 158);
            this.btnViewGradeList.Name = "btnViewGradeList";
            this.btnViewGradeList.Size = new System.Drawing.Size(159, 42);
            this.btnViewGradeList.TabIndex = 27;
            this.btnViewGradeList.Text = "View Grade List";
            this.btnViewGradeList.UseVisualStyleBackColor = false;
            this.btnViewGradeList.Click += new System.EventHandler(this.btnViewGradeList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "From";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.Color.Black;
            this.lbTitle.Location = new System.Drawing.Point(3, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(301, 42);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "Enrolled Course";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.LightGray;
            this.btnFilter.FlatAppearance.BorderSize = 2;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnFilter.Location = new System.Drawing.Point(323, 56);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(94, 29);
            this.btnFilter.TabIndex = 15;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.LightGray;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(140, 91);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = " Search course";
            this.txtSearch.Size = new System.Drawing.Size(275, 27);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "MM/dd/yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(65, 56);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(108, 27);
            this.dtpFrom.TabIndex = 8;
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "MM/dd/yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(209, 56);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(108, 27);
            this.dtpTo.TabIndex = 9;
            // 
            // cboSubject
            // 
            this.cboSubject.FormattingEnabled = true;
            this.cboSubject.Items.AddRange(new object[] {
            "Semester 1",
            "Semester 1",
            "Semester 1",
            "Semester 1",
            "Semester 1",
            "Semester 1",
            "Semester 1",
            "Semester 1",
            "Semester 1"});
            this.cboSubject.Location = new System.Drawing.Point(140, 124);
            this.cboSubject.Name = "cboSubject";
            this.cboSubject.Size = new System.Drawing.Size(277, 28);
            this.cboSubject.TabIndex = 11;
            this.cboSubject.SelectionChangeCommitted += new System.EventHandler(this.cboSubject_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvCourseList);
            this.panel1.Location = new System.Drawing.Point(12, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 539);
            this.panel1.TabIndex = 19;
            // 
            // dgvCourseList
            // 
            this.dgvCourseList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseList.Location = new System.Drawing.Point(3, 3);
            this.dgvCourseList.Name = "dgvCourseList";
            this.dgvCourseList.RowHeadersWidth = 51;
            this.dgvCourseList.RowTemplate.Height = 29;
            this.dgvCourseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourseList.Size = new System.Drawing.Size(1087, 533);
            this.dgvCourseList.TabIndex = 0;
            // 
            // frmStudentEnrolledCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1119, 774);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStudentEnrolledCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStudentGrades";
            this.Load += new System.EventHandler(this.frmStudentEnrolledCourses_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.ComboBox cboSubject;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCourseList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnViewGradeList;
        private FontAwesome.Sharp.IconButton btnGiveFeedback;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtCourseId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLecturer;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}