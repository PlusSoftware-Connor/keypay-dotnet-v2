using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.ReportingDimensions
{
    public class ReportingDimensionValueApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ReportingDimensionId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ExternalService Source { get; set; }
        public string ExternalId { get; set; }
        public bool AllEmployees { get; set; }
        public string SpecificEmployees { get; set; }
        public string FilterCombinationStrategy { get; set; }
        public IList<ReportingDimensionValueFilterApiModel> Filters { get; set; }
    }
}
