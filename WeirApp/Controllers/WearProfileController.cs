using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WeirApp.Models;

namespace WeirApp.Controllers
{
    [Authorize]
    public class WearProfileController : ApiController
    {
        private WeirServiceContext db = new WeirServiceContext();

        // GET: api/Authors
        public IQueryable<WearProfileDTO> GetProfiles()
        {
            var profiles = from b in db.WearProfiles
                          select new WearProfileDTO()
                          {
                              Id = b.Id,
                              Name = b.Name,
                              Collaterals = b.Collaterals
                          };

            return profiles;
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Exists(int id)
        {
            return db.Customers.Count(e => e.Id == id) > 0;
        }

        
    }
}