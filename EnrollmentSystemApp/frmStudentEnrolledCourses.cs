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
    public partial class frmStudentEnrolledCourses : Form
    {
        ICourseRepository courseRepository = new CourseRepository();
        ISubjectRepository subjectRepository = new SubjectRepository();

        BindingSource source = null;
        public User LoginUser { get; set; }
        public frmStudentEnrolledCourses()
        {
            InitializeComponent();
        }
        public void LoadEnrolledCourseList()
        {
            var courseList = courseRepository.GetCoursesByUserId("student1");
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
                txtCourseName.DataBindings.Clear();
                txtLecturer.DataBindings.Clear();
                txtSubject.DataBindings.Clear();

                txtCourseId.DataBindings.Add("Text", source, "ID");
                txtStatus.DataBindings.Add("Text", source, "Status");
                txtQuantity.DataBindings.Add("Text", source, "Quantity");
                txtSubject.DataBindings.Add("Text", source, "Subject");
                txtLecturer.DataBindings.Add("Text", source, "Lecturer");
                txtCourseName.DataBindings.Add("Text", source, "Name");


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
        private void frmStudentEnrolledCourses_Load(object sender, EventArgs e)
        {
            LoadEnrolledCourseList();
            LoadSubjectList();
            txtCourseId.Hide();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var listFilter = courseRepository.GetCoursesByUserId("student1").Where(c => c.StartDate >= dtpFrom.Value.Date && c.EndDate <= dtpTo.Value.Date).ToList();
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
                txtCourseName.DataBindings.Clear();
                txtLecturer.DataBindings.Clear();
                txtSubject.DataBindings.Clear();

                txtCourseId.DataBindings.Add("Text", source, "ID");
                txtStatus.DataBindings.Add("Text", source, "Status");
                txtQuantity.DataBindings.Add("Text", source, "Quantity");
                txtSubject.DataBindings.Add("Text", source, "Subject");
                txtLecturer.DataBindings.Add("Text", source, "Lecturer");
                txtCourseName.DataBindings.Add("Text", source, "Name");

                dgvCourseList.DataSource = null;
                dgvCourseList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var listSearch = courseRepository.GetCoursesByUserId("student1").Where(c => c.CourseName.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
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
                                StartDate = c.StartDate,
                                EndDate = c.EndDate,
                                Status = c.Status.StatusName
                            }).ToList();
                source = new BindingSource();
                source.DataSource = list;


                txtCourseId.DataBindings.Clear();
                txtStatus.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();
                txtCourseName.DataBindings.Clear();
                txtLecturer.DataBindings.Clear();
                txtSubject.DataBindings.Clear();

                txtCourseId.DataBindings.Add("Text", source, "ID");
                txtStatus.DataBindings.Add("Text", source, "Status");
                txtQuantity.DataBindings.Add("Text", source, "Quantity");
                txtSubject.DataBindings.Add("Text", source, "Subject");
                txtLecturer.DataBindings.Add("Text", source, "Lecturer");
                txtCourseName.DataBindings.Add("Text", source, "Name");

                dgvCourseList.DataSource = null;
                dgvCourseList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }

        private void btnViewGradeList_Click(object sender, EventArgs e)
        {
            if (btnViewGradeList.Text=="Back")
            {
                LoadEnrolledCourseList();
                btnViewGradeList.Text = "View Grade List";
            }
            else
            {
                IGradeRepository gradeRepository = new GradeRepository();
                var gradeList = gradeRepository.GetGradeOfStudent("student1", int.Parse(txtCourseId.Text));
                try
                {
                    var list = (from g in gradeList
                                select new
                                {
                                    CourseID = g.CourseId,
                                    CourseName = g.Course.CourseName,
                                    ProgressTest = g.ProgressTest,
                                    MidTermTest = g.MidTermTest,
                                    PracticeTest = g.MidTermTest,
                                    FinalTest = g.FinalTest,
                                    CourseStatus=g.Course.Status.StatusName
                                }).ToList();
                    dgvCourseList.DataSource = null;
                    dgvCourseList.DataSource = list;
                    btnViewGradeList.Text = "Back";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load grade list");
                }
            }
        }
        private void cboSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var subjectId = cboSubject.SelectedValue.ToString();
                var listSearch = courseRepository.GetCoursesByUserId("student1").Where(c => c.SubjectId == int.Parse(subjectId));
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
