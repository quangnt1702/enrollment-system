using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess
{
     public class SubjectDAO
    {
        private static SubjectDAO instance = null;
        private static readonly object instanceLock = new object();
        private SubjectDAO()
        {

        }
        public static SubjectDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new SubjectDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Subject> GetSubjectList()
        {
            var subjectList = new List<Subject>();
            try
            {
                using var context = new EnrollmentSystemContext();
                subjectList = context.Subjects.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return subjectList;
        }

        public int GetNumberCourseBySubject(int subjectId)
        {
            int count = 0;
            try
            {
                using var context = new EnrollmentSystemContext();
                count = context.Courses.Where(c => c.SubjectId == subjectId).ToList().Count;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return count;
        }

        public void AddSubject(Subject subject)
        {
            try
            {
                using var context = new EnrollmentSystemContext();
                context.Subjects.Add(subject);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
