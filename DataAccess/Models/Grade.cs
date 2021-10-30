using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class Grade
    {
        public int GradeId { get; set; }
        public int CourseId { get; set; }
        public string StudentId { get; set; }
        public double? ProgressTest { get; set; }
        public double? MidTermTest { get; set; }
        public double? PracticalTest { get; set; }
        public double? FinalTest { get; set; }

        public virtual Course Course { get; set; }
        public virtual User Student { get; set; }
    }
}
