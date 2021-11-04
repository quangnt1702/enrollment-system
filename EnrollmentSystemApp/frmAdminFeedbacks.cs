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
    public partial class frmAdminFeedbacks : Form
    {
        public User LoginUser { get; set; }
        IFeedbackRepository feedbackRepository = new FeedbackRepository();
        ICourseRepository courseRepository = new CourseRepository();
        BindingSource source;
        public frmAdminFeedbacks()
        {
            InitializeComponent();
        }

        private void frmAdminFeedbacks_Load(object sender, EventArgs e)
        {
            LoadCourseList();
        }

        public void LoadCourseList()
        {
            var courses = courseRepository.GetCourses();
            var list = (from c in courses
                        select new
                        {
                            ID = c.CourseId,
                            CourseName = c.CourseName,
                            Subject = c.Subject.SubjectName,
                            Lecturer = c.Lecturer.UserName,
                            StudentQuantity = c.StudentQuantity,
                            StartDate = c.StartDate,
                            EndDate = c.EndDate,
                            Status = c.Status.StatusName
                        }).ToList();
            try
            {
                source = new BindingSource();
                source.DataSource = list;

                txtCourseID.DataBindings.Clear();

                txtCourseID.DataBindings.Add("Text", source, "ID");

                dgvFeedbacks.DataSource = null;
                dgvFeedbacks.DataSource = source;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Load course list");
            }
        }

        public void LoadFeedbackByCourse(int courseID)
        {
            try
            {
                var feedbacks = feedbackRepository.GetFeedbackByCourse(courseID);
                if(feedbacks != null)
                {
                    var list = (from c in feedbacks
                                select new
                                {
                                    FeedbackID = c.FeedbackId,
                                    CourseId = c.Course.CourseName,
                                    StudentId = c.Student.UserName,
                                    FeedbackContent = c.FeedbackContent
                                }).ToList();
                    source = new BindingSource();
                    source.DataSource = list;

                    txtCourseID.DataBindings.Clear();

                    txtCourseID.DataBindings.Add("Text", source, "FeedbackID");

                    dgvFeedbacks.DataSource = null;
                    dgvFeedbacks.DataSource = source;
                }
                else
                {
                    MessageBox.Show("This course has no feedback", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCourseList();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Load feedback list");
            }
        }

        private void btnViewFeedback_Click(object sender, EventArgs e)
        {
            if (btnViewFeedback.Text == "Back")
            {
                LoadCourseList();
                btnViewFeedback.Text = "View Feedbacks";
                lbCourse.Text = "Courses";
            }
            else
            {
                int course = int.Parse(txtCourseID.Text);
                LoadFeedbackByCourse(course);
                btnViewFeedback.Text = "Back";
                lbCourse.Text = "Feedbacks";
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (btnViewFeedback.Text == "View Feedbacks")
            {
                var listSearch = courseRepository.GetCourses().Where(c => c.CourseName.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
                try
                {
                    var list = (from c in listSearch
                                select new
                                {
                                    ID = c.CourseId,
                                    CourseName = c.CourseName,
                                    Subject = c.Subject.SubjectName,
                                    Lecturer = c.Lecturer.UserName,
                                    StudentQuantity = c.StudentQuantity,
                                    StartDate = c.StartDate,
                                    EndDate = c.EndDate,
                                    Status = c.Status.StatusName
                                }).ToList();
                    source = new BindingSource();
                    source.DataSource = list;


                    txtCourseID.DataBindings.Clear();

                    txtCourseID.DataBindings.Add("Text", source, "ID");

                    dgvFeedbacks.DataSource = null;
                    dgvFeedbacks.DataSource = source;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load course list");
                }
            }
        }
    }
}
