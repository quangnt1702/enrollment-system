using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DataAccess.Models;
using DataAccess.Repository;

namespace EnrollmentSystemApp
{
    public partial class frmStudentCourses : Form
    {
        ICourseRepository courseRepository = new CourseRepository();
        ISubjectRepository subjectRepository = new SubjectRepository();
        BindingSource source = null;
        public User LoginUser { get; set; }
        public int AdminOrStudentOrLecturer { get; set; }//1:Admin;2:Student;3:Lecturer
        public frmStudentCourses()
        {
            InitializeComponent();
        }
        public void LoadCourseList()
        {
            var courseList = courseRepository.GetCourses();
            try
            {
                var list = (from c in courseList
                            select new
                            {
                                ID = c.CourseId,
                                Name = c.CourseName,
                                Subject = c.Subject.SubjectName,
                                Lecturer = c.Lecturer.UserName,
                                Quantity = c.StudentQuantity,
                                StartDate = c.StartDate,
                                EndDate = c.EndDate,
                                Status = c.Status.StatusName
                            }).ToList();
                source = new BindingSource();
                source.DataSource = list;

                txtCourseId.DataBindings.Clear();
                txtStatus.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();

                txtCourseId.DataBindings.Add("Text", source, "ID");
                txtStatus.DataBindings.Add("Text", source, "Status");
                txtQuantity.DataBindings.Add("Text", source, "Quantity");

                dgvCourseList.DataSource = null;
                dgvCourseList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }

        }
        public void LoadSubjectList()
        {
            var subjectList = subjectRepository.GetSubjects();
            cboSubject.DataSource = subjectList;
            cboSubject.DisplayMember = "SubjectName";
            cboSubject.ValueMember = "SubjectId";
        }
        private void frmStudentCourses_Load(object sender, EventArgs e)
        {
            LoadCourseList();
            LoadSubjectList();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            int numberStudent = courseRepository.GetNumberStudent(int.Parse(txtCourseId.Text));
            if (numberStudent > int.Parse(txtQuantity.Text))
            {
                MessageBox.Show("The course was full!", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtStatus.Text.Equals("Start"))
            {
                MessageBox.Show("The course was started!", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtStatus.Text.Equals("End"))
            {
                MessageBox.Show("The course was ended!", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IGradeRepository gradeRepository = new GradeRepository();
                gradeRepository.InsertGrade(new Grade { StudentId = "student1", CourseId = int.Parse(txtCourseId.Text) });
                MessageBox.Show("Enroll successfully!", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var listFilter = courseRepository.GetCourses().Where(c => c.StartDate >= dtpFrom.Value.Date && c.EndDate <= dtpTo.Value.Date).ToList();
            try
            {
                var list = (from c in listFilter
                            select new
                            {
                                ID = c.CourseId,
                                Name = c.CourseName,
                                Subject = c.Subject.SubjectName,
                                Lecturer = c.Lecturer.UserName,
                                Quantity = c.StudentQuantity,
                                StartDate = c.StartDate,
                                EndDate = c.EndDate,
                                Status = c.Status.StatusName
                            }).ToList();
                source = new BindingSource();
                source.DataSource = list;

                txtCourseId.DataBindings.Clear();
                txtStatus.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();

                txtCourseId.DataBindings.Add("Text", source, "ID");
                txtStatus.DataBindings.Add("Text", source, "Status");
                txtQuantity.DataBindings.Add("Text", source, "Quantity");

                dgvCourseList.DataSource = null;
                dgvCourseList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Filter member list");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var listSearch = courseRepository.GetCourses().Where(c => c.CourseName.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
            try
            {
                var list = (from c in listSearch
                            select new
                            {
                                ID = c.CourseId,
                                Name = c.CourseName,
                                Subject = c.Subject.SubjectName,
                                Lecturer = c.Lecturer.UserName,
                                Quantity = c.StudentQuantity,
                                StartDate = c.StartDate.Date,
                                EndDate = c.EndDate.Date,
                                Status = c.Status.StatusName
                            }).ToList();
                source = new BindingSource();
                source.DataSource = list;


                txtCourseId.DataBindings.Clear();
                txtStatus.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();

                txtCourseId.DataBindings.Add("Text", source, "ID");
                txtStatus.DataBindings.Add("Text", source, "Status");
                txtQuantity.DataBindings.Add("Text", source, "Quantity");

                dgvCourseList.DataSource = null;
                dgvCourseList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search course list");
            }
        }

        private void cboSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var subjectId = cboSubject.SelectedValue.ToString();
                var listSearch = courseRepository.GetCourses().Where(c => c.SubjectId == int.Parse(subjectId));
                var list = (from c in listSearch
                            select new
                            {
                                ID = c.CourseId,
                                Name = c.CourseName,
                                Subject = c.Subject.SubjectName,
                                Lecturer = c.Lecturer.UserName,
                                Quantity = c.StudentQuantity,
                                StartDate = c.StartDate.Date,
                                EndDate = c.EndDate.Date,
                                Status = c.Status.StatusName
                            }).ToList();
                source = new BindingSource();
                source.DataSource = list;


                txtCourseId.DataBindings.Clear();
                txtStatus.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();

                txtCourseId.DataBindings.Add("Text", source, "ID");
                txtStatus.DataBindings.Add("Text", source, "Status");
                txtQuantity.DataBindings.Add("Text", source, "Quantity");

                dgvCourseList.DataSource = null;
                dgvCourseList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Filter course list");
            }
        }
    }
}
