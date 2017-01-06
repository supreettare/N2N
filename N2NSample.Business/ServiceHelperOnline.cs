using Microsoft.WindowsAzure.MobileServices;
using N2NSample.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace N2NSample.Business
{
    public sealed class ServiceHelperOnline
    {
        static readonly ServiceHelperOnline _instance = new ServiceHelperOnline();
        public static ServiceHelperOnline Instance
        {
            get
            {
                return _instance;
            }
        }

        private IMobileServiceTable<Student> studentTable;
        private IMobileServiceTable<Course> courseTable;
        private IMobileServiceTable<StudentCourse> studentCourseTable;
    }
}
