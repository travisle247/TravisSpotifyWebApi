using System.Collections.Generic;
using System.Web.Http;
using Newtonsoft.Json;
using TravisSpotifyWebService.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TravisSpotifyWebService.Helper;

namespace TravisSpotifyWebService.Controllers
{
    public class SpotifyCallController : ApiController
    {

        // GET: api/SpotifyCall
        public async Task<IEnumerable<Photo>> Get()
        {
            string baseAddress = "https://jsonplaceholder.typicode.com/photos";
            var json = await HttpHelper.Get(baseAddress);
            var photoArray = JsonConvert.DeserializeObject<IEnumerable<Photo>>(json, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple
            });


            return photoArray;

        }

        // GET: api/SpotifyCall/5
        public string Get(int id)
        { 
            return id.ToString();
        }

        public string Get(string access_token)
        {
            return access_token;
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
