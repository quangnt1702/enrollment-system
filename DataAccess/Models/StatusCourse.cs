using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class StatusCourse
    {
        public StatusCourse()
        {
            Courses = new HashSet<Course>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
