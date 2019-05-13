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
    public class LookupController : ApiController
    {
        private WeirServiceContext db = new WeirServiceContext();

        // GET: api/Books
        public IQueryable<LookupDTO> GetLookups()
        {
            var lookups = from b in db.Lookups
                        select new LookupDTO()
                        {
                            Id = b.Id,
                            LookupType = b.LookupType,
                            LookupValue = b.LookupValue,
                            Active = b.Active,
                            Sequence = b.Sequence,
                            Description = b.Description,
                            CreatedDateTime = b.CreatedDateTime,
                            UpdatedDateTime = b.UpdatedDateTime,
                            ParentLookup=b.ParentLookup
                        };

            return lookups;
        }

        // GET: api/Books
        public IQueryable<LookupDTO> GetLookups(string lookupType)
        {
            var lookups = from b in db.Lookups.Where(e => e.LookupType == lookupType)
                          select new LookupDTO()
                          {
                              Id = b.Id,
                              LookupType = b.LookupType,
                              LookupValue = b.LookupValue,
                              Active = b.Active,
                              Sequence = b.Sequence,
                              Description = b.Description,
                              CreatedDateTime = b.CreatedDateTime,
                              UpdatedDateTime = b.UpdatedDateTime,
                              ParentLookup = b.ParentLookup
                          };

            return lookups;
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
            return db.Lookups.Count(e => e.Id == id) > 0;
        }

        //// GET: api/Books/5
        //[ResponseType(typeof(CustomerDTO))]
        //public async Task<IHttpActionResult> GetBook(int id)
        //{
        //    var book = await db.Customers.Include(b => b.Author).Select(b =>
        //        new CustomerDTO()
        //        {
        //            Id = b.Id,
        //            Title = b.Title,
        //            Year = b.Year,
        //            Price = b.Price,
        //            AuthorName = b.Author.Name,
        //            Genre = b.Genre
        //        }).SingleOrDefaultAsync(b => b.Id == id);
        //    if (book == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(book);
        //}

        //// PUT: api/Books/5
        //[ResponseType(typeof(void))]
        //public async Task<IHttpActionResult> PutBook(int id, Customer book)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != book.Id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(book).State = EntityState.Modified;

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!BookExists(id))
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

        //// POST: api/Books
        //[ResponseType(typeof(Customer))]
        //public async Task<IHttpActionResult> PostBook(Customer book)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Customers.Add(book);
        //    await db.SaveChangesAsync();

        //    // Load author name
        //    db.Entry(book).Reference(x => x.Author).Load();

        //    var dto = new LookupDTO()
        //    {
        //        Id = book.Id,
        //        Title = book.Title,
        //        AuthorName = book.Author.Name
        //    };

        //    return CreatedAtRoute("DefaultApi", new { id = book.Id }, dto);
        //}

        //// DELETE: api/Books/5
        //[ResponseType(typeof(Customer))]
        //public async Task<IHttpActionResult> DeleteBook(int id)
        //{
        //    Customer book = await db.Customers.FindAsync(id);
        //    if (book == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Customers.Remove(book);
        //    await db.SaveChangesAsync();

        //    return Ok(book);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool BookExists(int id)
        //{
        //    return db.Customers.Count(e => e.Id == id) > 0;
        //}
    }
}