
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
    public partial class frmAdminStudents : Form
    {
        public User LoginUser { get; set; }
        IUserRepository userRepository = new UserRepository();
        ICourseRepository courseRepository = new CourseRepository();
        BindingSource source;
        public frmAdminStudents()
        {
            InitializeComponent();
        }

        private void frmAdminStudents_Load(object sender, EventArgs e)
        {
            LoadCourseList();
            txtCourseID.Hide();
            if (btnViewAllStudent.Text == "Back")
            {
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                txtSearch.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                txtSearch.Enabled = false;
            }
        }

        public void LoadCourseList()
        {
            var courses = courseRepository.GetCourses();
            var list = (from c in courses
                        select new
                        {
                            ID = c.CourseId,
                            CourseName = c.CourseName,
                            Subject = c.Subject.SubjectName,
                            Lecturer = c.Lecturer.UserName,
                            StudentQuantity = c.StudentQuantity,
                            StartDate = c.StartDate,
                            EndDate = c.EndDate,
                            Status = c.Status.StatusName
                        }).ToList();
            try
            {
                source = new BindingSource();
                source.DataSource = list;

                txtCourseID.DataBindings.Clear();

                txtCourseID.DataBindings.Add("Text", source, "ID");

                dgvStudents.DataSource = null;
                dgvStudents.DataSource = source;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Load course list");
            }
        }

        public void LoadStudentListByCourse(int courseID)
        {
            var students = userRepository.GetStudentByCourse(courseID);
            try
            {
                if (students != null)
                {
                    var list = (from c in students
                                select new
                                {
                                    UserID = c.UserId,
                                    UserName = c.UserName,
                                    Password = c.Password,
                                    Phone = c.Phone,
                                    Email = c.Email,
                                    RoleId = c.Role.RoleName,
                                    StatusId = c.Status.StatusName
                                }).ToList();
                    source = new BindingSource();
                    source.DataSource = list;

                    txtCourseID.DataBindings.Clear();

                    txtCourseID.DataBindings.Add("Text", source, "UserId");

                    dgvStudents.DataSource = null;
                    dgvStudents.DataSource = source;
                }
                else
                {
                    MessageBox.Show("This course have no students", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCourseList();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Load lecturer list");
            }
        }

        public void LoadStudentList()
        {
            var students = userRepository.GetStudentList();
            try
            {
                var list = (from c in students
                            select new
                            {
                                UserID = c.UserId,
                                UserName = c.UserName,
                                Password = c.Password,
                                Phone = c.Phone,
                                Email = c.Email,
                                RoleId = c.Role.RoleName,
                                StatusId = c.Status.StatusName
                            }).ToList();
                source = new BindingSource();
                source.DataSource = list;

                txtCourseID.DataBindings.Clear();

                txtCourseID.DataBindings.Add("Text", source, "UserId");

                dgvStudents.DataSource = null;
                dgvStudents.DataSource = source;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Load student list");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdminStudentDetails frmAdminStudentDetails = new frmAdminStudentDetails
            {
                Text = "Create New Student",
                InsertOrUpdate = false,
                UserRepository = userRepository
            };
            if (frmAdminStudentDetails.ShowDialog() == DialogResult.OK)
            {
                LoadStudentList();
                source.Position = source.Count - 1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string studentID = txtCourseID.Text;
            User student = userRepository.GetUserByID(studentID);
            if (LoginUser.RoleId == 1)
            {
                if (btnDelete.Enabled == true)
                {
                    frmAdminStudentDetails frmAdminStudentDetails = new frmAdminStudentDetails()
                    {
                        Text = "Update Student",
                        InsertOrUpdate = true,
                        userInfo = student,
                        UserRepository = userRepository
                    };
                    if (frmAdminStudentDetails.ShowDialog() == DialogResult.OK)
                    {
                        LoadStudentList();
                        source.Position = source.Count - 1;
                    }
                }
                else
                {
                    MessageBox.Show("Empty list student");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string studentID = txtCourseID.Text;
                if( courseRepository.GetCoursesByUserId(studentID) == null)
                {
                    if (MessageBox.Show("Do you want to delete?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var user = userRepository.GetUserByID(studentID);
                        user.StatusId = 2;
                        userRepository.UpdateUser(user);
                        LoadStudentList();
                    }
                }
                else
                {
                    MessageBox.Show("Students who are studying cannot delete");
                    LoadStudentList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Student");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var listSearch = userRepository.GetStudentList().Where(c => c.UserName.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
            try
            {
                var list = (from c in listSearch
                            select new
                            {
                                UserID = c.UserId,
                                UserName = c.UserName,
                                Password = c.Password,
                                Phone = c.Phone,
                                Email = c.Email,
                                RoleId = c.Role.RoleName,
                                StatusId = c.Status.StatusName
                            }).ToList();
                source = new BindingSource();
                source.DataSource = list;


                txtCourseID.DataBindings.Clear();

                txtCourseID.DataBindings.Add("Text", source, "UserId");

                dgvStudents.DataSource = null;
                dgvStudents.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load student list");
            }
        }

        public void LoadStudentByCourse(int courseID)
        {
            var students = userRepository.GetStudentByCourse(courseID);
            var list = (from c in students
                        select new
                        {
                            UserID = c.UserId,
                            UserName = c.UserName,
                            Password = c.Password,
                            Phone = c.Phone,
                            Email = c.Email,
                            RoleID = c.Role.RoleName,
                            StatusID = c.Status.StatusName
                        }).ToList();
            try
            {
                source = new BindingSource();
                source.DataSource = list;

                txtCourseID.DataBindings.Clear();

                txtCourseID.DataBindings.Add("Text", source, "UserID");

                dgvStudents.DataSource = null;
                dgvStudents.DataSource = source;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Load student list");
            }
        }

        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            if (btnViewStudents.Text == "Back")
            {
                LoadCourseList();
                btnViewAllStudent.Enabled = true;
                btnViewStudents.Text = "View Students";
                lbCourse.Text = "Courses";
            }
            else
            {
                int course = int.Parse(txtCourseID.Text);
                LoadStudentByCourse(course);
                btnViewAllStudent.Enabled = false;
                btnViewStudents.Text = "Back";
                lbCourse.Text = "Students";
            }
        }

        private void btnViewAllStudent_Click(object sender, EventArgs e)
        {
            if(btnViewAllStudent.Text == "Back")
            {
                LoadCourseList();
                btnViewStudents.Enabled = true;
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                txtSearch.Enabled = false;
                btnViewAllStudent.Text = "View All Students";
            }
            else
            {
                btnViewStudents.Enabled = false;
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                txtSearch.Enabled = true;
                LoadStudentList();
                btnViewAllStudent.Text = "Back";
            }
        }
    }
}
