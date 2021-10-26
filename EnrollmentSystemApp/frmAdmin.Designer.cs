
namespace EnrollmentSystemApp
{
    partial class frmAdmin
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
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnFeedbacks = new FontAwesome.Sharp.IconButton();
            this.btnLecturers = new FontAwesome.Sharp.IconButton();
            this.btnStudents = new FontAwesome.Sharp.IconButton();
            this.btnCourses = new FontAwesome.Sharp.IconButton();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.pnMenu.SuspendLayout();
            this.pnLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnMenu.Controls.Add(this.pnlNav);
            this.pnMenu.Controls.Add(this.btnLogout);
            this.pnMenu.Controls.Add(this.btnFeedbacks);
            this.pnMenu.Controls.Add(this.btnLecturers);
            this.pnMenu.Controls.Add(this.btnStudents);
            this.pnMenu.Controls.Add(this.btnCourses);
            this.pnMenu.Controls.Add(this.pnLogo);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(196, 805);
            this.pnMenu.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlNav.Location = new System.Drawing.Point(3, 188);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(10, 290);
            this.pnlNav.TabIndex = 6;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogout.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 731);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(196, 74);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnFeedbacks
            // 
            this.btnFeedbacks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFeedbacks.FlatAppearance.BorderSize = 0;
            this.btnFeedbacks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedbacks.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFeedbacks.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFeedbacks.IconChar = FontAwesome.Sharp.IconChar.CommentAlt;
            this.btnFeedbacks.IconColor = System.Drawing.Color.Gainsboro;
            this.btnFeedbacks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFeedbacks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFeedbacks.Location = new System.Drawing.Point(0, 404);
            this.btnFeedbacks.Name = "btnFeedbacks";
            this.btnFeedbacks.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnFeedbacks.Size = new System.Drawing.Size(196, 74);
            this.btnFeedbacks.TabIndex = 4;
            this.btnFeedbacks.Text = "Feedbacks";
            this.btnFeedbacks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFeedbacks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFeedbacks.UseVisualStyleBackColor = true;
            this.btnFeedbacks.Click += new System.EventHandler(this.btnFeedbacks_Click);
            // 
            // btnLecturers
            // 
            this.btnLecturers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLecturers.FlatAppearance.BorderSize = 0;
            this.btnLecturers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLecturers.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLecturers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLecturers.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnLecturers.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLecturers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLecturers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLecturers.Location = new System.Drawing.Point(0, 330);
            this.btnLecturers.Name = "btnLecturers";
            this.btnLecturers.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLecturers.Size = new System.Drawing.Size(196, 74);
            this.btnLecturers.TabIndex = 3;
            this.btnLecturers.Text = "Lecturers";
            this.btnLecturers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLecturers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLecturers.UseVisualStyleBackColor = true;
            this.btnLecturers.Click += new System.EventHandler(this.btnLecturers_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStudents.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStudents.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnStudents.IconColor = System.Drawing.Color.Gainsboro;
            this.btnStudents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudents.Location = new System.Drawing.Point(0, 256);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnStudents.Size = new System.Drawing.Size(196, 74);
            this.btnStudents.TabIndex = 2;
            this.btnStudents.Text = "Students";
            this.btnStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCourses.FlatAppearance.BorderSize = 0;
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCourses.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCourses.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnCourses.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCourses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourses.Location = new System.Drawing.Point(0, 182);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCourses.Size = new System.Drawing.Size(196, 74);
            this.btnCourses.TabIndex = 1;
            this.btnCourses.Text = "Courses";
            this.btnCourses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // pnLogo
            // 
            this.pnLogo.Controls.Add(this.lbTitle);
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(196, 182);
            this.pnLogo.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTitle.Location = new System.Drawing.Point(6, 64);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(184, 23);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "FPT Enrollment System";
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFormLoader.Location = new System.Drawing.Point(196, 30);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(1119, 775);
            this.pnlFormLoader.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(196, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 30);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.iconButton1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(1067, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(23, 21);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(1038, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(23, 21);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 20;
            this.btnExit.Location = new System.Drawing.Point(1096, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 21);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 805);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlFormLoader);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin1";
            this.Load += new System.EventHandler(this.frmAdmin1_Load);
            this.pnMenu.ResumeLayout(false);
            this.pnLogo.ResumeLayout(false);
            this.pnLogo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnFeedbacks;
        private FontAwesome.Sharp.IconButton btnLecturers;
        private FontAwesome.Sharp.IconButton btnStudents;
        private FontAwesome.Sharp.IconButton btnCourses;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel pnlFormLoader;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}