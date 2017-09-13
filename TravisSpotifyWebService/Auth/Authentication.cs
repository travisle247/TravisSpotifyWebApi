using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravisSpotifyWebService.Helper;
using TravisSpotifyWebService.Models;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace TravisSpotifyWebService.Auth
{
    public class Authentication : BaseModel
    {
        public static string ClientId { get; set; }

        public static string ClientSecret { get; set; }

        public static string RedirectUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public async static Task<AuthenticationToken> GetAccessToken(string code)
        {
            Dictionary<string, string> postData = new Dictionary<string, string>();
            postData.Add("grant_type", "authorization_code");
            postData.Add("code", code);
            postData.Add("redirect_uri", RedirectUri);
            postData.Add("client_id", ClientId);
            postData.Add("client_secret", ClientSecret);

            var json = await HttpHelper.Post("https://accounts.spotify.com/api/token", postData);
            var obj = JsonConvert.DeserializeObject<Accesstoken>(json, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                TypeNameAssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple
            });

            return obj.ToPOCO();
        }
    }
}