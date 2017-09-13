using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TravisSpotifyWebService.SpotifyModel
{
    [JsonObject]
    internal class featuredplaylistssearchresult
    {
        public string message { get; set; }

        public page<playlist> playlists { get; set; }
    }
}