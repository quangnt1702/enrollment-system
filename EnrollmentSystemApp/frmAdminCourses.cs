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
    public partial class frmAdminCourses : Form
    {
        ICourseRepository courseRepository = new CourseRepository();
        public frmAdminCourses()
        {
            InitializeComponent();
        }

        private void frmAdminCourses_Load(object sender, EventArgs e)
        {
            var courseList = courseRepository.GetAllCourse();
            dgvCourses.DataSource = courseList;
        }
    }
}
