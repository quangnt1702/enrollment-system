using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class Course
    {
        public Course()
        {
            Feedbacks = new HashSet<Feedback>();
            Grades = new HashSet<Grade>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int SubjectId { get; set; }
        public string LecturerId { get; set; }
        public int? StudentQuantity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int StatusId { get; set; }

        public virtual User Lecturer { get; set; }
        public virtual StatusCourse Status { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
    }
}
