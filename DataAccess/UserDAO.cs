using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UserDAO
    {
        private static UserDAO instance = null;
        private static readonly object instanceLock = new object();
        public static UserDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<User> GetUserList()
        {
            var userList = new List<User>();
            try
            {
                using var context = new EnrollmentSystemContext();
                userList = context.Users.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return userList;
        }

        public User GetUserByID(string userId)
        {
            User user = null;
            try
            {
                using var context = new EnrollmentSystemContext();
                user = context.Users.SingleOrDefault(c => c.UserId == userId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return user;
        }

        public IEnumerable<User> GetLecturerList()
        {
            var lecturerList = new List<User>();
            try
            {
                using var context = new EnrollmentSystemContext();
                lecturerList = context.Users.Where(c => c.RoleId == 2).ToList();
                foreach (var lecturer in lecturerList)
                {
                    lecturer.Role = context.Roles.SingleOrDefault(s => s.RoleId == lecturer.RoleId);
                    lecturer.Status = context.StatusUsers.SingleOrDefault(s => s.StatusId == lecturer.StatusId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return lecturerList;
        }

        public void AddUser(User user)
        {
            try
            {
                var existUser = GetUserByID(user.UserId);
                if (existUser == null)
                {
                    using var context = new EnrollmentSystemContext();
                    context.Users.Add(user);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The user is already exist");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void UpdateUser(User user)
        {
            try
            {
                var userExist = GetUserByID(user.UserId);
                if (userExist != null)
                {
                    using var context = new EnrollmentSystemContext();
                    context.Users.Update(user);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The user does not already exist");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void RemoveUser(string userID)
        {
            try
            {
                var userExist = GetUserByID(userID);
                if (userExist != null)
                {
                    using var context = new EnrollmentSystemContext();
                    context.Users.Remove(userExist);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The user does not already exist");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<User> GetStudentList()
        {
            var studentList = new List<User>();
            try
            {
                using var context = new EnrollmentSystemContext();
                studentList = context.Users.Where(c => c.RoleId == 3).ToList();
                foreach (var student in studentList)
                {
                    student.Role = context.Roles.SingleOrDefault(s => s.RoleId == student.RoleId);
                    student.Status = context.StatusUsers.SingleOrDefault(s => s.StatusId == student.StatusId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return studentList;
        }

        public IEnumerable<User> GetStudentByCourse(int courseId)
        {
            var studentList = new List<User>();
            try
            {
                using var context = new EnrollmentSystemContext();
                studentList = (from s in context.Users
                               join g in context.Grades on s.UserId equals g.StudentId
                               where g.CourseId == courseId
                               select s).ToList();
                foreach (var student in studentList)
                {
                    student.Role = context.Roles.SingleOrDefault(c => c.RoleId == student.StatusId);
                    student.Status = context.StatusUsers.SingleOrDefault(c => c.StatusId == student.StatusId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return studentList;
        }
    }
}
