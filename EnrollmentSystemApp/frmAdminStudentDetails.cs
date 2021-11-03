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
    public partial class frmAdminStudentDetails : Form
    {
        public IUserRepository UserRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public User userInfo { get; set; }
        public frmAdminStudentDetails()
        {
            InitializeComponent();
        }

        private void frmAdminStudentDetails_Load(object sender, EventArgs e)
        {
            txtRoleID.Enabled = false;
            txtStatusID.Enabled = false;
            if (InsertOrUpdate == true)
            {
                txtStudentID.Text = userInfo.UserId.ToString();
                txtStudentName.Text = userInfo.UserName;
                txtPassword.Text = userInfo.Password;
                txtPhone.Text = userInfo.Phone;
                txtEmail.Text = userInfo.Email;
                txtRoleID.Text = userInfo.RoleId.ToString();
                txtStatusID.Text = userInfo.StatusId.ToString();
            }
        }

        public bool CheckData()
        {
            var studentList = UserRepository.GetUserList();
            foreach (var s in studentList)
            {
                if (txtEmail.Text == s.Email)
                {
                    MessageBox.Show("Email is already exist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return false;
                }
            }
            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                MessageBox.Show("Student ID is blank", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtStudentName.Text))
            {
                MessageBox.Show("Student Name is blank", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password is blank", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Phone is blank", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is blank", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
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
                        var lecturer = new User
                        {
                            UserId = txtStudentID.Text,
                            UserName = txtStudentName.Text,
                            Password = txtPassword.Text,
                            Phone = txtPhone.Text,
                            Email = txtEmail.Text,
                            RoleId = 3,
                            StatusId = 1,
                        };
                        UserRepository.AddUser(lecturer);
                    }
                    else
                    {
                        var lecturer = new User
                        {
                            UserId = txtStudentID.Text,
                            UserName = txtStudentName.Text,
                            Password = txtPassword.Text,
                            Phone = txtPhone.Text,
                            Email = txtEmail.Text,
                            RoleId = 3,
                            StatusId = 1,
                        };
                        UserRepository.UpdateUser(lecturer);
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
