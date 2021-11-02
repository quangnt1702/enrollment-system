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

        private User LoginUser;

        public frmLogin()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
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
            else
            {
                MessageBox.Show("Wrong Email or Password");
            }
        }

        private bool checkLogin(string Email, string Password)
        {
            IEnumerable<User> listUser = new UserRepository().GetUserList();
            foreach (var user in listUser)
            {
                if (Email == user.Email && Password == user.Password)
                {
                    LoginUser = user;
                    return true;
                }
            }
            return false;
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
