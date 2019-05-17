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
    public IQueryable<CaseStudy> GetRequests()
    {
      return db.CaseStudy.AsQueryable<CaseStudy>();
    }
    [ResponseType(typeof(void))]

    // POST: api/Authors
    [ResponseType(typeof(ServiceRequest))]
    public async Task<IHttpActionResult> PostServiceRequest(CaseStudyStaging request)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }
      db.CaseStudyStaging.Add(request);
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