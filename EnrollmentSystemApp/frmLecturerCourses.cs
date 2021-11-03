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
    public partial class frmLecturerCourses : Form
    {
        public User LoginUser { get; set; }
        ICourseRepository courseRepository = new CourseRepository();
        IUserRepository userRepository = new UserRepository();
        BindingSource source;
        public frmLecturerCourses()
        {
            InitializeComponent();
        }

        private void frmLecturerCourses_Load(object sender, EventArgs e)
        {
            var context = new EnrollmentSystemContext();
            var subject = context.Subjects.ToList();
            cbbSubject.DisplayMember = "SubjectName";
            cbbSubject.ValueMember = "SubjectId";
            cbbSubject.DataSource = subject;
            LoadCourseByUserID();
        }
        public void LoadAllCourseList()
        {
            var courses = courseRepository.GetCourses();
            var list = (from c in courses
                        select new
                        {
                            CourseID = c.CourseId,
                            CourseName = c.CourseName,
                            SubjectID = c.Subject.SubjectName,
                            LecturerID = c.Lecturer.UserName,
                            StudentQuantity = c.StudentQuantity,
                            StartDate = c.StartDate,
                            EndDate = c.EndDate,
                            StatusID = c.Status.StatusName
                        }).ToList();
            try
            {
                source = new BindingSource();
                source.DataSource = list;

                txtCourseID.DataBindings.Clear();

                txtCourseID.DataBindings.Add("Text", source, "CourseID");

                dgvCourses.DataSource = null;
                dgvCourses.DataSource = source;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Load courses list");
            }
        }
        public void LoadCourseByStatusID(int statusID)
        {
            var courses = courseRepository.GetCourseByStatus(statusID);
            var list = (from c in courses
                        select new
                        {
                            CourseID = c.CourseId,
                            CourseName = c.CourseName,
                            SubjectID = c.Subject.SubjectName,
                            LecturerID = c.Lecturer.UserName,
                            StudentQuantity = c.StudentQuantity,
                            StartDate = c.StartDate,
                            EndDate = c.EndDate,
                            StatusID = c.Status.StatusName
                        }).ToList();
            try
            {
                source = new BindingSource();
                source.DataSource = list;

                txtCourseID.DataBindings.Clear();

                txtCourseID.DataBindings.Add("Text", source, "CourseID");

                dgvCourses.DataSource = null;
                dgvCourses.DataSource = source;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Load courses list");
            }
        }
        public void LoadCourseByUserID()
        {
            var courses = courseRepository.GetCoursesByUserId(LoginUser.UserId);
            var list = (from c in courses
                        select new
                        {
                            CourseID = c.CourseId,
                            CourseName = c.CourseName,
                            SubjectID = c.Subject.SubjectName,
                            LecturerID = c.Lecturer.UserName,
                            StudentQuantity = c.StudentQuantity,
                            StartDate = c.StartDate,
                            EndDate = c.EndDate,
                            StatusID = c.Status.StatusName
                        }).ToList();
            try
            {
                source = new BindingSource();
                source.DataSource = list;

                txtCourseID.DataBindings.Clear();

                txtCourseID.DataBindings.Add("Text", source, "CourseID");

                dgvCourses.DataSource = null;
                dgvCourses.DataSource = source;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Load courses list");
            }
        }

        private void btnAllCourses_Click(object sender, EventArgs e)
        {
            LoadAllCourseList();
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            LoadCourseByStatusID(3);
        }

        private void btnStarting_Click(object sender, EventArgs e)
        {
            LoadCourseByStatusID(1);
        }

        private void btnEnded_Click(object sender, EventArgs e)
        {
            LoadCourseByStatusID(2);
        }
        public void LoadCourseBySubject(int subjectID)
        {
            var courses = courseRepository.GetCourseBySubject(subjectID);
            var list = (from c in courses
                        select new
                        {
                            CourseID = c.CourseId,
                            CourseName = c.CourseName,
                            SubjectID = c.Subject.SubjectName,
                            LecturerID = c.Lecturer.UserName,
                            StudentQuantity = c.StudentQuantity,
                            StartDate = c.StartDate,
                            EndDate = c.EndDate,
                            StatusID = c.Status.StatusName
                        }).ToList();
            try
            {
                source = new BindingSource();
                source.DataSource = list;

                txtCourseID.DataBindings.Clear();

                txtCourseID.DataBindings.Add("Text", source, "CourseID");

                dgvCourses.DataSource = null;
                dgvCourses.DataSource = source;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Load courses list");
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
                                CourseID = c.CourseId,
                                CourseName = c.CourseName,
                                SubjectID = c.Subject.SubjectName,
                                LecturerID = c.Lecturer.UserName,
                                StudentQuantity = c.StudentQuantity,
                                StartDate = c.StartDate,
                                EndDate = c.EndDate,
                                StatusID = c.Status.StatusName
                            }).ToList();
                source = new BindingSource();
                source.DataSource = list;


                txtCourseID.DataBindings.Clear();

                txtCourseID.DataBindings.Add("Text", source, "CourseID");

                dgvCourses.DataSource = null;
                dgvCourses.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load course list");
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
                                CourseID = c.CourseId,
                                CourseName = c.CourseName,
                                SubjectID = c.Subject.SubjectName,
                                LecturerID = c.Lecturer.UserName,
                                StudentQuantity = c.StudentQuantity,
                                StartDate = c.StartDate,
                                EndDate = c.EndDate,
                                StatusID = c.Status.StatusName
                            }).ToList();
                source = new BindingSource();
                source.DataSource = list;

                txtCourseID.DataBindings.Clear();

                txtCourseID.DataBindings.Add("Text", source, "CourseID");

                dgvCourses.DataSource = null;
                dgvCourses.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load course list");
            }

        }
    }
}
