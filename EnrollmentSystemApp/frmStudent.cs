using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DataAccess.Models;

namespace EnrollmentSystemApp
{
    public partial class frmStudent : Form
    {
        public User LoginUser { get; set; }
        public frmStudent()
        {
            InitializeComponent();
        }

        //Drag Form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0X112, 0xf012, 0);
        }

        private void frmStudent1_Load(object sender, EventArgs e)
        {
            pnlNav.Height = btnCourses.Height;
            pnlNav.Top = btnCourses.Top;
            pnlNav.Left = btnCourses.Left;


            this.pnlFormLoader.Controls.Clear();
            frmStudentCourses frmStudentCourses = new frmStudentCourses() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmStudentCourses.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmStudentCourses);
            frmStudentCourses.LoginUser = LoginUser;
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
            frmStudentCourses.LoginUser = LoginUser;
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
            frmStudentProfile.LoginUser = LoginUser;
            frmStudentProfile.Show();
        }

        private void btnEnrolledCourses_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnEnrolledCourse.Height;
            pnlNav.Top = btnEnrolledCourse.Top;
            pnlNav.Left = btnEnrolledCourse.Left;

            this.pnlFormLoader.Controls.Clear();
            frmStudentEnrolledCourses frmStudentEnrolledCourses = new frmStudentEnrolledCourses() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmStudentEnrolledCourses.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmStudentEnrolledCourses);
            frmStudentEnrolledCourses.LoginUser = LoginUser;
            frmStudentEnrolledCourses.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
