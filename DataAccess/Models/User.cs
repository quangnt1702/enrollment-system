using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class User
    {
        public User()
        {
            Courses = new HashSet<Course>();
            Feedbacks = new HashSet<Feedback>();
            Grades = new HashSet<Grade>();
        }

        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public int StatusId { get; set; }

        public virtual Role Role { get; set; }
        public virtual StatusUser Status { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
    }
}
