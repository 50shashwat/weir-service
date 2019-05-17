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
    public class SWTMappingController : ApiController
    {
        private WeirServiceContext db = new WeirServiceContext();

        // GET: api/Books
        [HttpGet]
        public IQueryable<SlurryWearTypeMapping> SWTMapping()
        {
            return db.SlurryWearTypeMapping.AsQueryable<SlurryWearTypeMapping>();
        }
    }
}
