﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Courses = new HashSet<Course>();
        }

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
