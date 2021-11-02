using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Models;
using DataAccess.Repository;

namespace EnrollmentSystemApp
{
    public partial class frmStudentProfile : Form
    {
        IUserRepository userRepository = new UserRepository();
        public User LoginUser { get; set; }
        public frmStudentProfile()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNewPassword.Text == "" && txtConfirmPassword.Text == "")
                {
                    User user = new User
                    {
                        UserId = LoginUser.UserId,
                        UserName = txtUserName.Text,
                        Email = txtEmail.Text,
                        Phone = txtPhone.Text,
                        Password = LoginUser.Password,
                        RoleId = LoginUser.RoleId,
                        StatusId = LoginUser.StatusId
                    };
                    userRepository.UpdateUser(user);
                    MessageBox.Show("Update success!", "Save");
                    LoadInfo();
                }
                else if (txtNewPassword.Text != "" || txtConfirmPassword.Text != "")
                {
                    if (txtNewPassword.Text.Equals(txtConfirmPassword.Text))
                    {
                        User user = new User
                        {
                            UserId = LoginUser.UserId,
                            UserName = txtUserName.Text,
                            Email = txtEmail.Text,
                            Phone = txtPhone.Text,
                            Password = txtNewPassword.Text,
                            RoleId = LoginUser.RoleId,
                            StatusId = LoginUser.StatusId
                        };
                        userRepository.UpdateUser(user);
                        MessageBox.Show("Update success!", "Save");
                        LoadInfo();
                    }
                    else
                    {
                        MessageBox.Show("Password and confirm password are not matched", "Change password");
                    }
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save error");
            }

        }
        public void LoadInfo()
        {
            LoginUser = userRepository.GetUserByID(LoginUser.UserId);
            txtUserName.Text = LoginUser.UserName;
            txtEmail.Text = LoginUser.Email;
            txtPhone.Text = LoginUser.Phone;
        }
        private void frmStudentProfile_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }
    }
}
