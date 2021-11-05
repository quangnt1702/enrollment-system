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
    public partial class frmAdminLecturers : Form
    {
        public User LoginUser { get; set; }
        IUserRepository userRepository = new UserRepository();
        ICourseRepository courseRepository = new CourseRepository();
        BindingSource source;
        public frmAdminLecturers()
        {
            InitializeComponent();
        }

        private void frmAdminLecturers_Load(object sender, EventArgs e)
        {
            LoadLecturerList();
            txtUserID.Hide();
        }

        public void LoadLecturerList()
        {
            var lecturers = userRepository.GetLecturerList();
            var list = (from c in lecturers
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

                dgvLecturers.DataSource = null;
                dgvLecturers.DataSource = source;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Load lecturer list");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdminLecturerDetails frmAdminLecturerDetails = new frmAdminLecturerDetails
            {
                Text = "Create New Lecturer",
                InsertOrUpdate = false,
                UserRepository = userRepository
            };
            if (frmAdminLecturerDetails.ShowDialog() == DialogResult.OK)
            {
                LoadLecturerList();
                source.Position = source.Count - 1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string lecturerID = txtUserID.Text;
            User lecturer = userRepository.GetUserByID(lecturerID);
            if (LoginUser.RoleId == 1)
            {
                if (btnDelete.Enabled == true)
                {
                    frmAdminLecturerDetails frmAdminLecturerDetails = new frmAdminLecturerDetails()
                    {
                        Text = "Update Lecturer",
                        InsertOrUpdate = true,
                        userInfo = lecturer,
                        UserRepository = userRepository
                    };
                    if (frmAdminLecturerDetails.ShowDialog() == DialogResult.OK)
                    {
                        LoadLecturerList();
                        source.Position = source.Count - 1;
                    }
                }
                else
                {
                    MessageBox.Show("Empty list course");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string lecturerID = txtUserID.Text;
                if (courseRepository.GetCourseListOfLecturer(lecturerID) != null)
                {
                    if (MessageBox.Show("Do you want to delete?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var lecturer = userRepository.GetUserByID(lecturerID);
                        lecturer.StatusId = 2;
                        userRepository.UpdateUser(lecturer);
                        LoadLecturerList();
                    }
                }
                else
                {
                    MessageBox.Show("Lecturers who are teaching cannot delete");
                    LoadLecturerList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Lecturer");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var listSearch = userRepository.GetLecturerList().Where(c => c.UserName.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
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

                dgvLecturers.DataSource = null;
                dgvLecturers.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load lecturer list");
            }
        }
    }
}
