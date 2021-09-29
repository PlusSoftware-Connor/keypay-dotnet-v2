using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.EmployeeEarningsLineSplit
{
    public class EarningsLineSplitApiModel
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public decimal? AllocatedPercentage { get; set; }
        public bool AllocateBalance { get; set; }
    }
}
