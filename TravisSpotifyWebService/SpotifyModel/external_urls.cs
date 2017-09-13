﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TravisSpotifyWebService.SpotifyModel
{
    [JsonObject]
    internal class external_urls
    {
        public string key { get; set; }

        public string value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ExternalUrl ToPOCO()
        {
            return new ExternalUrl() { Key = this.key, Value = this.value };
        }
    }
}