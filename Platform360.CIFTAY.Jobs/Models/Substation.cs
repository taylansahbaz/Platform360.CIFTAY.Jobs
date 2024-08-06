using System;
using System.Collections.Generic;

namespace Platform360.CIFTAY.Jobs.Models
{
    public partial class Substation
    {
        public int Id { get; set; }
        public int SubstationCode { get; set; }
        public string? SubstationName { get; set; }
        public string? Description { get; set; }
        public string? Besleme { get; set; }
        public bool? SubStationReset { get; set; }
        public bool? IsSendInitialCode { get; set; }
    }
}
