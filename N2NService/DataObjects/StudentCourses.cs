using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace N2NService.DataObjects
{
    public class StudentCourses : EntityData
    {
        public string StudentId { get; set; }

        public Student Student { get; set; }

        public string CourseId { get; set; }

        public Course Course { get; set; }
    }
}