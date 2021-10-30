using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class TblGrade
    {
        public string GradeId { get; set; }
        public string CourseId { get; set; }
        public string StudentId { get; set; }
        public double? ProgressTest { get; set; }
        public double? MidTermTest { get; set; }
        public string PracticalTest { get; set; }
        public double? FinalTest { get; set; }

        public virtual TblCourse Course { get; set; }
        public virtual TblUser Student { get; set; }
    }
}
