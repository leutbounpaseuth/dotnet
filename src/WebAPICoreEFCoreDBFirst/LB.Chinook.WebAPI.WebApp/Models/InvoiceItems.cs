﻿using System;
using System.Collections.Generic;

namespace LB.Chinook.WebAPI.WebApp.Models
{
    public partial class InvoiceItems
    {
        public long InvoiceLineId { get; set; }
        public long InvoiceId { get; set; }
        public long TrackId { get; set; }
        public byte[] UnitPrice { get; set; }
        public long Quantity { get; set; }

        public virtual Invoices Invoice { get; set; }
        public virtual Tracks Track { get; set; }
    }
}
