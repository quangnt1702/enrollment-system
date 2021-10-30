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
        IUserRepository userRepository = new UserRepository();
        public frmAdminStudents()
        {
            InitializeComponent();
        }

        private void frmAdminStudents_Load(object sender, EventArgs e)
        {
            try
            {
                var studentList = userRepository.GetUserList();
                dgvStudents.DataSource = studentList;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
