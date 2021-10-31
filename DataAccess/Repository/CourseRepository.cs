<<<<<<< HEAD
﻿using System.Collections.Generic;
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> 94a9d563f39b7ed540aac503fef6edc91f0684a7
using DataAccess.Models;

namespace DataAccess.Repository
{
    public class CourseRepository : ICourseRepository
    {
        public void DeleteCourse(int courseId) => CourseDAO.Instance.Remove(courseId);

        public Course GetCourseByID(int courseId) => CourseDAO.Instance.GetCourseByID(courseId);

        public IEnumerable<Course> GetCourses() => CourseDAO.Instance.GetCourseList();

        public void InsertCourse(Course course) => CourseDAO.Instance.AddNew(course);

        public void UpdateCourse(Course course) => CourseDAO.Instance.Update(course);
    }
}
