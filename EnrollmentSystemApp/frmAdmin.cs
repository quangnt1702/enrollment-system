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
    public partial class frmAdmin : Form
    {
        public User LoginUser { get; set; }
        public frmAdmin()
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

        private void frmAdmin1_Load(object sender, EventArgs e)
        {
            pnlNav.Height = btnCourses.Height;
            pnlNav.Top = btnCourses.Top;
            pnlNav.Left = btnCourses.Left;


            this.pnlFormLoader.Controls.Clear();
            frmAdminCourses frmAdminCourses = new frmAdminCourses() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAdminCourses.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmAdminCourses);
            frmAdminCourses.LoginUser = LoginUser;
            frmAdminCourses.Show();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCourses.Height;
            pnlNav.Top = btnCourses.Top;
            pnlNav.Left = btnCourses.Left;


            this.pnlFormLoader.Controls.Clear();
            frmAdminCourses frmAdminCourses = new frmAdminCourses() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAdminCourses.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmAdminCourses);
            frmAdminCourses.LoginUser = LoginUser;
            frmAdminCourses.Show();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnStudents.Height;
            pnlNav.Top = btnStudents.Top;
            pnlNav.Left = btnStudents.Left;

            this.pnlFormLoader.Controls.Clear();
            frmAdminStudents frmAdminStudents = new frmAdminStudents() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAdminStudents.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmAdminStudents);
            frmAdminStudents.LoginUser = LoginUser;
            frmAdminStudents.Show();
        }

        private void btnLecturers_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnLecturers.Height;
            pnlNav.Top = btnLecturers.Top;
            pnlNav.Left = btnLecturers.Left;

            this.pnlFormLoader.Controls.Clear();
            frmAdminLecturers frmAdminLecturers = new frmAdminLecturers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAdminLecturers.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmAdminLecturers);
            frmAdminLecturers.LoginUser = LoginUser;
            frmAdminLecturers.Show();
        }

        private void btnFeedbacks_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnFeedbacks.Height;
            pnlNav.Top = btnFeedbacks.Top;
            pnlNav.Left = btnFeedbacks.Left;

            this.pnlFormLoader.Controls.Clear();
            frmAdminFeedbacks frmAdminFeedbacks = new frmAdminFeedbacks() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAdminFeedbacks.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmAdminFeedbacks);
            frmAdminFeedbacks.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnFeedbacks.Height;
            pnlNav.Top = btnFeedbacks.Top;
            pnlNav.Left = btnFeedbacks.Left;

            this.pnlFormLoader.Controls.Clear();
            frmAdminSubject frmAdminSubject = new frmAdminSubject() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAdminSubject.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmAdminSubject);
            frmAdminSubject.Show();
        }
    }
}
