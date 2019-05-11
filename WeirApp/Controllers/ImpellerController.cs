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
    public class ImpellerController : ApiController
    {
        private WeirServiceContext db = new WeirServiceContext();

        // GET: api/Authors
        public IQueryable<ImpellerDTO> GetImpellerss()
        {
            var impellers = from b in db.Impellers
                            select new ImpellerDTO()
                            {
                                Id = b.Id,
                                Name = b.Name
                            };

            return impellers;
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