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
        IFeedbackRepository feedbackRepository = new FeedbackRepository();
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
                                Status = c.Status.StatusName,
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
                txtCourseName.DataBindings.Add("Text", source, "Name");
                txtLecturer.DataBindings.Add("Text", source, "Lecturer");
                txtSubject.DataBindings.Add("Text", source, "Subject");

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
            cboSubject.SelectedItem = null;
            cboSubject.SelectedText = "---Subject---";
        }
        public void LoadStatusCourseList()
        {
            var statusCourseList = statusCourseRepository.GetStatuses();
            cboStatus.DataSource = statusCourseList;
            cboStatus.DisplayMember = "StatusName";
            cboStatus.ValueMember = "StatusId";
            cboStatus.SelectedItem = null;
            cboStatus.SelectedText = "---Status---";
        }
        private void frmStudentCourses_Load(object sender, EventArgs e)
        {
            LoadCourseList();
            LoadSubjectList();
            LoadStatusCourseList();
            txtCourseId.Hide();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            int numberStudent = courseRepository.GetNumberStudent(int.Parse(txtCourseId.Text));
            if (numberStudent >= int.Parse(txtQuantity.Text))
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
            else if (!checkEnroll())
            {
                MessageBox.Show("You have enrolled into this course!", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IGradeRepository gradeRepository = new GradeRepository();
                gradeRepository.InsertGrade(new Grade { StudentId = LoginUser.UserId, CourseId = int.Parse(txtCourseId.Text) });
                feedbackRepository.AddFeedback(new Feedback { CourseId = int.Parse(txtCourseId.Text), StudentId = LoginUser.UserId });
                MessageBox.Show("Enroll successfully!", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public bool checkEnroll()
        {
            bool check = false;
            string userID = LoginUser.UserId;
            string courseName = txtCourseName.Text;
            IGradeRepository gradeRepository = new GradeRepository();
            var gradeList = gradeRepository.GetGradesList();
            var courseList = courseRepository.GetCourses();
            var listEnrolled = (from g in gradeList
                                join c in courseList on g.CourseId equals c.CourseId
                                where c.CourseName == courseName && g.StudentId == userID && (c.StatusId == 1 || c.StatusId == 3)
                                select g
                              ).ToList();
            if (listEnrolled.Count == 0)
            {
                return true;
            }
            return check;
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            cboStatus.Text = "---Status---";
            cboSubject.Text = "---Subject---";
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
                txtCourseName.DataBindings.Clear();
                txtLecturer.DataBindings.Clear();
                txtSubject.DataBindings.Clear();


                txtCourseId.DataBindings.Add("Text", source, "ID");
                txtStatus.DataBindings.Add("Text", source, "Status");
                txtQuantity.DataBindings.Add("Text", source, "Quantity");
                txtCourseName.DataBindings.Add("Text", source, "Name");
                txtLecturer.DataBindings.Add("Text", source, "Lecturer");
                txtSubject.DataBindings.Add("Text", source, "Subject");

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
            cboStatus.Text = "---Status---";
            cboSubject.Text = "---Subject---";
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
                txtCourseName.DataBindings.Clear();
                txtLecturer.DataBindings.Clear();
                txtSubject.DataBindings.Clear();


                txtCourseId.DataBindings.Add("Text", source, "ID");
                txtStatus.DataBindings.Add("Text", source, "Status");
                txtQuantity.DataBindings.Add("Text", source, "Quantity");
                txtCourseName.DataBindings.Add("Text", source, "Name");
                txtLecturer.DataBindings.Add("Text", source, "Lecturer");
                txtSubject.DataBindings.Add("Text", source, "Subject");

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
            cboStatus.Text = "---Status---";
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
                txtCourseName.DataBindings.Clear();
                txtLecturer.DataBindings.Clear();
                txtSubject.DataBindings.Clear();


                txtCourseId.DataBindings.Add("Text", source, "ID");
                txtStatus.DataBindings.Add("Text", source, "Status");
                txtQuantity.DataBindings.Add("Text", source, "Quantity");
                txtCourseName.DataBindings.Add("Text", source, "Name");
                txtLecturer.DataBindings.Add("Text", source, "Lecturer");
                txtSubject.DataBindings.Add("Text", source, "Subject");

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
            cboSubject.Text = "---Subject---";
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
                txtCourseName.DataBindings.Clear();
                txtLecturer.DataBindings.Clear();
                txtSubject.DataBindings.Clear();


                txtCourseId.DataBindings.Add("Text", source, "ID");
                txtStatus.DataBindings.Add("Text", source, "Status");
                txtQuantity.DataBindings.Add("Text", source, "Quantity");
                txtCourseName.DataBindings.Add("Text", source, "Name");
                txtLecturer.DataBindings.Add("Text", source, "Lecturer");
                txtSubject.DataBindings.Add("Text", source, "Subject");

                dgvCourseList.DataSource = null;
                dgvCourseList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Filter course by status");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadCourseList();
            LoadSubjectList();
            LoadStatusCourseList();
        }

    }
}
