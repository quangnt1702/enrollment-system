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
        IStatusCourseRepository statusCourseRepository = new StatusCourseRepository();
        BindingSource source = null;
        public User LoginUser { get; set; }
        public int AdminOrStudentOrLecturer { get; set; }//1:Admin;2:Student;3:Lecturer
        public frmStudentCourses()
        {
            InitializeComponent();
        }
        public void ClearSearch()
        {
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
            cboStatus.SelectedIndex = 0;
            cboSubject.SelectedIndex = 0;
            txtSearch.Text = "";
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
        public void LoadStatusCourseList()
        {
            var statusCourseList = statusCourseRepository.GetStatuses();
            cboStatus.DataSource = statusCourseList;
            cboStatus.DisplayMember = "StatusName";
            cboStatus.ValueMember = "StatusId";
        }
        private void frmStudentCourses_Load(object sender, EventArgs e)
        {
            LoadCourseList();
            LoadSubjectList();
            LoadStatusCourseList();
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
            cboStatus.SelectedIndex = 0;
            cboSubject.SelectedIndex = 0;
            txtSearch.Text = "";
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
                MessageBox.Show(ex.Message, "Filter course by date");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
            cboStatus.SelectedIndex = 0;
            cboSubject.SelectedIndex = 0;
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
                MessageBox.Show(ex.Message, "Search course buy name");
            }
        }

        private void cboSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
            cboStatus.SelectedIndex = 0;
            txtSearch.Text = "";
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
                MessageBox.Show(ex.Message, "Filter course by subject");
            }
        }

        private void cboStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
            cboSubject.SelectedIndex = 0;
            txtSearch.Text = "";
            try
            {
                var statusId = cboStatus.SelectedValue.ToString();
                var listSearch = courseRepository.GetCourses().Where(c => c.StatusId == int.Parse(statusId));
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
                MessageBox.Show(ex.Message, "Filter course by status");
            }
        }
    }
}
