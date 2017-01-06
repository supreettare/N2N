using Microsoft.WindowsAzure.MobileServices;
using N2NSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2NSample.Helper
{
    public sealed class ServiceHelperOnline
    {

        //MobileServiceClient client = new MobileServiceClient(Constants.ApplicationURL);
        MobileServiceClient MobileClient = new MobileServiceClient(Constants.ApplicationURL);

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

        public ServiceHelperOnline()
        {
            studentTable = MobileClient.GetTable<Student>();
            courseTable = MobileClient.GetTable<Course>();
            studentCourseTable = MobileClient.GetTable<StudentCourse>();
        }

        #region students 
        public async Task<bool> AddStudent(Student student)
        {
            TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
            try
            {
                await studentTable.InsertAsync(student).ContinueWith(t =>
                {
                    if (t.Status == TaskStatus.RanToCompletion)
                    {
                        tcs.SetResult(true);
                    }
                    if (t.Status == TaskStatus.Faulted)
                    {
                        tcs.SetResult(false);
                    }
                });
            }
            catch (Exception ex)
            {
                tcs.SetException(ex);
            }

            return tcs.Task.Result;
        }

        public async Task<bool> UpdateStudent(Student student)
        {
            TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
            try
            {
                await studentTable.UpdateAsync(student).ContinueWith(t =>
                {
                    if (t.Status == TaskStatus.RanToCompletion)
                    {
                        tcs.SetResult(true);
                    }
                    if (t.Status == TaskStatus.Faulted)
                    {
                        tcs.SetResult(false);
                    }
                });
            }
            catch (Exception ex)
            {
                tcs.SetException(ex);
            }

            return tcs.Task.Result;
        }

        public async Task<bool> DeleteStudent(Student student)
        {
            TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
            try
            {
                await studentTable.DeleteAsync(student).ContinueWith(t =>
                {
                    if (t.Status == TaskStatus.RanToCompletion)
                    {
                        tcs.SetResult(true);
                    }
                    if (t.Status == TaskStatus.Faulted)
                    {
                        tcs.SetResult(false);
                    }
                });
            }
            catch (Exception ex)
            {
                tcs.SetException(ex);
            }

            return tcs.Task.Result;
        }

        public async Task<List<Student>> GetStudents()
        {
            TaskCompletionSource<List<Student>> tcs = new TaskCompletionSource<List<Student>>();
            try
            {
                await studentTable.ToListAsync().ContinueWith(t =>
                {
                    if (t.Status == TaskStatus.RanToCompletion)
                    {
                        tcs.SetResult(t.Result);
                    }
                    if (t.Status == TaskStatus.Faulted)
                    {
                        tcs.SetException(t.Exception);
                    }
                });
            }
            catch (Exception ex)
            {
                tcs.SetException(ex);
            }

            return tcs.Task.Result;
        }
        #endregion

        #region Courses 
        public async Task<bool> AddCourse(Course course)
        {
            TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
            try
            {
                await courseTable.InsertAsync(course).ContinueWith(t =>
                {
                    if (t.Status == TaskStatus.RanToCompletion)
                    {
                        tcs.SetResult(true);
                    }
                    if (t.Status == TaskStatus.Faulted)
                    {
                        tcs.SetResult(false);
                    }
                });
            }
            catch (Exception ex)
            {
                tcs.SetException(ex);
            }

            return tcs.Task.Result;
        }

        public async Task<bool> UpdateCourse(Course course)
        {
            TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
            try
            {
                await courseTable.UpdateAsync(course).ContinueWith(t =>
                {
                    if (t.Status == TaskStatus.RanToCompletion)
                    {
                        tcs.SetResult(true);
                    }
                    if (t.Status == TaskStatus.Faulted)
                    {
                        tcs.SetResult(false);
                    }
                });
            }
            catch (Exception ex)
            {
                tcs.SetException(ex);
            }

            return tcs.Task.Result;
        }

        public async Task<bool> DeleteCourse(Course course)
        {
            TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
            try
            {
                await courseTable.DeleteAsync(course).ContinueWith(t =>
                {
                    if (t.Status == TaskStatus.RanToCompletion)
                    {
                        tcs.SetResult(true);
                    }
                    if (t.Status == TaskStatus.Faulted)
                    {
                        tcs.SetResult(false);
                    }
                });
            }
            catch (Exception ex)
            {
                tcs.SetException(ex);
            }

            return tcs.Task.Result;
        }

        public async Task<List<Course>> GetCourses()
        {
            TaskCompletionSource<List<Course>> tcs = new TaskCompletionSource<List<Course>>();
            try
            {
                await courseTable.ToListAsync().ContinueWith(t =>
                {
                    if (t.Status == TaskStatus.RanToCompletion)
                    {
                        tcs.SetResult(t.Result);
                    }
                    if (t.Status == TaskStatus.Faulted)
                    {
                        tcs.SetException(t.Exception);
                    }
                });
            }
            catch (Exception ex)
            {
                tcs.SetException(ex);
            }

            return tcs.Task.Result;
        }
        #endregion

        #region studentCourses 
        public async Task<bool> AddstudentCourse(StudentCourse studentCourse)
        {
            TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
            try
            {
                await studentCourseTable.InsertAsync(studentCourse).ContinueWith(t =>
                {
                    if (t.Status == TaskStatus.RanToCompletion)
                    {
                        tcs.SetResult(true);
                    }
                    if (t.Status == TaskStatus.Faulted)
                    {
                        tcs.SetResult(false);
                    }
                });
            }
            catch (Exception ex)
            {
                tcs.SetException(ex);
            }

            return tcs.Task.Result;
        }

        public async Task<bool> UpdatestudentCourse(StudentCourse studentCourse)
        {
            TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
            try
            {
                await studentCourseTable.UpdateAsync(studentCourse).ContinueWith(t =>
                {
                    if (t.Status == TaskStatus.RanToCompletion)
                    {
                        tcs.SetResult(true);
                    }
                    if (t.Status == TaskStatus.Faulted)
                    {
                        tcs.SetResult(false);
                    }
                });
            }
            catch (Exception ex)
            {
                tcs.SetException(ex);
            }

            return tcs.Task.Result;
        }

        public async Task<bool> DeletestudentCourse(StudentCourse studentCourse)
        {
            TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
            try
            {
                await studentCourseTable.DeleteAsync(studentCourse).ContinueWith(t =>
                {
                    if (t.Status == TaskStatus.RanToCompletion)
                    {
                        tcs.SetResult(true);
                    }
                    if (t.Status == TaskStatus.Faulted)
                    {
                        tcs.SetResult(false);
                    }
                });
            }
            catch (Exception ex)
            {
                tcs.SetException(ex);
            }

            return tcs.Task.Result;
        }

        public async Task<List<StudentCourse>> GetstudentCourses()
        {
            TaskCompletionSource<List<StudentCourse>> tcs = new TaskCompletionSource<List<StudentCourse>>();
            try
            {
                await studentCourseTable.ToListAsync().ContinueWith(t =>
                {
                    if (t.Status == TaskStatus.RanToCompletion)
                    {
                        tcs.SetResult(t.Result);
                    }
                    if (t.Status == TaskStatus.Faulted)
                    {
                        tcs.SetException(t.Exception);
                    }
                });
            }
            catch (Exception ex)
            {
                tcs.SetException(ex);
            }

            return tcs.Task.Result;
        }
        #endregion

    }
}
