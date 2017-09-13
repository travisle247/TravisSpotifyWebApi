using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;


namespace TravisSpotifyWebService.SpotifyModel
{
    [JsonObject]
    class savedtrack
    {
        public string added_at { get; set; }
        public track track { get; set; }
    }
}