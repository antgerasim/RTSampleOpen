namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserSettingsBase")]
    public partial class UserSettingsBase
    {
        [Key]
        public Guid SystemUserId { get; set; }

        public Guid BusinessUnitId { get; set; }

        [StringLength(200)]
        public string HomepageArea { get; set; }

        public int? PagingLimit { get; set; }

        [StringLength(200)]
        public string HomepageSubarea { get; set; }

        public int? DefaultCalendarView { get; set; }

        [StringLength(5)]
        public string WorkdayStartTime { get; set; }

        [StringLength(5)]
        public string WorkdayStopTime { get; set; }

        public bool IgnoreUnsolicitedEmail { get; set; }

        public int TimeZoneBias { get; set; }

        public int TimeZoneStandardBias { get; set; }

        public int TimeZoneDaylightBias { get; set; }

        public short TimeZoneCode { get; set; }

        public short TimeZoneStandardYear { get; set; }

        public short TimeZoneStandardMonth { get; set; }

        public short TimeZoneStandardDay { get; set; }

        public short TimeZoneStandardDayOfWeek { get; set; }

        public short TimeZoneStandardHour { get; set; }

        public short TimeZoneStandardMinute { get; set; }

        public short TimeZoneStandardSecond { get; set; }

        public short TimeZoneDaylightYear { get; set; }

        public short TimeZoneDaylightMonth { get; set; }

        public short TimeZoneDaylightDay { get; set; }

        public short TimeZoneDaylightDayOfWeek { get; set; }

        public short TimeZoneDaylightHour { get; set; }

        public short TimeZoneDaylightMinute { get; set; }

        public short TimeZoneDaylightSecond { get; set; }

        public Guid? ModifiedBy { get; set; }

        public short AdvancedFindStartupMode { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int? TrackingTokenId { get; set; }

        public int? NextTrackingNumber { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [StringLength(1024)]
        public string UserProfile { get; set; }

        [Required]
        [StringLength(5)]
        public string NumberSeparator { get; set; }

        public int OutlookSyncInterval { get; set; }

        public bool UseCrmFormForTask { get; set; }

        public int? PricingDecimalPrecision { get; set; }

        public bool SyncContactCompany { get; set; }

        [Required]
        [StringLength(5)]
        public string DateSeparator { get; set; }

        public int LongDateFormatCode { get; set; }

        public bool AllowEmailCredentials { get; set; }

        public int FullNameConventionCode { get; set; }

        [StringLength(5)]
        public string TimeSeparator { get; set; }

        public int TimeFormatCode { get; set; }

        public int NegativeFormatCode { get; set; }

        public int OfflineSyncInterval { get; set; }

        public int CalendarType { get; set; }

        [Required]
        [StringLength(13)]
        public string CurrencySymbol { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public int UILanguageId { get; set; }

        public bool UseCrmFormForContact { get; set; }

        public int CurrencyFormatCode { get; set; }

        public int AddressBookSyncInterval { get; set; }

        [Required]
        [StringLength(5)]
        public string DecimalSymbol { get; set; }

        public bool UseCrmFormForEmail { get; set; }

        public bool ShowWeekNumber { get; set; }

        public int NegativeCurrencyFormatCode { get; set; }

        [StringLength(255)]
        public string TimeFormatString { get; set; }

        [StringLength(200)]
        public string EmailUsername { get; set; }

        [StringLength(255)]
        public string DateFormatString { get; set; }

        public int ReportScriptErrors { get; set; }

        public bool UseImageStrips { get; set; }

        [StringLength(200)]
        public string EmailPassword { get; set; }

        public int DateFormatCode { get; set; }

        public bool UseCrmFormForAppointment { get; set; }

        public bool IsDuplicateDetectionEnabledWhenGoingOnline { get; set; }

        public int? LocaleId { get; set; }

        public int IncomingEmailFilteringMethod { get; set; }

        public int? CurrencyDecimalPrecision { get; set; }

        [Required]
        [StringLength(25)]
        public string AMDesignator { get; set; }

        [StringLength(25)]
        public string NumberGroupFormat { get; set; }

        public int? HelpLanguageId { get; set; }

        [Required]
        [StringLength(25)]
        public string PMDesignator { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public bool GetStartedPaneContentEnabled { get; set; }

        public short AutoCreateContactOnPromote { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public string PersonalizationSettings { get; set; }

        public int VisualizationPaneLayout { get; set; }

        public int DataValidationModeForExportToExcel { get; set; }

        [StringLength(1000)]
        public string HomepageLayout { get; set; }

        public bool IsSendAsAllowed { get; set; }

        public Guid? DefaultDashboardId { get; set; }

        public int EntityFormMode { get; set; }

        public DateTime? LastAlertsViewedTime { get; set; }

        public bool IsDefaultCountryCodeCheckEnabled { get; set; }

        [StringLength(15)]
        public string DefaultCountryCode { get; set; }

        public bool? IsGuidedHelpEnabled { get; set; }

        public bool? IsAppsForCrmAlertDismissed { get; set; }

        public bool IsResourceBookingExchangeSyncEnabled { get; set; }

        public bool IsAutoDataCaptureEnabled { get; set; }

        public int? DefaultSearchExperience { get; set; }

        public long ResourceBookingExchangeSyncVersion { get; set; }

        public bool SplitViewState { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual SystemUserBase SystemUserBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
