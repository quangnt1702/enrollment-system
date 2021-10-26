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

        private void btnFeedbacks_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnFeedbacks.Height;
            pnlNav.Top = btnFeedbacks.Top;
            pnlNav.Left = btnFeedbacks.Left;

            this.pnlFormLoader.Controls.Clear();
            frmStudentFeedback frmStudentFeedback = new frmStudentFeedback() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmStudentFeedback.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmStudentFeedback);
            frmStudentFeedback.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
