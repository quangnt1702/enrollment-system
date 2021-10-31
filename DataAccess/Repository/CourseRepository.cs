using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess.Repository
{
    public class CourseRepository : ICourseRepository
    {
        public void DeleteCourse(int courseId) => CourseDAO.Instance.Remove(courseId);

        public Course GetCourseByID(int courseId) => CourseDAO.Instance.GetCourseByID(courseId);

        public IEnumerable<Course> GetCourses() => CourseDAO.Instance.GetCourseList();

        public IEnumerable<Course> GetCoursesByUserId(string userId) => CourseDAO.Instance.GetCourseListOfStudent(userId);

        public int GetNumberStudent(int courseId) => CourseDAO.Instance.GetNumberStudent(courseId);
        
        public void InsertCourse(Course course) => CourseDAO.Instance.AddNew(course);

        public void UpdateCourse(Course course) => CourseDAO.Instance.Update(course);
    }
}
