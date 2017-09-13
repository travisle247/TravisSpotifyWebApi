using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TravisSpotifyWebService.SpotifyModel
{
    internal class followers
    {
        public string href { get; set; }
        public int total { get; set; }

        public Followers ToPOCO()
        {
            Followers followers = new Followers();
            followers.HREF = this.href;
            followers.Total = this.total;

            return followers;
        }
    }
}