using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TravisSpotifyWebService.SpotifyModel
{
    [JsonObject]
    internal class playlistsearchresult
    {
        public page<playlist> playlists { get; set; }
    }
}