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
        BindingSource source;
        public frmAdminFeedbacks()
        {
            InitializeComponent();
        }

        private void frmAdminFeedbacks_Load(object sender, EventArgs e)
        {
            var context = new EnrollmentSystemContext();
            var course = context.Courses.ToList();
            cbCourse.DisplayMember = "CourseName";
            cbCourse.ValueMember = "CourseId";
            cbCourse.DataSource = course;
            LoadFeedbackList();
        }

        public void LoadFeedbackList()
        {
            var feedbacks = feedbackRepository.GetAllFeedback();
            var list = (from c in feedbacks
                        select new
                        {
                            FeedbackID = c.FeedbackId,
                            CourseId = c.Course.CourseName,
                            StudentId = c.Student.UserName,
                            FeedbackContent = c.FeedbackContent
                        }).ToList();
            try
            {
                source = new BindingSource();
                source.DataSource = list;

                txtUserID.DataBindings.Clear();

                txtUserID.DataBindings.Add("Text", source, "FeedbackID");

                dgvFeedbacks.DataSource = null;
                dgvFeedbacks.DataSource = source;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Load feedback list");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int feedbackID = int.Parse(txtUserID.Text);
                if (MessageBox.Show("Do you want to delete?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    feedbackRepository.RemoveFeedback(feedbackID);
                    LoadFeedbackList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Student");
            }
        }

        private void cbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int course = (int)cbCourse.SelectedValue;
            LoadFeedbackByCourse(course);
        }

        public void LoadFeedbackByCourse(int courseID)
        {
            var feedbacks = feedbackRepository.GetFeedbachByCourse(courseID);
            var list = (from c in feedbacks
                        select new
                        {
                            FeedbackID = c.FeedbackId,
                            //CourseId = c.Course.CourseName,
                            CourseID = c.CourseId,
                            //StudentId = c.Student.UserName,
                            StudentID = c.StudentId,
                            FeedbackContent = c.FeedbackContent
                        }).ToList();
            try
            {
                source = new BindingSource();
                source.DataSource = list;

                txtUserID.DataBindings.Clear();

                txtUserID.DataBindings.Add("Text", source, "FeedbackID");

                dgvFeedbacks.DataSource = null;
                dgvFeedbacks.DataSource = source;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Load feedback list");
            }
        }
    }
}
