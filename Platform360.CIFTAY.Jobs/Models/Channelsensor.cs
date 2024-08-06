using System;
using System.Collections.Generic;

namespace Platform360.CIFTAY.Jobs.Models
{
    public partial class Channelsensor
    {
        public int SubstationCode { get; set; }
        public int ChannelCode { get; set; }
        public int? SensorGroup { get; set; }
        public int KindCode { get; set; }
        public int KindDetailCode { get; set; }
        public string Description { get; set; } = null!;
        public double? AlertValue { get; set; }
        public double? AlertValue2 { get; set; }
        public double? PowerOffValue { get; set; }
        public double? PowerOffResetValue { get; set; }
        public bool? PowerOnOffState { get; set; }
        public int? MinFrequency { get; set; }
        public int? MaxFrequency { get; set; }
        public bool? KesiciDurum { get; set; }
        public int? KesiciPortCode { get; set; }
        public bool SensorState { get; set; }
        public bool? LineCut { get; set; }
        public bool? AlarmKanali { get; set; }
        public int? AlarmPortCode { get; set; }
        public bool? AlarmKanaliDurum { get; set; }
    }
}
