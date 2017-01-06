
using System;
using System.Collections.Generic;
using System.Linq;

namespace N2NSample.Business.Models
{
    public class StudentCourse
    {
        public string Id { get; set; }

        public string StudentId { get; set; }
        public Student Student { get; set; }

        public string CourseId { get; set; }
        public Course Course { get; set; }
    }
}