using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Models;

namespace DataAccess
{
    class CourseDAO
    {
        private static CourseDAO instance = null;
        private static readonly object instanceLock = new object();
        private CourseDAO()
        {

        }
        public static CourseDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CourseDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Course> GetCourseList()
        {
            var courseList = new List<Course>();
            try
            {
                using var context = new EnrollmentSystemContext();
                courseList = context.Courses.ToList();
                foreach (var course in courseList)
                {
                    course.Subject = context.Subjects.SingleOrDefault(s => s.SubjectId == course.SubjectId);
                    course.Status= context.StatusCourses.SingleOrDefault(s => s.StatusId == course.StatusId);
                    course.Lecturer = context.Users.SingleOrDefault(s => s.UserId == course.LecturerId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return courseList;
        }
        public IEnumerable<Course> GetCourseListOfStudent(string studentId)
        {
            var courseList = new List<Course>();
            try
            {
                using var context = new EnrollmentSystemContext();
                courseList = (from c in context.Courses
                              join g in context.Grades on c.CourseId equals g.CourseId
                              where g.StudentId == studentId
                              select c).ToList();
                foreach (var course in courseList)
                {
                    course.Subject = context.Subjects.SingleOrDefault(s => s.SubjectId == course.SubjectId);
                    course.Status = context.StatusCourses.SingleOrDefault(s => s.StatusId == course.StatusId);
                    course.Lecturer = context.Users.SingleOrDefault(s => s.UserId == course.LecturerId);
                    course.Feedbacks = context.Feedbacks.Where(f => f.CourseId == course.CourseId).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return courseList;
        }
        public IEnumerable<Course> GetCourseListOfLecturer(string LecturerID)
        {
            var courseList = new List<Course>();
            try
            {
                using var context = new EnrollmentSystemContext();
                courseList = context.Courses.Where(c => c.LecturerId == LecturerID).ToList();
                foreach (var course in courseList)
                {
                    course.Subject = context.Subjects.SingleOrDefault(s => s.SubjectId == course.SubjectId);
                    course.Status = context.StatusCourses.SingleOrDefault(s => s.StatusId == course.StatusId);
                    course.Lecturer = context.Users.SingleOrDefault(s => s.UserId == course.LecturerId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return courseList;
        }
        public int GetNumberStudent(int courseId)
        {
            var courseList = new List<Course>();
            try
            {
                using var context = new EnrollmentSystemContext();
                courseList = (from c in context.Courses
                              join g in context.Grades on c.CourseId equals g.CourseId
                              where c.CourseId == courseId
                              select c).ToList();
              
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return courseList.Count;
        }
        public Course GetCourseByID(int courseId)
        {
            Course course = null;
            try
            {
                using var context = new EnrollmentSystemContext();
                course = context.Courses.SingleOrDefault(c => c.CourseId == courseId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return course;
        }

        public void AddNew(Course course)
        {
            try
            {
                //var c = GetCourseByID(course.CourseId);
                //if (c==null)
                //{
                using var context = new EnrollmentSystemContext();
                context.Courses.Add(course);
                context.SaveChanges();
                //}
                //else
                //{
                //    throw new Exception("The course is already exist.");
                //}

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Course course)
        {
            try
            {
                var c = GetCourseByID(course.CourseId);
                if (c != null)
                {
                    using var context = new EnrollmentSystemContext();
                    context.Courses.Update(course);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The course does not already exist.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Remove(int courseId)
        {
            try
            {
                var course = GetCourseByID(courseId);
                if (course != null)
                {
                    using var context = new EnrollmentSystemContext();
                    context.Courses.Remove(course);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The course does not already exist.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Course> GetCourseByStatus(int statusID)
        {
            var courseList = new List<Course>();
            try
            {
                using var context = new EnrollmentSystemContext();
                courseList = context.Courses.Where(c => c.StatusId == statusID).ToList();
                foreach (var course in courseList)
                {
                    course.Subject = context.Subjects.SingleOrDefault(s => s.SubjectId == course.SubjectId);
                    course.Status = context.StatusCourses.SingleOrDefault(s => s.StatusId == course.StatusId);
                    course.Lecturer = context.Users.SingleOrDefault(s => s.UserId == course.LecturerId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return courseList;
        }

        public IEnumerable<Course> GetCourseBySubject(int subjectID)
        {
            var courseList = new List<Course>();
            try
            {
                using var context = new EnrollmentSystemContext();
                courseList = context.Courses.Where(c => c.SubjectId == subjectID).ToList();
                foreach (var course in courseList)
                {
                    course.Subject = context.Subjects.SingleOrDefault(s => s.SubjectId == course.SubjectId);
                    course.Status = context.StatusCourses.SingleOrDefault(s => s.StatusId == course.StatusId);
                    course.Lecturer = context.Users.SingleOrDefault(s => s.UserId == course.LecturerId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return courseList;
        }

        public void CheckStatusCourse()
        {
            DateTime now = DateTime.Now;
            var listCourse = GetCourseList();
            foreach (var c in listCourse)
            {
                if (c.StartDate <= now.Date && c.EndDate >= now.Date)
                {
                    var course = new Course
                    {
                        CourseId = c.CourseId,
                        CourseName = c.CourseName,
                        SubjectId = c.SubjectId,
                        LecturerId = c.LecturerId,
                        StudentQuantity = c.StudentQuantity,
                        StartDate = c.StartDate,
                        EndDate = c.EndDate,
                        StatusId = 1
                    };
                    Update(course);
                }
                else if (c.StartDate > now.Date)
                {
                    var course = new Course
                    {
                        CourseId = c.CourseId,
                        CourseName = c.CourseName,
                        SubjectId = c.SubjectId,
                        LecturerId = c.LecturerId,
                        StudentQuantity = c.StudentQuantity,
                        StartDate = c.StartDate,
                        EndDate = c.EndDate,
                        StatusId = 3
                    };
                    Update(course);
                }
                else if (c.EndDate < now.Date)
                {
                    var course = new Course
                    {
                        CourseId = c.CourseId,
                        CourseName = c.CourseName,
                        SubjectId = c.SubjectId,
                        LecturerId = c.LecturerId,
                        StudentQuantity = c.StudentQuantity,
                        StartDate = c.StartDate,
                        EndDate = c.EndDate,
                        StatusId = 2
                    };
                    Update(course);
                }
            }
        }
        public IEnumerable<Course> GetCourseByStatusAndID(int statusID, string UserID)
        {
            var courseList = new List<Course>();
            try
            {
                using var context = new EnrollmentSystemContext();
                courseList = context.Courses.Where(c => c.StatusId == statusID && c.LecturerId == UserID).ToList();
                foreach (var course in courseList)
                {
                    course.Subject = context.Subjects.SingleOrDefault(s => s.SubjectId == course.SubjectId);
                    course.Status = context.StatusCourses.SingleOrDefault(s => s.StatusId == course.StatusId);
                    course.Lecturer = context.Users.SingleOrDefault(s => s.UserId == course.LecturerId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return courseList;
        }
    }
}
