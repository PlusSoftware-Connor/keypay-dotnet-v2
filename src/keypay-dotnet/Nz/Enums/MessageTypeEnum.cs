using System;
using System.Collections.Generic;

namespace KeyPayV2.Nz.Enums
{
    public enum MessageTypeEnum
    {
        NewPaySlipAvailable,
        NewUser,
        RecoverPassword,
        EmployeeAccess,
        BusinessAccess,
        CancelAccount,
        Invoice,
        InvoicePaymentSuccessNotification,
        AutomatedPassword,
        LeaveRequestNotification,
        RestrictedAccess,
        ResendPayslip,
        PaymentSummaryAvailable,
        SuperPaymentsUpdateResults,
        InvoicePaymentFailedNotification,
        NewShiftsPublished,
        ShiftsUnpublished,
        ShiftDeclined,
        KioskAccessGranted,
        DailyNotifications,
        BsbDataImported,
        InvoiceeCardDetailsRemoved,
        WhiteLabelManagerAccess,
        ResellerAccess,
        DirectDepositReminder,
        ExpenseRequestNotification,
        UnavailabilityNotification,
        ReportPackGenerated,
        ReportPackError,
        SystemPublicHolidayImport,
        TimesheetRejected,
        ShiftRepublished,
        PendingShiftsReminder,
        EmployeeShiftActionTimeout,
        InitiateEmployeeOnboarding,
        FollowUpEmployeeOnboarding,
        CompleteEmployeeOnboarding,
        NewShiftsPreAccepted,
        PayRunTaskNotification,
        ShiftSwapCancelled,
        BulkShiftSwapsCancelled,
        ShiftSwapAwaitingApproval,
        ShiftSwapProposed,
        ShiftSwapAccepted,
        ShiftSwapDeclined,
        ShiftSwapRejected,
        ShiftSwapApproved,
        P60Available,
        P60Error,
        LeavingEmployeeFormNotification,
        AutoEnrolmentNotification,
        LodgementNotification,
        TwoFactorLogin,
        TwoFactorChallenge,
        ConfirmEmailAddress,
        ConfirmMobilePhone,
        DocumentNotificationInitial,
        DocumentNotificationInitialWithAcknowledgement,
        DocumentNotificationReminder,
        DocumentAcknowledgedNotification,
        InitiateEmployeeOnboardingAdmin,
        PayEventRequestAuthority,
        PayEventApprovedOrRejected,
        ShiftBidAccepted,
        EmployeeDetailsUpdated,
        BankAccountDetailsUpdated,
        SuperDetailsUpdated,
        ManagerShiftActionTimeout,
        SuperFundNotificationNewMember,
        SuperPaymentDishonour,
        KiwiSaverDetailsUpdated,
        AutoEnrolmentPostponementNotification,
        AutomatedPayRunErrorCreation,
        AutomatedPayRunErrorProcessing,
        AutomatedPayRunErrorFinalisation,
        AutomatedPayRunErrorPostFinalise,
        AutomatedPayRunSuccessAndFinalised,
        AutomatedPayRunSuccessNotFinalised,
        AutomatedPayRunCreation,
        PayRunUsageBillingFailures,
        IncomeStatementAvailable,
        MaliciousFileNotificationAdmin,
        UserAccountLocked,
        MaliciousFileNotificationEmployee,
        SuperFundRefundNotification,
        SuperBatchCancelledNotification,
        JobKeeperEmployeeNomination,
        HmrcPaymentReminder,
        IrasFormAvailable,
        HmrcPaymentReminderSendFailure,
        SyncCancelledSuperBatchesFromBeam,
        EAFormIncomeTaxAvailable,
        PCB2FormAvailable,
        JobMakerEmployeeNomination,
        EarningsCertificateAvailable,
        P11dAvailable,
        PayRunApprovalNotification,
        PayRunApprovalReminder,
        PayRunStatusChanged,
        QualificationUpdatedNotification,
        QualificationExpiringNotification,
        QualificationExpiredNotification,
        CreditCardExpiringReminder,
        ResendPaymentAndDeductionStatement,
        EmployeeSelfSetupReminder,
        EmployeeOnboardingP45Uploaded
    }
}
