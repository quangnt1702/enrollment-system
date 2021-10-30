using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class TblStatusCourse
    {
        public TblStatusCourse()
        {
            TblCourses = new HashSet<TblCourse>();
        }

        public string StatusId { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<TblCourse> TblCourses { get; set; }
    }
}
