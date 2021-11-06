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
        public bool InsertOrUpdate { get; set; } // true: update, false : add
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
            var status = context.StatusCourses.Where(c => c.StatusId == 3).ToList();
            var statusUpdate = context.StatusCourses.ToList();
            cbStatusID.DisplayMember = "StatusName";
            cbStatusID.ValueMember = "StatusID";
            if(InsertOrUpdate == false)
            {
                cbStatusID.DataSource = null;
                cbStatusID.DataSource = status;
            }
            else
            {
                lbTitle.Text = "Update";
                cbStatusID.DataSource = null;
                cbStatusID.DataSource = statusUpdate;
            }
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
            DateTime now = DateTime.Now;
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
            if(InsertOrUpdate == false)
            {
                if (dateEnd < dateStart)
                {
                    MessageBox.Show("Start date can not be greater than end date", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpStartDate.Focus();
                    return false;
                }
                else if (dateStart < now || dateEnd < now)
                {
                    MessageBox.Show("Start date can not be less than current", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpStartDate.Focus();
                    return false;
                }
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                try
                {

                    if (InsertOrUpdate == false)
                    {
                        var course = new Course
                        {
                            CourseName = txtCourseName.Text,
                            SubjectId = (int)cbSubjectID.SelectedValue,
                            LecturerId = (string)cbLecturerID.SelectedValue,
                            StudentQuantity = int.Parse(txtStudentQuantity.Text),
                            StartDate = dtpStartDate.Value.Date,
                            EndDate = dtpEndDate.Value.Date,
                            StatusId = 3,
                        };
                        CourseRepository.InsertCourse(course);
                        MessageBox.Show("Create Successfully");
                        this.Close();
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
                            StartDate = dtpStartDate.Value.Date,
                            EndDate = dtpEndDate.Value.Date,
                            StatusId = (int)cbStatusID.SelectedValue,
                        };
                        CourseRepository.UpdateCourse(course);
                        MessageBox.Show("Update Successfully");
                        this.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new course" : "Update course");
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
