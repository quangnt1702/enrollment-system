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
    public partial class frmLecturerGrades : Form
    {
        
        public frmLecturerGrades()
        {
            InitializeComponent();
        }
        BindingSource source;
        IUserRepository userRepository = new UserRepository();
        ICourseRepository courseRepository = new CourseRepository();
        public User UserInfo { get; set; }

        
    }
}
