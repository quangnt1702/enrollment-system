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
    public partial class frmLecturerProfile : Form
    {
   

        public frmLecturerProfile()
        {
            InitializeComponent();
        }
        IUserRepository userRepository = new UserRepository();
        public User LoginUser { get; set; }

        private void frmLecturerProfile_Load(object sender, EventArgs e)
        {
            LoadProfile();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text == "" && txtConfirm.Text == "")
                {
                    if (txtName.Text != "")
                    {
                        if (txtEmail.Text != "")
                        {
                            User user = new User
                            {
                                UserId = LoginUser.UserId,
                                UserName = txtName.Text,
                                Email = txtEmail.Text,
                                Phone = txtPhone.Text,
                                Password = LoginUser.Password,
                                RoleId = LoginUser.RoleId,
                                StatusId = LoginUser.StatusId
                            };
                            userRepository.UpdateUser(user);
                            MessageBox.Show("Update success!", "Save");
                            LoadProfile();
                        }
                        else
                        {
                            MessageBox.Show("Email can't be null!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Name can't be null!");
                    }
                }
                else if (txtPassword.Text != "" || txtConfirm.Text != "")
                {
                    if (txtPassword.Text.Equals(txtConfirm.Text))
                    {
                        User user = new User
                        {
                            UserId = LoginUser.UserId,
                            UserName = txtName.Text,
                            Email = txtEmail.Text,
                            Phone = txtPhone.Text,
                            Password = txtPassword.Text,
                            RoleId = LoginUser.RoleId,
                            StatusId = LoginUser.StatusId
                        };
                        userRepository.UpdateUser(user);
                        MessageBox.Show("Update success!", "Save");
                        LoadProfile();
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
    

        private void btnCancel_Click(object sender, EventArgs e) => Close();
        public void LoadProfile()
        {
            LoginUser = userRepository.GetUserByID(LoginUser.UserId);
            txtName.Text = LoginUser.UserName;
            txtEmail.Text = LoginUser.Email;
            txtPhone.Text = LoginUser.Phone;
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
