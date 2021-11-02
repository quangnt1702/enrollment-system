using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess
{
    public class StatusCourseDAO
    {
        private static StatusCourseDAO instance = null;
        private static readonly object instanceLock = new object();
        private StatusCourseDAO()
        {

        }
        public static StatusCourseDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new StatusCourseDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<StatusCourse> GetStatusCourseList()
        {
            var statusCourseList = new List<StatusCourse>();
            try
            {
                using var context = new EnrollmentSystemContext();
                statusCourseList = context.StatusCourses.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return statusCourseList;
        }
    }
}
