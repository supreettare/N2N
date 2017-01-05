using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using N2NSample.Service.DataObjects;
using N2NSample.Service.Models;

namespace N2NSample.Service.Controllers
{
    public class StudentCourseController : TableController<StudentCourse>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            N2NSampleContext context = new N2NSampleContext();
            DomainManager = new EntityDomainManager<StudentCourse>(context, Request);
        }

        // GET tables/StudentCourse
        public IQueryable<StudentCourse> GetAllStudentCourses()
        {
            return Query();
        }

        // GET tables/StudentCourse/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<StudentCourse> GetStudentCourse(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/StudentCourse/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<StudentCourse> PatchStudentCourse(string id, Delta<StudentCourse> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/StudentCourse
        public async Task<IHttpActionResult> PostStudentCourse(StudentCourse item)
        {
            StudentCourse current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/StudentCourse/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteStudentCourse(string id)
        {
            return DeleteAsync(id);
        }
    }
}