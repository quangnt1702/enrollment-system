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
    public partial class frmStudentCourses : Form
    {
        ICourseRepository courseRepository = new CourseRepository();
        public frmStudentCourses()
        {
            InitializeComponent();
        }
        public void LoadCourseList()
        {
            var courseList = courseRepository.GetCourses();
            var list = (from c in courseList
                        select new
                        {
                            ID = c.CourseId,
                            Name = c.CourseName,
                            Subject = c.Subject.SubjectName,
                            Lecture = c.Lecturer.UserName,
                            Quantity = c.StudentQuantity,
                            StartDate = c.StartDate,
                            EndDate = c.EndDate,
                            Status = c.Status.StatusName
                        }).ToList();
            dgvCourseList.DataSource = null;
            dgvCourseList.DataSource = list;
        }

        private void frmStudentCourses_Load(object sender, EventArgs e)
        {
            LoadCourseList();
        }

        private void btnAllCourses_Click(object sender, EventArgs e)
        {
            LoadCourseList();
        }
    }
}
