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
using DataAccess.Repository;

namespace EnrollmentSystemApp
{
    public partial class frmLogin : Form
    {
        ICourseRepository courseRepository = new CourseRepository();
        private User LoginUser;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            courseRepository.CheckStatusCourse();
            string Email = txtEmail.Text;
            string Password = txtPassword.Text;

            if (checkLogin(Email, Password))
            {
                if (LoginUser.RoleId == 1)
                {
                    frmAdmin frmAdmin = new frmAdmin();
                    frmAdmin.LoginUser = LoginUser;
                    this.Hide();
                    frmAdmin.ShowDialog();
                    this.Show();
                }
                else if (LoginUser.RoleId == 2)
                {
                    frmLecturer frmLecturer = new frmLecturer();
                    frmLecturer.LoginUser = LoginUser;
                    this.Hide();
                    frmLecturer.ShowDialog();
                    this.Show();
                }
                else
                {
                    frmStudent frmStudent = new frmStudent();
                    frmStudent.LoginUser = LoginUser;
                    this.Hide();
                    frmStudent.ShowDialog();
                    this.Show();
                }
            }
        }

        private bool checkLogin(string Email, string Password)
        {
            IEnumerable<User> listUser = new UserRepository().GetUserList();
            bool flag = false;
            foreach (var user in listUser)
            {
                if (Email == user.Email && Password == user.Password)
                {
                    if(user.StatusId == 1)
                    {
                        flag = true;
                        LoginUser = user;
                        return flag;
                    }else if(user.StatusId == 2)
                    {
                        MessageBox.Show("You are banned");
                        return false;
                    }
                }
            }
            if(flag == false)
            {
                MessageBox.Show("Wrong Email or Password");
            }
            return flag;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Exit program?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
