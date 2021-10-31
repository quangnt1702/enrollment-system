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
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
        Course GetCourseByID(int courseId);
        void DeleteCourse(int courseId);
        void InsertCourse(Course course);
        void UpdateCourse(Course course);
    }
}
