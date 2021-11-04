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
        IFeedbackRepository feedbackRepository = new FeedbackRepository();
        BindingSource source = null;
        public User LoginUser { get; set; }
        public frmStudentEnrolledCourses()
        {
            InitializeComponent();
        }
        public void BindingData(List<Course> courseList)
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
                            Feedback = c.Feedbacks.SingleOrDefault(f => f.StudentId == LoginUser.UserId).FeedbackContent
                        }).ToList();
            source = new BindingSource();
            source.DataSource = list;
            if (courseList.Count > 0)
            {
                txtCourseId.DataBindings.Clear();
                txtStatus.DataBindings.Clear();
                txtCourseName.DataBindings.Clear();
                txtLecturer.DataBindings.Clear();
                txtSubject.DataBindings.Clear();
                txtFeedback.DataBindings.Clear();

                txtCourseId.DataBindings.Add("Text", source, "ID");
                txtStatus.DataBindings.Add("Text", source, "Status");
                txtSubject.DataBindings.Add("Text", source, "Subject");
                txtLecturer.DataBindings.Add("Text", source, "Lecturer");
                txtCourseName.DataBindings.Add("Text", source, "Name");
                txtFeedback.DataBindings.Add("Text", source, "Feedback");

                btnViewGradeList.Enabled = true;
            }
            else
            {
                btnViewGradeList.Enabled = false;
                ClearText();
            }

            dgvCourseList.DataSource = null;
            dgvCourseList.DataSource = source;
        }
        public void LoadEnrolledCourseList()
        {
            var courseList = courseRepository.GetCoursesByUserId(LoginUser.UserId).ToList();
            try
            {
                BindingData(courseList);
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
        private void frmStudentEnrolledCourses_Load(object sender, EventArgs e)
        {
            LoadEnrolledCourseList();
            LoadSubjectList();
            LoadStatusCourseList();
            txtCourseId.Hide();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            cboStatus.Text = "---Status---";
            cboSubject.Text = "---Subject---";
            txtSearch.Text = "";
            var listFilter = courseRepository.GetCoursesByUserId(LoginUser.UserId).Where(c => c.StartDate >= dtpFrom.Value.Date && c.EndDate <= dtpTo.Value.Date).ToList();
            try
            {
                BindingData(listFilter);
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
            var listSearch = courseRepository.GetCoursesByUserId(LoginUser.UserId).Where(c => c.CourseName.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
            try
            {
                BindingData(listSearch);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search course by name");
            }
        }

        private void btnViewGradeList_Click(object sender, EventArgs e)
        {
            if (btnViewGradeList.Text == "Back")
            {
                LoadEnrolledCourseList();
                btnViewGradeList.Text = "View Grade List";
                dtpFrom.Enabled = true;
                dtpTo.Enabled = true;
                cboStatus.Enabled = true;
                cboSubject.Enabled = true;
                txtSearch.Enabled = true;
            }
            else
            {
                dtpFrom.Enabled = false;
                dtpTo.Enabled = false;
                cboStatus.Enabled = false;
                cboSubject.Enabled = false;
                txtSearch.Enabled = false;
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
                                    CourseStatus = g.Course.Status.StatusName
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
            cboStatus.Text = "---Status---";
            txtSearch.Text = "";
            try
            {
                var subjectId = cboSubject.SelectedValue.ToString();
                var listSearch = courseRepository.GetCoursesByUserId(LoginUser.UserId).Where(c => c.SubjectId == int.Parse(subjectId)).ToList();
                BindingData(listSearch);
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
                cboSubject.Text = "---Subject---";
                txtSearch.Text = "";
                var statusId = cboStatus.SelectedValue.ToString();
                var listSearch = courseRepository.GetCoursesByUserId(LoginUser.UserId).Where(c => c.StatusId == int.Parse(statusId)).ToList();
                BindingData(listSearch);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Filter course by status");
            }
        }
        public void ClearText()
        {
            txtCourseId.Text = "";
            txtCourseName.Text = "";
            txtLecturer.Text = "";
            txtSubject.Text = "";
            txtStatus.Text = "";
        }

        private void btnGiveFeedback_Click(object sender, EventArgs e)
        {
            try
            {
                string feedBackContent = txtFeedback.Text;
                if (feedBackContent != "")
                {
                    if (txtStatus.Text=="Waiting")
                    {
                        MessageBox.Show("The course is not started! You can't give feedback", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadEnrolledCourseList();
                    }
                    else
                    {
                        Feedback feedBack = feedbackRepository.GetFeedbackByStudentAndCourse(LoginUser.UserId, int.Parse(txtCourseId.Text));
                        feedBack.FeedbackContent = feedBackContent;
                        feedbackRepository.UpdateFeedback(feedBack);
                        MessageBox.Show("Give feedback success!", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadEnrolledCourseList();
                    }
                }
                else
                {
                    MessageBox.Show("Please input your feedback !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Give feedback");
            }
        }

    }
}
