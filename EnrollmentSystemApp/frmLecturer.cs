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
using DataAccess.Models;

namespace EnrollmentSystemApp
{
    public partial class frmLecturer : Form
    {
        public User LoginUser { get; set; }
        public frmLecturer()
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

        private void frmLecturer1_Load(object sender, EventArgs e)
        {
            pnlNav.Height = btnCourses.Height;
            pnlNav.Top = btnCourses.Top;
            pnlNav.Left = btnCourses.Left;


            this.pnlFormLoader.Controls.Clear();
            frmLecturerCourses frmLecturerCourses = new frmLecturerCourses() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmLecturerCourses.LoginUser = LoginUser;
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
            frmLecturerCourses.LoginUser = LoginUser;
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
            frmLecturerProfile.LoginUser = LoginUser;            
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
