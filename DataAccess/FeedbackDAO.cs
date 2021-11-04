using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class FeedbackDAO
    {
        private static FeedbackDAO instance = null;
        private static readonly object instanceLock = new object();
        public static FeedbackDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new FeedbackDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Feedback> GetAllFeedback()
        {
            var listFeedback = new List<Feedback>();
            try
            {
                using var context = new EnrollmentSystemContext();
                listFeedback = context.Feedbacks.ToList();
                foreach (var feedback in listFeedback)
                {
                    feedback.Course = context.Courses.SingleOrDefault(c => c.CourseId == feedback.CourseId);
                    feedback.Student = context.Users.SingleOrDefault(c => c.UserId == feedback.StudentId);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return listFeedback;
        }

        public Feedback GetFeedbackById(int feedbackID)
        {
            Feedback feedback = null;
            try
            {
                using var context = new EnrollmentSystemContext();
                feedback = context.Feedbacks.SingleOrDefault(c => c.FeedbackId == feedbackID);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return feedback;
        }

        public void AddFeedback(Feedback feedback)
        {
            try
            {
                var feedbackExist = GetFeedbackById(feedback.FeedbackId);
                if (feedbackExist == null)
                {
                    using var context = new EnrollmentSystemContext();
                    context.Feedbacks.Add(feedback);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Feedback is already exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void UpdateFeedback(Feedback feedback)
        {
            try
            {
                var feedbackExist = GetFeedbackById(feedback.FeedbackId);
                if (feedbackExist != null)
                {
                    using var context = new EnrollmentSystemContext();
                    context.Feedbacks.Update(feedback);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Feedback does not already exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void RemoveFeedback(int feedbackID)
        {
            try
            {
                var feedbackExist = GetFeedbackById(feedbackID);
                if (feedbackExist != null)
                {
                    using var context = new EnrollmentSystemContext();
                    context.Feedbacks.Remove(feedbackExist);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Feedback does not already exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Feedback> GetFeedbackByCourse(int courseID)
        {
            var feedbackList = new List<Feedback>();
            try
            {
                using var context = new EnrollmentSystemContext();
                feedbackList = context.Feedbacks.Where(c => c.CourseId == courseID).ToList();
                foreach (var feedback in feedbackList)
                {
                    feedback.Course = context.Courses.SingleOrDefault(c => c.CourseId == feedback.CourseId);
                    feedback.Student = context.Users.SingleOrDefault(c => c.UserId == feedback.StudentId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return feedbackList;
        }

        public Feedback GetFeedbackByStudentAndCourse(string studentId, int courseID)
        {
            Feedback feedback = null;
            try
            {
                using var context = new EnrollmentSystemContext();
                feedback = context.Feedbacks.SingleOrDefault(c => c.StudentId == studentId && c.CourseId == courseID);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return feedback;
        }
    }
}
