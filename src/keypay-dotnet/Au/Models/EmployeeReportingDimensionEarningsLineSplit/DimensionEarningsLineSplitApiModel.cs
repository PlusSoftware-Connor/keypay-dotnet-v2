using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.EmployeeReportingDimensionEarningsLineSplit
{
    public class DimensionEarningsLineSplitApiModel
    {
        public int Id { get; set; }
        public IList<ReducedReportingDimensionValueApiModel> ReportingDimensionValues { get; set; }
        public decimal? AllocatedPercentage { get; set; }
        public bool AllocateBalance { get; set; }
    }
}
