using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.LeaveCategories
{
    public class AuLeaveCategoryModel
    {
        public decimal? ContingentPeriod { get; set; }
        public decimal? EntitlementPeriod { get; set; }
        public decimal LeaveLoading { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveAllowanceUnitEnum UnitType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public AuLeaveCategoryTypeEnum LeaveCategoryType { get; set; }
        public AuLeaveAccrualRuleModel LeaveAccrualRule { get; set; }
        public int? TransferOnTerminationToPayCategoryId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Units { get; set; }
        public bool AutomaticallyAccrues { get; set; }
        public bool IsPrivate { get; set; }
        public bool ExcludeFromTerminationPayout { get; set; }
        public string ExternalId { get; set; }
        public string Source { get; set; }
        public bool IsBalanceUntracked { get; set; }
        public bool DeductFromPrimaryPayCategory { get; set; }
        public int? DeductFromPayCategoryId { get; set; }
        public int? TransferToPayCategoryId { get; set; }
        public bool HideAccrualsOnPayslip { get; set; }
        public bool UseDeductFromPayCategoryRate { get; set; }
        public bool IsNamePrivate { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveUnitTypeEnum LeaveUnitType { get; set; }
        public bool PayoutAsETP { get; set; }
        public bool? AccruesFirstPayRunPerPeriodOnly { get; set; }
        public int? PreventNegativeBalanceUnpaidLeaveCategoryId { get; set; }
    }
}
