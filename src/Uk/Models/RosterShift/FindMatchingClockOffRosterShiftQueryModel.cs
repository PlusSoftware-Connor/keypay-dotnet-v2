using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.RosterShift
{
    public class FindMatchingClockOffRosterShiftQueryModel
    {
        public int KioskId { get; set; }
        public DateTime DateUtc { get; set; }
    }
}
