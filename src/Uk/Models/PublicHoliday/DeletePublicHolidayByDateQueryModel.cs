using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PublicHoliday
{
    public class DeletePublicHolidayByDateQueryModel
    {
        public DateTime Date { get; set; }
    }
}
