
namespace EnrollmentSystemApp
{
    partial class frmStudentCourses
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
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtCourseId = new System.Windows.Forms.TextBox();
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
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.txtStatus);
            this.panel2.Controls.Add(this.btnEnroll);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbTitle);
            this.panel2.Controls.Add(this.btnFilter);
            this.panel2.Controls.Add(this.txtCourseId);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.dtpFrom);
            this.panel2.Controls.Add(this.dtpTo);
            this.panel2.Controls.Add(this.cboSubject);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1090, 205);
            this.panel2.TabIndex = 18;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(942, 9);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(81, 27);
            this.txtQuantity.TabIndex = 28;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(849, 9);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(87, 27);
            this.txtStatus.TabIndex = 27;
            // 
            // btnEnroll
            // 
            this.btnEnroll.Location = new System.Drawing.Point(466, 153);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(177, 49);
            this.btnEnroll.TabIndex = 26;
            this.btnEnroll.Text = "Enroll";
            this.btnEnroll.UseVisualStyleBackColor = true;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "From";
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
            this.btnFilter.Location = new System.Drawing.Point(331, 51);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(94, 27);
            this.btnFilter.TabIndex = 15;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtCourseId
            // 
            this.txtCourseId.Location = new System.Drawing.Point(746, 9);
            this.txtCourseId.Name = "txtCourseId";
            this.txtCourseId.Size = new System.Drawing.Size(97, 27);
            this.txtCourseId.TabIndex = 14;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.LightGray;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(28, 89);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "  Search course";
            this.txtSearch.Size = new System.Drawing.Size(297, 28);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "MM/dd/yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(77, 51);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(108, 27);
            this.dtpFrom.TabIndex = 8;
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "MM/dd/yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(222, 51);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(103, 27);
            this.dtpTo.TabIndex = 9;
            // 
            // cboSubject
            // 
            this.cboSubject.FormattingEnabled = true;
            this.cboSubject.Location = new System.Drawing.Point(28, 123);
            this.cboSubject.Name = "cboSubject";
            this.cboSubject.Size = new System.Drawing.Size(297, 28);
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
            // frmStudentCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1114, 774);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStudentCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStudentCourses";
            this.Load += new System.EventHandler(this.frmStudentCourses_Load);
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
        private System.Windows.Forms.TextBox txtCourseId;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.ComboBox cboSubject;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCourseList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtStatus;
    }
}