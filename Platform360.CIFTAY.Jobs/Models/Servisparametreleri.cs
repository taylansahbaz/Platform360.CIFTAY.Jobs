using System;
using System.Collections.Generic;

namespace Platform360.CIFTAY.Jobs.Models
{
    public partial class Servisparametreleri
    {
        public int Id { get; set; }
        public string ComPort { get; set; } = null!;
        public int BaudRate { get; set; }
        public bool? BaglantiDurum { get; set; }
        public bool? IsSendInitializeCode { get; set; }
        public bool? IsServiceRunning { get; set; }
    }
}
