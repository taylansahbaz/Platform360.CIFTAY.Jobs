using System;
using System.Collections.Generic;

namespace Platform360.CIFTAY.Jobs.Models
{
    public partial class Sensorkinddetail
    {
        public int KindCode { get; set; }
        public int? KindDetailCode { get; set; }
        public string Name { get; set; } = null!;
        public string? Unit { get; set; }
    }
}
