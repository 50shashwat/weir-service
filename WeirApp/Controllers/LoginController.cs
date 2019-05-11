using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using WeirApp.Models;


namespace WeirApp.Controllers
{
    [Authorize]
    public class LoginController : ApiController
    {
        private WeirServiceContext db = new WeirServiceContext();

        [AllowAnonymous]
        [HttpPost]
        public IHttpActionResult Authenticate([FromBody]UserDTO prmUser)
        {
            User user = db.Users.FirstOrDefault(e => e.UserName == prmUser.UserName && prmUser.Password == e.Password);
            if (user != null)
            {
                string token = createToken(user.UserName);
                //return the token
                return Ok<UserDTO>(new UserDTO
                {
                    UserName = user.UserName,
                    Token = token,
                    UserType = user.UserType
                });
            }
            else
            {
                return BadRequest("Invalid Username or password"); 
            }
        }

        [AllowAnonymous]
        [HttpPut]
        public async Task<IHttpActionResult> UpdatePassword([FromBody]UserDTO prmUser)
        {
            User user = db.Users.FirstOrDefault(e => e.UserName == prmUser.UserName && prmUser.Password == e.Password);
            if (user != null)
            {
                user.Password = prmUser.NewPassword;
                db.Entry(user).State = EntityState.Modified;
                string token = createToken(user.UserName);
                try
                {
                    await db.SaveChangesAsync();
                }
                catch
                {
                    
                }
                //return the token
                return Ok<UserDTO>(new UserDTO
                {
                    UserName = user.UserName,
                    Token = token
                });
            }
            else
            {
                return BadRequest("Invalid Username or password");
            }
        }

        private string createToken(string username)
        {
            //Set issued at date
            DateTime issuedAt = DateTime.UtcNow;
            //set the time when it expires
            DateTime expires = DateTime.UtcNow.AddDays(7);

            //http://stackoverflow.com/questions/18223868/how-to-encrypt-jwt-security-token
            var tokenHandler = new JwtSecurityTokenHandler();

            //create a identity and add claims to the user which we want to log in
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, username)
            });

            const string sec = "401b09eab3c013d4ca54922bb802bec8fd5318192b0a75f201d8b3727429090fb337591abd3e44453b954555b7a0812e1081c39b740293f765eae731f5a65ed1";
            var now = DateTime.UtcNow;
            var securityKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(System.Text.Encoding.Default.GetBytes(sec));
            var signingCredentials = new Microsoft.IdentityModel.Tokens.SigningCredentials(securityKey, Microsoft.IdentityModel.Tokens.SecurityAlgorithms.HmacSha256Signature);


            //create the jwt
            var token =
                (JwtSecurityToken)
                    tokenHandler.CreateJwtSecurityToken(issuer: "http://localhost:50191", audience: "http://localhost:50191",
                        subject: claimsIdentity, notBefore: issuedAt, expires: expires, signingCredentials: signingCredentials);
            var tokenString = tokenHandler.WriteToken(token);

            return tokenString;
        }
    }
}