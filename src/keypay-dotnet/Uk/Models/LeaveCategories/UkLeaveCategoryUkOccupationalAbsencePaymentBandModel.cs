using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.LeaveCategories
{
    public class UkLeaveCategoryUkOccupationalAbsencePaymentBandModel
    {
        public int PaymentBandIndex { get; set; }
        public decimal Rate { get; set; }
    }
}
