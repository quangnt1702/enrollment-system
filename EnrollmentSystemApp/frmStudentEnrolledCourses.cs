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
        IStatusCourseRepository statusCourseRepository = new StatusCourseRepository();
        BindingSource source = null;
        public User LoginUser { get; set; }
        public frmStudentEnrolledCourses()
        {
            InitializeComponent();
        }
        public void LoadEnrolledCourseList()
        {
            var courseList = courseRepository.GetCoursesByUserId(LoginUser.UserId);
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
        public void LoadStatusCourseList()
        {
            var statusCourseList = statusCourseRepository.GetStatuses();
            cboStatus.DataSource = statusCourseList;
            cboStatus.DisplayMember = "StatusName";
            cboStatus.ValueMember = "StatusId";
        }
        private void frmStudentEnrolledCourses_Load(object sender, EventArgs e)
        {
            LoadEnrolledCourseList();
            LoadSubjectList();
            LoadStatusCourseList();
            txtCourseId.Hide();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            cboStatus.SelectedIndex = 0;
            cboSubject.SelectedIndex = 0;
            txtSearch.Text = "";
            var listFilter = courseRepository.GetCoursesByUserId(LoginUser.UserId).Where(c => c.StartDate >= dtpFrom.Value.Date && c.EndDate <= dtpTo.Value.Date).ToList();
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
                MessageBox.Show(ex.Message, "Filter course by date");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
            cboStatus.SelectedIndex = 0;
            cboSubject.SelectedIndex = 0;
            var listSearch = courseRepository.GetCoursesByUserId(LoginUser.UserId).Where(c => c.CourseName.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
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
                MessageBox.Show(ex.Message, "Search course by name");
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
                var gradeList = gradeRepository.GetGradeOfStudent(LoginUser.UserId, int.Parse(txtCourseId.Text));
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
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
            cboStatus.SelectedIndex = 0;
            txtSearch.Text = "";
            try
            {
                var subjectId = cboSubject.SelectedValue.ToString();
                var listSearch = courseRepository.GetCoursesByUserId(LoginUser.UserId).Where(c => c.SubjectId == int.Parse(subjectId));
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
            try
            {
                dtpFrom.Value = DateTime.Now;
                dtpTo.Value = DateTime.Now;
                cboSubject.SelectedIndex = 0;
                txtSearch.Text = "";
                var statusId = cboStatus.SelectedValue.ToString();
                var listSearch = courseRepository.GetCoursesByUserId(LoginUser.UserId).Where(c => c.StatusId == int.Parse(statusId));
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
