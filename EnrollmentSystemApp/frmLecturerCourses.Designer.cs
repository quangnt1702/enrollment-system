
namespace EnrollmentSystemApp
{
    partial class frmLecturerCourses
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
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.btnShowGrades = new System.Windows.Forms.Button();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.btnViewListStudent = new System.Windows.Forms.Button();
            this.btnYourCourse = new System.Windows.Forms.Button();
            this.btnReady = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnAllCourses = new System.Windows.Forms.Button();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnStarting = new System.Windows.Forms.Button();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btnEnded = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.cbbSubject = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnYourEnd = new System.Windows.Forms.Button();
            this.btnYourWaiting = new System.Windows.Forms.Button();
            this.btnYourReady = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.txtSearchStudent);
            this.panel2.Controls.Add(this.btnShowGrades);
            this.panel2.Controls.Add(this.txtStudentID);
            this.panel2.Controls.Add(this.btnViewListStudent);
            this.panel2.Controls.Add(this.lbTitle);
            this.panel2.Controls.Add(this.btnFilter);
            this.panel2.Controls.Add(this.txtCourseID);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.dtpFrom);
            this.panel2.Controls.Add(this.dtpTo);
            this.panel2.Controls.Add(this.cbbSubject);
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(958, 174);
            this.panel2.TabIndex = 18;
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.BackColor = System.Drawing.Color.LightGray;
            this.txtSearchStudent.Location = new System.Drawing.Point(582, 61);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.PlaceholderText = "Search Student";
            this.txtSearchStudent.Size = new System.Drawing.Size(218, 25);
            this.txtSearchStudent.TabIndex = 29;
            this.txtSearchStudent.TextChanged += new System.EventHandler(this.txtSearchStudent_TextChanged);
            // 
            // btnShowGrades
            // 
            this.btnShowGrades.Location = new System.Drawing.Point(500, 132);
            this.btnShowGrades.Name = "btnShowGrades";
            this.btnShowGrades.Size = new System.Drawing.Size(114, 34);
            this.btnShowGrades.TabIndex = 28;
            this.btnShowGrades.Text = "Show Grades";
            this.btnShowGrades.UseVisualStyleBackColor = true;
            this.btnShowGrades.Click += new System.EventHandler(this.btnShowGrades_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(851, 20);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(83, 25);
            this.txtStudentID.TabIndex = 27;
            // 
            // btnViewListStudent
            // 
            this.btnViewListStudent.Location = new System.Drawing.Point(341, 132);
            this.btnViewListStudent.Name = "btnViewListStudent";
            this.btnViewListStudent.Size = new System.Drawing.Size(120, 33);
            this.btnViewListStudent.TabIndex = 26;
            this.btnViewListStudent.Text = "View List Student";
            this.btnViewListStudent.UseVisualStyleBackColor = true;
            this.btnViewListStudent.Click += new System.EventHandler(this.btnViewListStudent_Click);
            // 
            // btnYourCourse
            // 
            this.btnYourCourse.Location = new System.Drawing.Point(192, 27);
            this.btnYourCourse.Name = "btnYourCourse";
            this.btnYourCourse.Size = new System.Drawing.Size(52, 29);
            this.btnYourCourse.TabIndex = 25;
            this.btnYourCourse.Text = "All";
            this.btnYourCourse.UseVisualStyleBackColor = true;
            this.btnYourCourse.Click += new System.EventHandler(this.btnYourCourse_Click);
            // 
            // btnReady
            // 
            this.btnReady.Location = new System.Drawing.Point(127, 26);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(58, 27);
            this.btnReady.TabIndex = 24;
            this.btnReady.Text = "Ready";
            this.btnReady.UseVisualStyleBackColor = true;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.Color.Black;
            this.lbTitle.Location = new System.Drawing.Point(16, 21);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(133, 36);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "Courses";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(411, 32);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(82, 25);
            this.btnFilter.TabIndex = 15;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnAllCourses
            // 
            this.btnAllCourses.Location = new System.Drawing.Point(25, 28);
            this.btnAllCourses.Name = "btnAllCourses";
            this.btnAllCourses.Size = new System.Drawing.Size(33, 25);
            this.btnAllCourses.TabIndex = 10;
            this.btnAllCourses.Text = "All";
            this.btnAllCourses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllCourses.UseVisualStyleBackColor = true;
            this.btnAllCourses.Click += new System.EventHandler(this.btnAllCourses_Click);
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(851, 61);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(83, 25);
            this.txtCourseID.TabIndex = 14;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.LightGray;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(582, 21);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search course";
            this.txtSearch.Size = new System.Drawing.Size(218, 23);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnStarting
            // 
            this.btnStarting.Location = new System.Drawing.Point(191, 26);
            this.btnStarting.Name = "btnStarting";
            this.btnStarting.Size = new System.Drawing.Size(63, 27);
            this.btnStarting.TabIndex = 13;
            this.btnStarting.Text = "Waiting";
            this.btnStarting.UseVisualStyleBackColor = true;
            this.btnStarting.Click += new System.EventHandler(this.btnStarting_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(171, 17);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(96, 25);
            this.dtpFrom.TabIndex = 8;
            // 
            // btnEnded
            // 
            this.btnEnded.Location = new System.Drawing.Point(64, 27);
            this.btnEnded.Name = "btnEnded";
            this.btnEnded.Size = new System.Drawing.Size(57, 25);
            this.btnEnded.TabIndex = 12;
            this.btnEnded.Text = "Ended";
            this.btnEnded.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnded.UseVisualStyleBackColor = true;
            this.btnEnded.Click += new System.EventHandler(this.btnEnded_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(286, 17);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(96, 25);
            this.dtpTo.TabIndex = 9;
            // 
            // cbbSubject
            // 
            this.cbbSubject.FormattingEnabled = true;
            this.cbbSubject.Location = new System.Drawing.Point(171, 56);
            this.cbbSubject.Name = "cbbSubject";
            this.cbbSubject.Size = new System.Drawing.Size(211, 25);
            this.cbbSubject.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvCourses);
            this.panel1.Location = new System.Drawing.Point(13, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 458);
            this.panel1.TabIndex = 19;
            // 
            // dgvCourses
            // 
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Location = new System.Drawing.Point(3, 5);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.RowHeadersWidth = 51;
            this.dgvCourses.RowTemplate.Height = 29;
            this.dgvCourses.Size = new System.Drawing.Size(953, 453);
            this.dgvCourses.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnYourReady);
            this.groupBox1.Controls.Add(this.btnYourWaiting);
            this.groupBox1.Controls.Add(this.btnYourEnd);
            this.groupBox1.Controls.Add(this.btnYourCourse);
            this.groupBox1.Location = new System.Drawing.Point(10, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 61);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Course";
            // 
            // btnYourEnd
            // 
            this.btnYourEnd.Location = new System.Drawing.Point(129, 27);
            this.btnYourEnd.Name = "btnYourEnd";
            this.btnYourEnd.Size = new System.Drawing.Size(57, 29);
            this.btnYourEnd.TabIndex = 26;
            this.btnYourEnd.Text = "Ended";
            this.btnYourEnd.UseVisualStyleBackColor = true;
            this.btnYourEnd.Click += new System.EventHandler(this.btnYourEnd_Click);
            // 
            // btnYourWaiting
            // 
            this.btnYourWaiting.Location = new System.Drawing.Point(6, 26);
            this.btnYourWaiting.Name = "btnYourWaiting";
            this.btnYourWaiting.Size = new System.Drawing.Size(59, 29);
            this.btnYourWaiting.TabIndex = 27;
            this.btnYourWaiting.Text = "Waiting";
            this.btnYourWaiting.UseVisualStyleBackColor = true;
            this.btnYourWaiting.Click += new System.EventHandler(this.btnYourWaiting_Click);
            // 
            // btnYourReady
            // 
            this.btnYourReady.Location = new System.Drawing.Point(71, 26);
            this.btnYourReady.Name = "btnYourReady";
            this.btnYourReady.Size = new System.Drawing.Size(52, 29);
            this.btnYourReady.TabIndex = 31;
            this.btnYourReady.Text = "Ready";
            this.btnYourReady.UseVisualStyleBackColor = true;
            this.btnYourReady.Click += new System.EventHandler(this.btnYourReady_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReady);
            this.groupBox2.Controls.Add(this.btnAllCourses);
            this.groupBox2.Controls.Add(this.btnStarting);
            this.groupBox2.Controls.Add(this.btnEnded);
            this.groupBox2.Location = new System.Drawing.Point(692, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 58);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "All Courses";
            // 
            // frmLecturerCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(979, 658);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLecturerCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLecturerCourses";
            this.Load += new System.EventHandler(this.frmLecturerCourses_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnEnded;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.ComboBox cbbSubject;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Button btnYourCourse;
        private System.Windows.Forms.Button btnViewListStudent;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Button btnShowGrades;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnYourReady;
        private System.Windows.Forms.Button btnYourWaiting;
        private System.Windows.Forms.Button btnYourEnd;
    }
}