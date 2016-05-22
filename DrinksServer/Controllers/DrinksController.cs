using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DrinksServer.Controllers
{
    public class DrinksController : ApiController
    {
        // GET: api/Drinks
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Drinks/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Drinks
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Drinks/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Drinks/5
        public void Delete(int id)
        {
        }
    }
}
