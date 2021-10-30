using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class TblSubject
    {
        public TblSubject()
        {
            TblCourses = new HashSet<TblCourse>();
        }

        public string SubjectId { get; set; }
        public string SubjectName { get; set; }

        public virtual ICollection<TblCourse> TblCourses { get; set; }
    }
}
