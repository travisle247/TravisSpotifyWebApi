﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TravisSpotifyWebService.SpotifyModel
{
    [JsonObject]
    internal class artistsearchresult
    {
        public page<artist> artists { get; set; }
    }
}