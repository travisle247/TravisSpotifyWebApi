﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravisSpotifyWebService.SpotifyModel
{
    internal class playlist
    {
        public bool collaborative { get; set; }
        public string description { get; set; }
        public external_urls external_urls { get; set; }
        public followers followers { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public image[] images { get; set; }
        public string name { get; set; }
        public user owner { get; set; }
        public bool? @public { get; set; }
        public page<playlisttrack> tracks { get; set; }
        public string type { get; set; }
        public string uri { get; set; }

        public Playlist ToPOCO()
        {
            Playlist playlist = new Playlist();
            playlist.Collaborative = this.collaborative;
            playlist.Description = this.description;
            if (this.external_urls != null)
                playlist.ExternalUrl = this.external_urls.ToPOCO();
            if (followers != null)
                playlist.Followers = this.followers.ToPOCO();
            playlist.HREF = this.href;
            playlist.Id = this.id;
            if (images != null)
            {
                foreach (var image in this.images)
                {
                    var poco = image.ToPOCO();
                    if (poco != null)
                        playlist.Images.Add(poco);
                }
            }
            playlist.Name = this.name;
            if (this.owner != null)
                playlist.Owner = this.owner.ToPOCO();
            if (this.@public.HasValue)
                playlist.Public = this.@public.Value;
            else
                playlist.Public = false;
            if (tracks != null)
                playlist.Tracks = this.tracks.ToPOCO<PlaylistTrack>();
            playlist.Type = this.type;
            playlist.Uri = this.type;

            return playlist;
        }
    }
}