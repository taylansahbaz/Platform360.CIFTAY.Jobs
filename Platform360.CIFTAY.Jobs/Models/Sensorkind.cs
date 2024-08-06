using System;
using System.Collections.Generic;

namespace Platform360.CIFTAY.Jobs.Models
{
    public partial class Sensorkind
    {
        public int KindCode { get; set; }
        public string KindName { get; set; } = null!;
        public int? AnalogSwitch { get; set; }
    }
}
