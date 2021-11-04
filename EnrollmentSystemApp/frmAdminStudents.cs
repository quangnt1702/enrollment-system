
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
        BindingSource source;
        public frmAdminStudents()
        {
            InitializeComponent();
        }

        private void frmAdminStudents_Load(object sender, EventArgs e)
        {
            var context = new EnrollmentSystemContext();
            var course = context.Courses.ToList();
            cbCourse.DisplayMember = "CourseName";
            cbCourse.ValueMember = "CourseId";
            cbCourse.DataSource = course;
            LoadStudentList();
            txtUserID.Hide();
        }

        public void LoadStudentList()
        {
            var students = userRepository.GetStudentList();
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
            try
            {
                source = new BindingSource();
                source.DataSource = list;

                txtUserID.DataBindings.Clear();

                txtUserID.DataBindings.Add("Text", source, "UserId");

                dgvStudents.DataSource = null;
                dgvStudents.DataSource = source;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Load lecturer list");
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
            string studentID = txtUserID.Text;
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
                string studentID = txtUserID.Text;
                if (MessageBox.Show("Do you want to delete?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userRepository.RemoveUser(studentID);
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


                txtUserID.DataBindings.Clear();

                txtUserID.DataBindings.Add("Text", source, "UserId");

                dgvStudents.DataSource = null;
                dgvStudents.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load student list");
            }
        }

        private void cbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int courseID = (int)cbCourse.SelectedValue;
            LoadStudentByCourse(courseID);
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

                txtUserID.DataBindings.Clear();

                txtUserID.DataBindings.Add("Text", source, "UserID");

                dgvStudents.DataSource = null;
                dgvStudents.DataSource = source;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Load student list");
            }
        }
    }
}
