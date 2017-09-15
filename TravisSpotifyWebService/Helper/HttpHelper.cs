using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace TravisSpotifyWebService.Helper
{
    internal class HttpHelper
    {
        /// <summary>
        /// Downloads a url and reads its contents as a string using the get method
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static async Task<string> Get(string url)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var httpResponse = await client.GetAsync(url);
            return await httpResponse.Content.ReadAsStringAsync();            
        }      
    }
}