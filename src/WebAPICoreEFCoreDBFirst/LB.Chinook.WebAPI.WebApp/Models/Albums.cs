﻿using System;
using System.Collections.Generic;

namespace LB.Chinook.WebAPI.WebApp.Models
{
    public partial class Albums
    {
        public Albums()
        {
            Tracks = new HashSet<Tracks>();
        }

        public long AlbumId { get; set; }
        public string Title { get; set; }
        public long ArtistId { get; set; }

        public virtual Artists Artist { get; set; }
        public virtual ICollection<Tracks> Tracks { get; set; }
    }
}
