﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravisSpotifyWebService.Models
{
    public class Image : BaseModel
    {
        /// <summary>
        /// The image height in pixels
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// The source URL of the image.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// The image height in pixels
        /// </summary>
        public int Width { get; set; }
    }
}