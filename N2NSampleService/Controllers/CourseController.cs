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
    public class CourseController : TableController<Course>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            N2NSampleContext context = new N2NSampleContext();
            DomainManager = new EntityDomainManager<Course>(context, Request);
        }

        // GET tables/Course
        public IQueryable<Course> GetAllCourses()
        {
            return Query();
        }

        // GET tables/Course/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Course> GetCourse(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Course/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Course> PatchCourse(string id, Delta<Course> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/Course
        public async Task<IHttpActionResult> PostCourse(Course item)
        {
            Course current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Course/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteCourse(string id)
        {
            return DeleteAsync(id);
        }
    }
}