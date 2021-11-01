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

        public IEnumerable<Feedback> GetFeedbachByCourse(int courseID) => FeedbackDAO.Instance.GetFeedbachByCourse(courseID);

        public Feedback GetFeedbackById(int feedbackID) => FeedbackDAO.Instance.GetFeedbackById(feedbackID);

        public void RemoveFeedback(int feedbackID) => FeedbackDAO.Instance.RemoveFeedback(feedbackID);

        public void UpdateFeedbach(Feedback feedback) => FeedbackDAO.Instance.UpdateFeedbach(feedback);
    }
}
