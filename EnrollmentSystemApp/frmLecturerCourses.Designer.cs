
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
            this.lbTo = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReady = new System.Windows.Forms.Button();
            this.btnAllCourses = new System.Windows.Forms.Button();
            this.btnStarting = new System.Windows.Forms.Button();
            this.btnEnded = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnYourReady = new System.Windows.Forms.Button();
            this.btnYourWaiting = new System.Windows.Forms.Button();
            this.btnYourEnd = new System.Windows.Forms.Button();
            this.btnYourCourse = new System.Windows.Forms.Button();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.btnShowGrades = new System.Windows.Forms.Button();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.btnViewListStudent = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.cbbSubject = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbTo);
            this.panel2.Controls.Add(this.lbFrom);
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
            this.panel2.Location = new System.Drawing.Point(11, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1095, 205);
            this.panel2.TabIndex = 18;
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Location = new System.Drawing.Point(182, 60);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(25, 20);
            this.lbTo.TabIndex = 33;
            this.lbTo.Text = "To";
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Location = new System.Drawing.Point(9, 58);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(43, 20);
            this.lbFrom.TabIndex = 32;
            this.lbFrom.Text = "From";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReady);
            this.groupBox2.Controls.Add(this.btnAllCourses);
            this.groupBox2.Controls.Add(this.btnStarting);
            this.groupBox2.Controls.Add(this.btnEnded);
            this.groupBox2.Location = new System.Drawing.Point(791, 135);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(303, 68);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "All Courses";
            // 
            // btnReady
            // 
            this.btnReady.BackColor = System.Drawing.Color.LightGray;
            this.btnReady.FlatAppearance.BorderSize = 2;
            this.btnReady.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReady.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReady.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnReady.Location = new System.Drawing.Point(129, 31);
            this.btnReady.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(77, 32);
            this.btnReady.TabIndex = 24;
            this.btnReady.Text = "Started";
            this.btnReady.UseVisualStyleBackColor = false;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // btnAllCourses
            // 
            this.btnAllCourses.BackColor = System.Drawing.Color.LightGray;
            this.btnAllCourses.FlatAppearance.BorderSize = 2;
            this.btnAllCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllCourses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAllCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnAllCourses.Location = new System.Drawing.Point(6, 32);
            this.btnAllCourses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAllCourses.Name = "btnAllCourses";
            this.btnAllCourses.Size = new System.Drawing.Size(43, 29);
            this.btnAllCourses.TabIndex = 10;
            this.btnAllCourses.Text = "All";
            this.btnAllCourses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllCourses.UseVisualStyleBackColor = false;
            this.btnAllCourses.Click += new System.EventHandler(this.btnAllCourses_Click);
            // 
            // btnStarting
            // 
            this.btnStarting.BackColor = System.Drawing.Color.LightGray;
            this.btnStarting.FlatAppearance.BorderSize = 2;
            this.btnStarting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStarting.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStarting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnStarting.Location = new System.Drawing.Point(212, 30);
            this.btnStarting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStarting.Name = "btnStarting";
            this.btnStarting.Size = new System.Drawing.Size(89, 32);
            this.btnStarting.TabIndex = 13;
            this.btnStarting.Text = "Waiting";
            this.btnStarting.UseVisualStyleBackColor = false;
            this.btnStarting.Click += new System.EventHandler(this.btnStarting_Click_1);
            // 
            // btnEnded
            // 
            this.btnEnded.BackColor = System.Drawing.Color.LightGray;
            this.btnEnded.FlatAppearance.BorderSize = 2;
            this.btnEnded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnded.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnEnded.Location = new System.Drawing.Point(58, 32);
            this.btnEnded.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEnded.Name = "btnEnded";
            this.btnEnded.Size = new System.Drawing.Size(65, 29);
            this.btnEnded.TabIndex = 12;
            this.btnEnded.Text = "Ended";
            this.btnEnded.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnded.UseVisualStyleBackColor = false;
            this.btnEnded.Click += new System.EventHandler(this.btnEnded_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnYourReady);
            this.groupBox1.Controls.Add(this.btnYourWaiting);
            this.groupBox1.Controls.Add(this.btnYourEnd);
            this.groupBox1.Controls.Add(this.btnYourCourse);
            this.groupBox1.Location = new System.Drawing.Point(11, 132);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(307, 72);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Course";
            // 
            // btnYourReady
            // 
            this.btnYourReady.BackColor = System.Drawing.Color.LightGray;
            this.btnYourReady.FlatAppearance.BorderSize = 2;
            this.btnYourReady.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYourReady.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYourReady.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnYourReady.Location = new System.Drawing.Point(91, 31);
            this.btnYourReady.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnYourReady.Name = "btnYourReady";
            this.btnYourReady.Size = new System.Drawing.Size(74, 34);
            this.btnYourReady.TabIndex = 31;
            this.btnYourReady.Text = "Started";
            this.btnYourReady.UseVisualStyleBackColor = false;
            this.btnYourReady.Click += new System.EventHandler(this.btnYourReady_Click);
            // 
            // btnYourWaiting
            // 
            this.btnYourWaiting.BackColor = System.Drawing.Color.LightGray;
            this.btnYourWaiting.FlatAppearance.BorderSize = 2;
            this.btnYourWaiting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYourWaiting.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYourWaiting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnYourWaiting.Location = new System.Drawing.Point(7, 31);
            this.btnYourWaiting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnYourWaiting.Name = "btnYourWaiting";
            this.btnYourWaiting.Size = new System.Drawing.Size(78, 34);
            this.btnYourWaiting.TabIndex = 27;
            this.btnYourWaiting.Text = "Waiting";
            this.btnYourWaiting.UseVisualStyleBackColor = false;
            this.btnYourWaiting.Click += new System.EventHandler(this.btnYourWaiting_Click);
            // 
            // btnYourEnd
            // 
            this.btnYourEnd.BackColor = System.Drawing.Color.LightGray;
            this.btnYourEnd.FlatAppearance.BorderSize = 2;
            this.btnYourEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYourEnd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYourEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnYourEnd.Location = new System.Drawing.Point(171, 31);
            this.btnYourEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnYourEnd.Name = "btnYourEnd";
            this.btnYourEnd.Size = new System.Drawing.Size(65, 34);
            this.btnYourEnd.TabIndex = 26;
            this.btnYourEnd.Text = "Ended";
            this.btnYourEnd.UseVisualStyleBackColor = false;
            this.btnYourEnd.Click += new System.EventHandler(this.btnYourEnd_Click);
            // 
            // btnYourCourse
            // 
            this.btnYourCourse.BackColor = System.Drawing.Color.LightGray;
            this.btnYourCourse.FlatAppearance.BorderSize = 2;
            this.btnYourCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYourCourse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYourCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnYourCourse.Location = new System.Drawing.Point(242, 31);
            this.btnYourCourse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnYourCourse.Name = "btnYourCourse";
            this.btnYourCourse.Size = new System.Drawing.Size(59, 34);
            this.btnYourCourse.TabIndex = 25;
            this.btnYourCourse.Text = "All";
            this.btnYourCourse.UseVisualStyleBackColor = false;
            this.btnYourCourse.Click += new System.EventHandler(this.btnYourCourse_Click);
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.BackColor = System.Drawing.Color.LightGray;
            this.txtSearchStudent.Location = new System.Drawing.Point(797, 69);
            this.txtSearchStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.PlaceholderText = "Search Student";
            this.txtSearchStudent.Size = new System.Drawing.Size(249, 27);
            this.txtSearchStudent.TabIndex = 29;
            this.txtSearchStudent.TextChanged += new System.EventHandler(this.txtSearchStudent_TextChanged);
            // 
            // btnShowGrades
            // 
            this.btnShowGrades.BackColor = System.Drawing.Color.LightGray;
            this.btnShowGrades.FlatAppearance.BorderSize = 2;
            this.btnShowGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowGrades.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowGrades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnShowGrades.Location = new System.Drawing.Point(571, 155);
            this.btnShowGrades.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowGrades.Name = "btnShowGrades";
            this.btnShowGrades.Size = new System.Drawing.Size(130, 40);
            this.btnShowGrades.TabIndex = 28;
            this.btnShowGrades.Text = "Show Grades";
            this.btnShowGrades.UseVisualStyleBackColor = false;
            this.btnShowGrades.Click += new System.EventHandler(this.btnShowGrades_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(952, 100);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(94, 27);
            this.txtStudentID.TabIndex = 27;
            // 
            // btnViewListStudent
            // 
            this.btnViewListStudent.BackColor = System.Drawing.Color.LightGray;
            this.btnViewListStudent.FlatAppearance.BorderSize = 2;
            this.btnViewListStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewListStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewListStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnViewListStudent.Location = new System.Drawing.Point(390, 155);
            this.btnViewListStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnViewListStudent.Name = "btnViewListStudent";
            this.btnViewListStudent.Size = new System.Drawing.Size(137, 39);
            this.btnViewListStudent.TabIndex = 26;
            this.btnViewListStudent.Text = "View List Student";
            this.btnViewListStudent.UseVisualStyleBackColor = false;
            this.btnViewListStudent.Click += new System.EventHandler(this.btnViewListStudent_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.Color.Black;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
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
            this.btnFilter.Location = new System.Drawing.Point(328, 56);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(92, 29);
            this.btnFilter.TabIndex = 15;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(797, 100);
            this.txtCourseID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(94, 27);
            this.txtCourseID.TabIndex = 14;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.LightGray;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(797, 22);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search course";
            this.txtSearch.Size = new System.Drawing.Size(249, 27);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(67, 55);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(109, 27);
            this.dtpFrom.TabIndex = 8;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(213, 55);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(109, 27);
            this.dtpTo.TabIndex = 9;
            // 
            // cbbSubject
            // 
            this.cbbSubject.FormattingEnabled = true;
            this.cbbSubject.Location = new System.Drawing.Point(67, 90);
            this.cbbSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbSubject.Name = "cbbSubject";
            this.cbbSubject.Size = new System.Drawing.Size(255, 28);
            this.cbbSubject.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvCourses);
            this.panel1.Location = new System.Drawing.Point(15, 224);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 539);
            this.panel1.TabIndex = 19;
            // 
            // dgvCourses
            // 
            this.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Location = new System.Drawing.Point(3, 6);
            this.dgvCourses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.RowHeadersWidth = 51;
            this.dgvCourses.RowTemplate.Height = 29;
            this.dgvCourses.Size = new System.Drawing.Size(1089, 533);
            this.dgvCourses.TabIndex = 0;
            // 
            // frmLecturerCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1119, 774);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLecturerCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLecturerCourses";
            this.Load += new System.EventHandler(this.frmLecturerCourses_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.Label lbFrom;
    }
}