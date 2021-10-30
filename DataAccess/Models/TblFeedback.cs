using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class TblFeedback
    {
        public int FeedbackId { get; set; }
        public string CourseId { get; set; }
        public string StudentId { get; set; }
        public string FeedbackContent { get; set; }

        public virtual TblCourse Course { get; set; }
        public virtual TblUser Student { get; set; }
    }
}
