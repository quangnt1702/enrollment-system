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
    public partial class frmLecturer : Form
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

        public frmLecturer()
        {
            InitializeComponent();
        }

        private void frmLecturer_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnCourses.Height;
            pnlNav.Top = btnCourses.Top;
            pnlNav.Left = btnCourses.Left;


            this.pnlFormLoader.Controls.Clear();
            frmLecturerCourses frmLecturerCourses = new frmLecturerCourses() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmLecturerCourses.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmLecturerCourses);
            frmLecturerCourses.Show();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCourses.Height;
            pnlNav.Top = btnCourses.Top;
            pnlNav.Left = btnCourses.Left;


            this.pnlFormLoader.Controls.Clear();
            frmLecturerCourses frmLecturerCourses = new frmLecturerCourses() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmLecturerCourses.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmLecturerCourses);
            frmLecturerCourses.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnProfile.Height;
            pnlNav.Top = btnProfile.Top;
            pnlNav.Left = btnProfile.Left;


            this.pnlFormLoader.Controls.Clear();
            frmLecturerProfile frmLecturerProfile = new frmLecturerProfile() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmLecturerProfile.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmLecturerProfile);
            frmLecturerProfile.Show();
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnGrades.Height;
            pnlNav.Top = btnGrades.Top;
            pnlNav.Left = btnGrades.Left;


            this.pnlFormLoader.Controls.Clear();
            frmLecturerGrades frmLecturerGrades = new frmLecturerGrades() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmLecturerGrades.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmLecturerGrades);
            frmLecturerGrades.Show();
        }
    }
}
