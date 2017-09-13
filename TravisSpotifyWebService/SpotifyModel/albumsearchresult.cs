using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TravisSpotifyWebService.SpotifyModel
{
    [JsonObject]
    internal class albumsearchresult
    {
        public page<album> albums { get; set; }
    }
}