using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using N2NService.DataObjects;
using N2NService.Models;

namespace N2NService.Controllers
{
    public class StudentCoursesController : TableController<StudentCourses>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            N2NContext context = new N2NContext();
            DomainManager = new EntityDomainManager<StudentCourses>(context, Request);
        }

        // GET tables/StudentCourses
        public IQueryable<StudentCourses> GetAllStudentCoursess()
        {
            return Query();
        }

        // GET tables/StudentCourses/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<StudentCourses> GetStudentCourses(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/StudentCourses/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<StudentCourses> PatchStudentCourses(string id, Delta<StudentCourses> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/StudentCourses
        public async Task<IHttpActionResult> PostStudentCourses(StudentCourses item)
        {
            StudentCourses current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/StudentCourses/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteStudentCourses(string id)
        {
            return DeleteAsync(id);
        }
    }
}