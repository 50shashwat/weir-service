using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeirApp.Models;

namespace WeirApp.Controllers
{

    public class UserController : ApiController
    {
        private WeirServiceContext db = new WeirServiceContext();

        // GET: api/Authors
        public bool GetUser(string userName, string password)
        {
            //return db.Users.Count(e => e.UserName == userName && password == e.Password) > 0;
            return true;
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
