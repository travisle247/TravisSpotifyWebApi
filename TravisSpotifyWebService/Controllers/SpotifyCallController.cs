using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace TravisSpotifyWebService.Controllers
{
    public class SpotifyCallController : ApiController
    {
   
        // GET: api/SpotifyCall
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SpotifyCall/5
        public string Get(int id)
        { 
            return "value";
        }

        // POST: api/SpotifyCall
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SpotifyCall/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SpotifyCall/5
        public void Delete(int id)
        {
        }

        
    }
}
