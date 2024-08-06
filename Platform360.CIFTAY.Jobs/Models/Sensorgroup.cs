using System;
using System.Collections.Generic;

namespace Platform360.CIFTAY.Jobs.Models
{
    public partial class Sensorgroup
    {
        public int GroupId { get; set; }
        public string? GroupName { get; set; }
        public int? HaritaId { get; set; }
        public double? Enlem { get; set; }
        public double? Boylam { get; set; }
        public bool? IsView { get; set; }
    }
}
