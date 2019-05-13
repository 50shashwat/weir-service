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
    //[Authorize]
    public class MeasurementController : ApiController
    {
        private WeirServiceContext db = new WeirServiceContext();

        // GET: api/Authors
        [HttpGet]
        public IQueryable<MeasurementDTO> List()
        {
            var requests = from b in db.Measurements
                           select new MeasurementDTO()
                           {
                               Id = b.Id,
                               MeasurementLocation1 = b.MeasurementLocation1,
                               MeasurementLocation2 = b.MeasurementLocation2,
                               MeasurementLocation3 = b.MeasurementLocation3,
                               MeasurementLocation4 = b.MeasurementLocation4,
                               UpdatedDate = b.UpdatedDate,
                               UpdatedTime = b.UpdatedTime,
                               UserId = b.UserId
                           };

            return requests;
        }


        // PUT: api/Authors/5
        [ResponseType(typeof(void))]
        [HttpPut]
        public async Task<IHttpActionResult> Update(int id, Measurement request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != request.Id)
            {
                return BadRequest();
            }

            db.Entry(request).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Exists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Authors
        [ResponseType(typeof(ServiceRequest))]
        [HttpPost]
        public async Task<IHttpActionResult> Create(Measurement request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Measurements.Add(request);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = request.Id }, request);
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
            return db.Measurements.Count(e => e.Id == id) > 0;
        }

        
    }
}