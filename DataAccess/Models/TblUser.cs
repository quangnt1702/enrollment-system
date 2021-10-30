using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class TblUser
    {
        public TblUser()
        {
            TblCourses = new HashSet<TblCourse>();
            TblFeedbacks = new HashSet<TblFeedback>();
            TblGrades = new HashSet<TblGrade>();
        }

        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string RoleId { get; set; }
        public string StatusId { get; set; }

        public virtual TblRole Role { get; set; }
        public virtual TblStatusUser Status { get; set; }
        public virtual ICollection<TblCourse> TblCourses { get; set; }
        public virtual ICollection<TblFeedback> TblFeedbacks { get; set; }
        public virtual ICollection<TblGrade> TblGrades { get; set; }
    }
}
