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
        IGradeRepository gradeRepository = new GradeRepository();
        public User LoginUser { get; set; }
       
        private void frmLecturerGrades_Load(object sender, EventArgs e)
        {
            var context = new EnrollmentSystemContext();
            var course = context.Courses.Where(c => c.LecturerId == LoginUser.UserId).ToList();
            cbCourse.DisplayMember = "CourseName";
            cbCourse.ValueMember = "CourseId";
            cbCourse.DataSource = course;

        }
        public void LoadStudentListByCourse(int CourseID)
        {
            var students = userRepository.GetStudentByCourse(CourseID);
            var list = (from c in students
                        select new
                        {
                            UserID = c.UserId,
                            UserName = c.UserName, 
                            Phone = c.Phone,
                            Email = c.Email,                            
                            
                        }).ToList();
            try
            {
                source = new BindingSource();
                source.DataSource = list;
                
                txtStudentID.DataBindings.Clear();
                txtStudentID.DataBindings.Add("Text", source, "UserId");
                dgvStudent.DataSource = null;
                dgvStudent.DataSource = source;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Load Student list");
            }
        }

        private void cbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int courseID = (int)cbCourse.SelectedValue;
            LoadStudentListByCourse(courseID);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var listSearch = userRepository.GetStudentList().Where(c => c.UserName.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
            try
            {
                var list = (from c in listSearch
                            select new
                            {   
                                UserID = c.UserId,
                                UserName = c.UserName,
                                Phone = c.Phone,
                                Email = c.Email,                                
                            }).ToList();
                source = new BindingSource();
                source.DataSource = list;
                txtStudentID.DataBindings.Clear();
                txtStudentID.DataBindings.Add("Text", source, "UserId");
                dgvStudent.DataSource = null;
                dgvStudent.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load student list");
            }
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int courseID = (int)cbCourse.SelectedValue;
            string studentID = txtStudentID.Text;
            frmLecturerGradesDetails frm = new frmLecturerGradesDetails
            {
                UserID = txtStudentID.Text,
                CourseID = (int)cbCourse.SelectedValue
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                int ID = (int)cbCourse.SelectedValue;
                LoadStudentListByCourse(ID);
                source.Position = source.Count - 1;
            }
        }
    }
}
