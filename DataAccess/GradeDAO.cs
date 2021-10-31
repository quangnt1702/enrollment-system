using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess
{
    class GradeDAO
    {
        private static GradeDAO instance = null;
        private static readonly object instanceLock = new object();
        private GradeDAO()
        {
        }
        public static GradeDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance==null)
                    {
                        instance = new GradeDAO();
                    }
                    return instance;
                }
            }
        }
        public void AddNew(Grade grade)
        {
            try
            {
                using var context = new EnrollmentSystemContext();
                context.Grades.Add(grade);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IEnumerable<Grade> GetGradeOfStudent(string studentId,int courseId)
        {
            var grade = new List<Grade>();
            try
            {
                using var context = new EnrollmentSystemContext();
                grade = context.Grades.Where(g => g.CourseId == courseId && g.StudentId == studentId).ToList();
                foreach (var g in grade)
                {
                    g.Course = context.Courses.SingleOrDefault(c => c.CourseId == courseId);
                    g.Course.Status = context.StatusCourses.SingleOrDefault(c => c.StatusId == g.Course.StatusId);
                    g.Student = context.Users.SingleOrDefault(s => s.UserId == studentId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return grade;
        }

    }
}
