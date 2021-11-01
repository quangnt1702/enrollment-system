using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IFeedbackRepository
    {
        IEnumerable<Feedback> GetAllFeedback();
        Feedback GetFeedbackById(int feedbackID);
        void AddFeedback(Feedback feedback);
        void UpdateFeedbach(Feedback feedback);
        void RemoveFeedback(int feedbackID);
        IEnumerable<Feedback> GetFeedbachByCourse(int courseID);
    }
}
