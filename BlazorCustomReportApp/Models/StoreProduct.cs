﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace BlazorCustomReportApp.Models
{
    public partial class StoreProduct
    {
        public int Id { get; set; }
        public int? StoreId { get; set; }
        public string ProductDesc { get; set; }
        public decimal? ProductPrice { get; set; }
        public int? ProductOnHand { get; set; }

        public virtual Store Store { get; set; }
    }
}