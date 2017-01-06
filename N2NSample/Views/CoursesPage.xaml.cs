using N2NSample.Helper;
using N2NSample.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace N2NSample.Views
{
    public partial class CoursesPage : ContentPage
    {
        private ObservableCollection<StudentCourse> courses;

        public ObservableCollection<StudentCourse> Courses
        {
            get { return courses; }
            set { courses = value;
                OnPropertyChanged(); 
            }
        }

        public CoursesPage(string _selectedStudentId )
        {
            InitializeComponent();
            GetCourses(_selectedStudentId);
            this.BindingContext = this; 
        }

        private async void GetCourses(string _selectedStudentId)
        {
            Courses = new ObservableCollection<StudentCourse>(await ServiceHelperOnline.Instance.GetstudentCourses(_selectedStudentId)); 
        }
    }
}
