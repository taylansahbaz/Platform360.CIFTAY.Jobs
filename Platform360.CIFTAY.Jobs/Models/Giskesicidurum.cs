using System;
using System.Collections.Generic;

namespace Platform360.CIFTAY.Jobs.Models
{
    public partial class Giskesicidurum
    {
        public int KesiciId { get; set; }
        public int IstasyonId { get; set; }
        public int SensorId { get; set; }
        public double? KesiciDeger { get; set; }
        public int? KesiciPortCode { get; set; }
        public DateTime? BaslangicZaman { get; set; }
        public DateTime? BitisZamani { get; set; }
        public bool? KesiciDurum { get; set; }
    }
}
