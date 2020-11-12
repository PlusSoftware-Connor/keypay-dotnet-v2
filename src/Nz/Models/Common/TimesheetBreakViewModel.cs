using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Common
{
    public class TimesheetBreakViewModel
    {
        public int Id { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public DateTime? SubmittedStart { get; set; }
        public DateTime? SubmittedEnd { get; set; }
        public string FormattedStart { get; set; }
        public string FormattedEnd { get; set; }
    }
}
