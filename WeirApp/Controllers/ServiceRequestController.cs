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
    public class ServiceRequestController : ApiController
    {
        private WeirServiceContext db = new WeirServiceContext();

        // GET: api/Authors
        [HttpGet]
        public IQueryable<ServiceRequestDTO> GetRequests()
        {
            var requests = from b in db.ServiceRequests
                            select new ServiceRequestDTO()
                            {
                                Id = b.Id,
                                SlurryWearType = b.SlurryWearType,
                                Industry = b.Industry,
                                Application = b.Application,
                                SlurryType = b.SlurryType,
                                HeadDuties = b.HeadDuties,
                                PumpType = b.PumpType,
                                PumpModel = b.PumpModel,
                                PumpSize = b.PumpSize,
                                DischargeOrientation = b.DischargeOrientation, 
                                Impeller = b.Impeller,
                                DiameterRatio = b.DiameterRatio,
                                ComponentType = b.ComponentType,
                                PartLife = b.PartLife,
                                QBepPer = b.QBepPer,
                                EfficiencyPer = b.EfficiencyPer,
                                Solids = b.Solids,
                                D50 = b.D50,
                                D85 = b.D85,
                                ParticleShape = b.ParticleShape,
                                Primary = b.Primary,
                                Secondary = b.Secondary,
                                Suggestion = b.Suggestion,
                                RelatedWearPart = b.RelatedWearPart,
                                Image1 = b.Image1,
                                ImageFilePath1 = b.ImageFilePath1,
                                Image2 = b.Image2,
                                ImageFilePath2 = b.ImageFilePath2,
                                Image3 = b.Image3,
                                ImageFilePath3 = b.ImageFilePath3,
                                Image4 = b.Image4,
                                ImageFilePath4 = b.ImageFilePath4,
                                Image5 = b.Image5,
                                ImageFilePath5 = b.ImageFilePath5,
                                Image6 = b.Image6,
                                ImageFilePath6 = b.ImageFilePath6,
                                Image7 = b.Image7,
                                ImageFilePath7 = b.ImageFilePath7,
                                Image8 = b.Image8,
                                ImageFilePath8 = b.ImageFilePath8,
                                Image9 = b.Image9,
                                ImageFilePath9 = b.ImageFilePath9,
                                Image10 = b.Image10,
                                ImageFilePath10 = b.ImageFilePath10,
                                UserId = b.UserId
                            };

            return requests;
        }
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutServiceRequest(int id, ServiceRequest request)
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
        public async Task<IHttpActionResult> PostServiceRequest(ServiceRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ServiceRequests.Add(request);
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
            return db.ServiceRequests.Count(e => e.Id == id) > 0;
        }

        //// GET: api/Authors/5
        //[ResponseType(typeof(Lookup))]
        //public async Task<IHttpActionResult> GetAuthor(int id)
        //{
        //    Lookup author = await db.Lookups.FindAsync(id);
        //    if (author == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(author);
        //}

        //// PUT: api/Authors/5
        //[ResponseType(typeof(void))]
        //public async Task<IHttpActionResult> PutAuthor(int id, Lookup author)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != author.Id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(author).State = EntityState.Modified;

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!AuthorExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/Authors
        //[ResponseType(typeof(Lookup))]
        //public async Task<IHttpActionResult> PostAuthor(Lookup author)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Lookups.Add(author);
        //    await db.SaveChangesAsync();

        //    return CreatedAtRoute("DefaultApi", new { id = author.Id }, author);
        //}

        //// DELETE: api/Authors/5
        //[ResponseType(typeof(Lookup))]
        //public async Task<IHttpActionResult> DeleteAuthor(int id)
        //{
        //    Lookup author = await db.Lookups.FindAsync(id);
        //    if (author == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Lookups.Remove(author);
        //    await db.SaveChangesAsync();

        //    return Ok(author);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool AuthorExists(int id)
        //{
        //    return db.Lookups.Count(e => e.Id == id) > 0;
        //}
    }
}