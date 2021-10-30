using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class TblCourse
    {
        public TblCourse()
        {
            TblFeedbacks = new HashSet<TblFeedback>();
            TblGrades = new HashSet<TblGrade>();
        }

        public string CourseId { get; set; }
        public string CoursetName { get; set; }
        public string SubjectId { get; set; }
        public string LecturerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? StudentQuantity { get; set; }
        public string StatusId { get; set; }

        public virtual TblUser Lecturer { get; set; }
        public virtual TblStatusCourse Status { get; set; }
        public virtual TblSubject Subject { get; set; }
        public virtual ICollection<TblFeedback> TblFeedbacks { get; set; }
        public virtual ICollection<TblGrade> TblGrades { get; set; }
    }
}
