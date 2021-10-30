using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CourseDAO
    {
        private static CourseDAO instance = null;
        private static readonly object instanceLock = new object();
        public static CourseDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if(instance == null)
                    {
                        instance = new CourseDAO();
                    }
                    return instance;
                }
            }
        }

        public List<TblCourse> GetAllCourse()
        {
            try
            {
                using var context = new EnrollmentSystemContext();
                var courseList = context.TblCourses.ToList();
                return courseList;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
