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
        BindingSource source;

        public frmLecturerProfile()
        {
            InitializeComponent();
        }
        IUserRepository userRepository = new UserRepository();
        public User UserInfo { get; set; }

        private void frmLecturerProfile_Load(object sender, EventArgs e)
        {
            txtID.Text = UserInfo.UserId.ToString();
            txtName.Text = UserInfo.UserName.ToString();
            txtEmail.Text = UserInfo.Email.ToString();
            txtPhone.Text = UserInfo.Phone.ToString();
            txtPassword.Text = UserInfo.Password.ToString();
            txtConfirm.Text = UserInfo.Password.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirm.Text)
            {
                try
                {
                    var mem = new User
                    {
                        UserId = txtID.Text,
                        UserName = txtName.Text,
                        Password = txtPassword.Text,
                        Phone = txtPhone.Text,
                        Email = txtEmail.Text,
                        RoleId = UserInfo.RoleId,
                        StatusId = UserInfo.StatusId
                };
                    userRepository.UpdateUser(mem);
                    User u = userRepository.GetUserByID(mem.UserId);
                    LoadProfile(u);
                    MessageBox.Show("Update Succesfully");
                    frmLecturer frm = new frmLecturer();
                    frm.Close();
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                };
            } else
            {
                MessageBox.Show("Wrong confirm password");
            }          

        }
    

        private void btnCancel_Click(object sender, EventArgs e) => Close();
        public void LoadProfile(User user)
        {
            txtID.Text = user.UserId.ToString();
            txtName.Text = user.UserName.ToString();
            txtEmail.Text = user.Email.ToString();
            txtPhone.Text = user.Phone.ToString();
            txtPassword.Text = user.Password.ToString();
            txtConfirm.Text = user.Password.ToString();
        }
        private void ClearText()
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}
