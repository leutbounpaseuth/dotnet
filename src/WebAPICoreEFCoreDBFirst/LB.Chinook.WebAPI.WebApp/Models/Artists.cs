﻿using System;
using System.Collections.Generic;

namespace LB.Chinook.WebAPI.WebApp.Models
{
    public partial class Artists
    {
        public Artists()
        {
            Albums = new HashSet<Albums>();
        }

        public long ArtistId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Albums> Albums { get; set; }
    }
}
