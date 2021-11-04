using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class FeedbackRepository : IFeedbackRepository
    {
        public void AddFeedback(Feedback feedback) => FeedbackDAO.Instance.AddFeedback(feedback);

        public IEnumerable<Feedback> GetAllFeedback() => FeedbackDAO.Instance.GetAllFeedback();

        public IEnumerable<Feedback> GetFeedbackByCourse(int courseID) => FeedbackDAO.Instance.GetFeedbackByCourse(courseID);

        public Feedback GetFeedbackById(int feedbackID) => FeedbackDAO.Instance.GetFeedbackById(feedbackID);

        public Feedback GetFeedbackByStudentAndCourse(string studentId, int courseID)
        {
            return FeedbackDAO.Instance.GetFeedbackByStudentAndCourse(studentId, courseID);
        }

        public void RemoveFeedback(int feedbackID) => FeedbackDAO.Instance.RemoveFeedback(feedbackID);

        public void UpdateFeedback(Feedback feedback) => FeedbackDAO.Instance.UpdateFeedback(feedback);
    }
}
