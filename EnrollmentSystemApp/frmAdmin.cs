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
    public partial class frmAdmin : Form
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

        public frmAdmin()
        {
            InitializeComponent();

        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnCourses.Height;
            pnlNav.Top = btnCourses.Top;
            pnlNav.Left = btnCourses.Left;


            this.pnlFormLoader.Controls.Clear();
            frmAdminCourses frmAdminCourses = new frmAdminCourses() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAdminCourses.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmAdminCourses);
            frmAdminCourses.Show();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCourses.Height;
            pnlNav.Top = btnCourses.Top;
            pnlNav.Left = btnCourses.Left;


            this.pnlFormLoader.Controls.Clear();
            frmAdminCourses frmAdminCourses = new frmAdminCourses() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAdminCourses.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmAdminCourses);
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
    }
}
