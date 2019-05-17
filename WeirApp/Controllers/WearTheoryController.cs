using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WeirApp.Models;

namespace WeirApp.Controllers
{
    //[Authorize]
    public class WearTheoryController : ApiController
    {
        private WeirServiceContext db = new WeirServiceContext();

        // GET: api/Books
        [HttpGet]
        public IQueryable<WearTheory> WearTheories()
        {
            return db.WearTheory.AsQueryable<WearTheory>();
        }

        [ResponseType(typeof(WearTheory))]
        public async Task<IHttpActionResult> PostWearTheory(WearTheory request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.WearTheory.Add(request);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = request.Id }, request);
        }
    }
}
