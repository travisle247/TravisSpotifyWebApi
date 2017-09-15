using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TravisSpotifyWebService.Models
{
    [JsonObject]
    public class Photo
    {
        public string albumId;

        public int id;

        public string title;

        public string url;

        public string thumbnailUrl;
    }
}