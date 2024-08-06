using System;
using System.Collections.Generic;

namespace Platform360.CIFTAY.Jobs.Models
{
    public partial class Gisarizakesinti
    {
        public int ArızaKesintiId { get; set; }
        public int? ArizaTip { get; set; }
        public int? SubstationCode { get; set; }
        public int? ChannelCode { get; set; }
        public DateTime ArızaBaslangicSaat { get; set; }
        public DateTime ArızaBitisSaat { get; set; }
        public DateTime? Olusturuldu { get; set; }
        public bool Durum { get; set; }
    }
}
