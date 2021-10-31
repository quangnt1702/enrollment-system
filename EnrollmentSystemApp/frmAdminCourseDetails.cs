using DataAccess.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentSystemApp
{
    public partial class frmAdminCourseDetails : Form
    {
        public ICourseRepository CourseRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Course courseInfo { get; set; }
        public frmAdminCourseDetails()
        {
            InitializeComponent();
        }

        private void frmAdminCourseDetails_Load(object sender, EventArgs e)
        {
            var context = new EnrollmentSystemContext();
            var subject = context.Subjects.ToList();
            cbSubjectID.DisplayMember = "SubjectName";
            cbSubjectID.ValueMember = "SubjectId";
            cbSubjectID.DataSource = subject;
            var lecturer = context.Users.Where(c => c.RoleId == 2).ToList();
            cbLecturerID.DisplayMember = "UserName";
            cbLecturerID.ValueMember = "UserId";
            cbLecturerID.DataSource = lecturer;
            var status = context.StatusCourses.ToList();
            cbStatusID.DisplayMember = "StatusName";
            cbStatusID.ValueMember = "StatusID";
            cbStatusID.DataSource = status;
            txtCourseID.Enabled = false;
            if (InsertOrUpdate == true)
            {
                txtCourseID.Text = courseInfo.CourseId.ToString();
                txtCourseName.Text = courseInfo.CourseName;
                cbSubjectID.SelectedValue = courseInfo.SubjectId;
                cbLecturerID.SelectedValue = courseInfo.LecturerId;
                txtStudentQuantity.Text = courseInfo.StudentQuantity.ToString();
                dtpStartDate.Value = courseInfo.StartDate.Date;
                dtpEndDate.Value = courseInfo.EndDate.Date;
                cbStatusID.SelectedValue = courseInfo.StatusId;
            }
        }

        public bool CheckData()
        {
            var dateStart = dtpStartDate.Value;
            var dateEnd = dtpEndDate.Value;
            if (string.IsNullOrWhiteSpace(txtCourseName.Text))
            {
                MessageBox.Show("Course name is blank", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCourseName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtStudentQuantity.Text))
            {
                MessageBox.Show("Student quantity is blank", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentQuantity.Focus();
                return false;
            }
            if(dateEnd < dateStart)
            {
                MessageBox.Show("Start date can not bigger than end date.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpStartDate.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckData())
                {
                    if (InsertOrUpdate == false)
                    {
                        var course = new Course
                        {
                            CourseName = txtCourseName.Text,
                            SubjectId = (int)cbSubjectID.SelectedValue,
                            LecturerId = (string)cbLecturerID.SelectedValue,
                            StudentQuantity = int.Parse(txtStudentQuantity.Text),
                            StartDate = dtpStartDate.Value,
                            EndDate = dtpEndDate.Value,
                            StatusId = (int)cbStatusID.SelectedValue,
                        };
                        CourseRepository.InsertCourse(course);
                    }
                    else
                    {
                        var course = new Course
                        {
                            CourseId = int.Parse(txtCourseID.Text),
                            CourseName = txtCourseName.Text,
                            SubjectId = (int)cbSubjectID.SelectedValue,
                            LecturerId = (string)cbLecturerID.SelectedValue,
                            StudentQuantity = int.Parse(txtStudentQuantity.Text),
                            StartDate = dtpStartDate.Value,
                            EndDate = dtpEndDate.Value,
                            StatusId = (int)cbStatusID.SelectedValue,
                        };
                        CourseRepository.UpdateCourse(course);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new course" : "Update course");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
