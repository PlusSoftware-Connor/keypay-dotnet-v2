using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Unavailability
{
    public class ListUnavailabilitiesQueryModel
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? EmployeeId { get; set; }
        public int? DefaultLocationId { get; set; }
    }
}
