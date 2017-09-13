﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TravisSpotifyWebService.SpotifyModel
{
    [JsonObject]
    internal class external_ids
    {
        public string key { get; set; }

        public string value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ExternalId ToPOCO()
        {
            return new ExternalId() { Key = this.key, Value = this.value };
        }
    }
}