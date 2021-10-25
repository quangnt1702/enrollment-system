using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace EnrollmentSystemApp
{
    public partial class frmStudent : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnCourses.Height;
            pnlNav.Top = btnCourses.Top;
            pnlNav.Left = btnCourses.Left;


            this.pnlFormLoader.Controls.Clear();
            frmStudentCourses frmStudentCourses = new frmStudentCourses() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmStudentCourses.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmStudentCourses);
            frmStudentCourses.Show();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCourses.Height;
            pnlNav.Top = btnCourses.Top;
            pnlNav.Left = btnCourses.Left;


            this.pnlFormLoader.Controls.Clear();
            frmStudentCourses frmStudentCourses = new frmStudentCourses() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmStudentCourses.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmStudentCourses);
            frmStudentCourses.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnProfile.Height;
            pnlNav.Top = btnProfile.Top;
            pnlNav.Left = btnProfile.Left;

            this.pnlFormLoader.Controls.Clear();
            frmStudentProfile frmStudentProfile = new frmStudentProfile() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmStudentProfile.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmStudentProfile);
            frmStudentProfile.Show();
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnGrades.Height;
            pnlNav.Top = btnGrades.Top;
            pnlNav.Left = btnGrades.Left;

            this.pnlFormLoader.Controls.Clear();
            frmStudentGrades frmStudentGrades = new frmStudentGrades() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmStudentGrades.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmStudentGrades);
            frmStudentGrades.Show();
        }

        private void btnSendFeedback_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSendFeedback.Height;
            pnlNav.Top = btnSendFeedback.Top;
            pnlNav.Left = btnSendFeedback.Left;

            this.pnlFormLoader.Controls.Clear();
            frmStudentFeedback frmStudentFeedback = new frmStudentFeedback() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmStudentFeedback.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmStudentFeedback);
            frmStudentFeedback.Show();
        }
    }
}
