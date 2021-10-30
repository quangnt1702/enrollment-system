using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class Feedback
    {
        public int FeedbackId { get; set; }
        public int CourseId { get; set; }
        public string StudentId { get; set; }
        public string FeedbackContent { get; set; }

        public virtual Course Course { get; set; }
        public virtual User Student { get; set; }
    }
}
