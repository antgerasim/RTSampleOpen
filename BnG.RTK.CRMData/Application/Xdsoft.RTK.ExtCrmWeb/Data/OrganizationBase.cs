namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrganizationBase")]
    public partial class OrganizationBase
    {
        [Key]
        public Guid OrganizationId { get; set; }

        [Required]
        [StringLength(160)]
        public string Name { get; set; }

        public Guid? UserGroupId { get; set; }

        public Guid? PrivilegeUserGroupId { get; set; }

        public int FiscalPeriodType { get; set; }

        public DateTime? FiscalCalendarStart { get; set; }

        public int DateFormatCode { get; set; }

        public int TimeFormatCode { get; set; }

        [StringLength(13)]
        public string CurrencySymbol { get; set; }

        public int WeekStartDayCode { get; set; }

        [StringLength(5)]
        public string DateSeparator { get; set; }

        public int FullNameConventionCode { get; set; }

        public int NegativeFormatCode { get; set; }

        [StringLength(2)]
        public string NumberFormat { get; set; }

        public bool? IsDisabled { get; set; }

        [StringLength(500)]
        public string DisabledReason { get; set; }

        [StringLength(20)]
        public string KbPrefix { get; set; }

        public int? CurrentKbNumber { get; set; }

        [StringLength(20)]
        public string CasePrefix { get; set; }

        public int? CurrentCaseNumber { get; set; }

        [StringLength(20)]
        public string ContractPrefix { get; set; }

        public int? CurrentContractNumber { get; set; }

        [StringLength(20)]
        public string QuotePrefix { get; set; }

        public int? CurrentQuoteNumber { get; set; }

        [StringLength(20)]
        public string OrderPrefix { get; set; }

        public int? CurrentOrderNumber { get; set; }

        [StringLength(20)]
        public string InvoicePrefix { get; set; }

        public int? CurrentInvoiceNumber { get; set; }

        public int? UniqueSpecifierLength { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(25)]
        public string FiscalYearFormat { get; set; }

        [StringLength(25)]
        public string FiscalPeriodFormat { get; set; }

        [Required]
        [StringLength(5)]
        public string FiscalYearPeriodConnect { get; set; }

        public int? LanguageCode { get; set; }

        public int? SortId { get; set; }

        [StringLength(255)]
        public string DateFormatString { get; set; }

        [StringLength(255)]
        public string TimeFormatString { get; set; }

        public int PricingDecimalPrecision { get; set; }

        public bool? ShowWeekNumber { get; set; }

        public int? NextTrackingNumber { get; set; }

        public byte TagMaxAggressiveCycles { get; set; }

        [StringLength(90)]
        public string TokenKey { get; set; }

        public Guid? SystemUserId { get; set; }

        public Guid? CreatedBy { get; set; }

        public bool? GrantAccessToNetworkService { get; set; }

        public bool AllowOutlookScheduledSyncs { get; set; }

        public bool AllowMarketingEmailExecution { get; set; }

        public Guid? SqlAccessGroupId { get; set; }

        public int CurrencyFormatCode { get; set; }

        public bool FiscalSettingsUpdated { get; set; }

        public Guid? ReportingGroupId { get; set; }

        public short? TokenExpiry { get; set; }

        public bool ShareToPreviousOwnerOnAssign { get; set; }

        public Guid? AcknowledgementTemplateId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? IntegrationUserId { get; set; }

        public int? TrackingTokenIdBase { get; set; }

        public Guid? BusinessClosureCalendarId { get; set; }

        public bool? AllowAutoUnsubscribeAcknowledgement { get; set; }

        public bool? AllowAutoUnsubscribe { get; set; }

        public string Picture { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [StringLength(256)]
        public string TrackingPrefix { get; set; }

        public int MinOutlookSyncInterval { get; set; }

        [Required]
        [StringLength(20)]
        public string BulkOperationPrefix { get; set; }

        public bool? AllowAutoResponseCreation { get; set; }

        public int? MaximumTrackingNumber { get; set; }

        [Required]
        [StringLength(20)]
        public string CampaignPrefix { get; set; }

        [StringLength(256)]
        public string SqlAccessGroupName { get; set; }

        public int? CurrentCampaignNumber { get; set; }

        public byte FiscalYearDisplayCode { get; set; }

        public string SiteMapXml { get; set; }

        public bool? IsRegistered { get; set; }

        [StringLength(256)]
        public string ReportingGroupName { get; set; }

        public int? CurrentBulkOperationNumber { get; set; }

        [StringLength(8)]
        public string SchemaNamePrefix { get; set; }

        public bool IgnoreInternalEmail { get; set; }

        public int TagPollingPeriod { get; set; }

        public byte? TrackingTokenIdDigits { get; set; }

        [StringLength(50)]
        public string NumberGroupFormat { get; set; }

        public int LongDateFormatCode { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int CurrentImportSequenceNumber { get; set; }

        [Required]
        [StringLength(20)]
        public string ParsedTablePrefix { get; set; }

        [StringLength(256)]
        public string V3CalloutConfigHash { get; set; }

        public bool IsFiscalPeriodMonthBased { get; set; }

        public int LocaleId { get; set; }

        [Required]
        [StringLength(20)]
        public string ParsedTableColumnPrefix { get; set; }

        public Guid? SupportUserId { get; set; }

        [Required]
        [StringLength(25)]
        public string AMDesignator { get; set; }

        public int CurrencyDisplayOption { get; set; }

        public int MinAddressBookSyncInterval { get; set; }

        public bool IsDuplicateDetectionEnabledForOnlineCreateUpdate { get; set; }

        public string FeatureSet { get; set; }

        public string BlockedAttachments { get; set; }

        public bool IsDuplicateDetectionEnabledForOfflineSync { get; set; }

        public bool AllowOfflineScheduledSyncs { get; set; }

        public bool AllowUnresolvedPartiesOnEmailSend { get; set; }

        [StringLength(5)]
        public string TimeSeparator { get; set; }

        public int CurrentParsedTableNumber { get; set; }

        public int MinOfflineSyncInterval { get; set; }

        public bool AllowWebExcelExport { get; set; }

        public string ReferenceSiteMapXml { get; set; }

        public bool IsDuplicateDetectionEnabledForImport { get; set; }

        public int? CalendarType { get; set; }

        public bool? SQMEnabled { get; set; }

        public int NegativeCurrencyFormatCode { get; set; }

        public bool AllowAddressBookSyncs { get; set; }

        public int ISVIntegrationCode { get; set; }

        [Required]
        [StringLength(5)]
        public string DecimalSymbol { get; set; }

        public int MaxUploadFileSize { get; set; }

        public bool IsAppMode { get; set; }

        public bool EnablePricingOnCreate { get; set; }

        public bool IsSOPIntegrationEnabled { get; set; }

        [Required]
        [StringLength(25)]
        public string PMDesignator { get; set; }

        public int CurrencyDecimalPrecision { get; set; }

        public int MaxAppointmentDurationDays { get; set; }

        public int EmailSendPollingPeriod { get; set; }

        public bool RenderSecureIFrameForEmail { get; set; }

        [Required]
        [StringLength(5)]
        public string NumberSeparator { get; set; }

        public Guid? PrivReportingGroupId { get; set; }

        public Guid? BaseCurrencyId { get; set; }

        public int MaxRecordsForExportToExcel { get; set; }

        [StringLength(256)]
        public string PrivReportingGroupName { get; set; }

        public int YearStartWeekCode { get; set; }

        public bool? IsPresenceEnabled { get; set; }

        public bool IsDuplicateDetectionEnabled { get; set; }

        public int RecurrenceExpansionJobBatchInterval { get; set; }

        public int? DefaultRecurrenceEndRangeType { get; set; }

        public int? HashMinAddressCount { get; set; }

        public bool RequireApprovalForUserEmail { get; set; }

        public int RecurrenceDefaultNumberOfOccurrences { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public bool RequireApprovalForQueueEmail { get; set; }

        public bool AllowEntityOnlyAudit { get; set; }

        public bool IsAuditEnabled { get; set; }

        public int RecurrenceExpansionSynchCreateMax { get; set; }

        public int GoalRollupExpiryTime { get; set; }

        public int BaseCurrencyPrecision { get; set; }

        public int? FiscalPeriodFormatPeriod { get; set; }

        public bool AllowClientMessageBarAd { get; set; }

        [StringLength(20)]
        public string InitialVersion { get; set; }

        public string HashFilterKeywords { get; set; }

        public int NextCustomObjectTypeCode { get; set; }

        public int ExpireSubscriptionsInDays { get; set; }

        public string OrgDbOrgSettings { get; set; }

        public int PastExpansionWindow { get; set; }

        public bool? EnableSmartMatching { get; set; }

        public int MaxRecordsForLookupFilters { get; set; }

        [Required]
        [StringLength(4000)]
        public string BaseCurrencySymbol { get; set; }

        public int ReportScriptErrors { get; set; }

        public int RecurrenceExpansionJobBatchSize { get; set; }

        public int FutureExpansionWindow { get; set; }

        public bool GetStartedPaneContentEnabled { get; set; }

        public Guid? SampleDataImportId { get; set; }

        [Required]
        [StringLength(4000)]
        public string BaseISOCurrencyCode { get; set; }

        public int GoalRollupFrequency { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int? HashDeltaSubjectCount { get; set; }

        public int? HashMaxCount { get; set; }

        public int? FiscalYearFormatYear { get; set; }

        public int? FiscalYearFormatPrefix { get; set; }

        public int? PinpointLanguageCode { get; set; }

        public int? FiscalYearFormatSuffix { get; set; }

        public bool AllowUserFormModePreference { get; set; }

        public int? MaximumActiveBusinessProcessFlowsAllowedPerEntity { get; set; }

        public int? YammerGroupId { get; set; }

        public bool IsUserAccessAuditEnabled { get; set; }

        public bool IsDefaultCountryCodeCheckEnabled { get; set; }

        public DateTime? MetadataSyncLastTimeOfNeverExpiredDeletedObjects { get; set; }

        public int? IncomingEmailExchangeEmailRetrievalBatchSize { get; set; }

        public bool QuickFindRecordLimitEnabled { get; set; }

        public bool? YammerOAuthAccessTokenExpired { get; set; }

        public bool UseSkypeProtocol { get; set; }

        public Guid? DefaultEmailServerProfileId { get; set; }

        public bool GenerateAlertsForErrors { get; set; }

        [StringLength(15)]
        public string DefaultCountryCode { get; set; }

        public bool EmailCorrelationEnabled { get; set; }

        public int UserAccessAuditingInterval { get; set; }

        public bool IsAutoSaveEnabled { get; set; }

        public string DefaultEmailSettings { get; set; }

        public long MetadataSyncTimestamp { get; set; }

        [StringLength(256)]
        public string YammerNetworkPermalink { get; set; }

        public int EmailConnectionChannel { get; set; }

        public Guid? EntityImageId { get; set; }

        public bool NotifyMailboxOwnerOfEmailServerLevelAlerts { get; set; }

        [StringLength(1024)]
        public string BingMapsApiKey { get; set; }

        public bool GenerateAlertsForInformation { get; set; }

        public bool GenerateAlertsForWarnings { get; set; }

        public int? YammerPostMethod { get; set; }

        public bool AllowUsersSeeAppdownloadMessage { get; set; }

        public bool UseReadForm { get; set; }

        public bool EnableBingMapsIntegration { get; set; }

        public bool DisableSocialCare { get; set; }

        public string SocialInsightsInstance { get; set; }

        public bool? UseInbuiltRuleForDefaultPricelistSelection { get; set; }

        public int DiscountCalculationMethod { get; set; }

        public bool IsAssignedTasksSyncEnabled { get; set; }

        public bool IsAppointmentAttachmentSyncEnabled { get; set; }

        public bool IsContactMailingAddressSyncEnabled { get; set; }

        public int MaxSupportedInternetExplorerVersion { get; set; }

        public bool CreateProductsWithoutParentInActiveState { get; set; }

        public string SlaPauseStates { get; set; }

        public int MaxProductsInBundle { get; set; }

        public bool OOBPriceCalculationEnabled { get; set; }

        public bool? CascadeStatusUpdate { get; set; }

        public bool? RestrictStatusUpdate { get; set; }

        public int MaxDepthForHierarchicalSecurityModel { get; set; }

        public bool IsHierarchicalSecurityModelEnabled { get; set; }

        public bool GlobalHelpUrlEnabled { get; set; }

        public bool DisplayNavigationTour { get; set; }

        public bool GlobalAppendUrlParametersEnabled { get; set; }

        public bool? SocialInsightsTermsAccepted { get; set; }

        public bool? SocialInsightsEnabled { get; set; }

        [StringLength(500)]
        public string GlobalHelpUrl { get; set; }

        [Required]
        [StringLength(200)]
        public string SignupOutlookDownloadFWLink { get; set; }

        public int MaximumDynamicPropertiesAllowed { get; set; }

        public bool UsePositionHierarchy { get; set; }

        public bool SuppressSLA { get; set; }

        public bool IsMailboxInactiveBackoffEnabled { get; set; }

        public int MobileOfflineSyncInterval { get; set; }

        public int PluginTraceLogSetting { get; set; }

        public int DaysSinceRecordLastModifiedMaxValue { get; set; }

        public int MaxFolderBasedTrackingMappings { get; set; }

        [Required]
        [StringLength(20)]
        public string KaPrefix { get; set; }

        public int? SharePointDeploymentType { get; set; }

        public bool TaskBasedFlowEnabled { get; set; }

        public int MailboxPermanentIssueMinRange { get; set; }

        public bool IsOneDriveEnabled { get; set; }

        public int MaxVerboseLoggingSyncCycles { get; set; }

        [StringLength(1000)]
        public string OfficeGraphDelveUrl { get; set; }

        [Required]
        [StringLength(512)]
        public string WebResourceHash { get; set; }

        public int MaxVerboseLoggingMailbox { get; set; }

        public bool IsFullTextSearchEnabled { get; set; }

        public Guid? DefaultMobileOfflineProfileId { get; set; }

        public bool AutoApplyDefaultonCaseCreate { get; set; }

        public bool IsDelegateAccessEnabled { get; set; }

        public string KMSettings { get; set; }

        public int MobileOfflineMinLicenseTrial { get; set; }

        public string DefaultThemeData { get; set; }

        public bool AutoApplySLA { get; set; }

        public int MailboxIntermittentIssueMinRange { get; set; }

        public string HighContrastThemeData { get; set; }

        public bool IsFolderBasedTrackingEnabled { get; set; }

        [StringLength(500)]
        public string PrivacyStatementUrl { get; set; }

        public int MobileOfflineMinLicenseProd { get; set; }

        public int ExpireChangeTrackingInDays { get; set; }

        public string ExternalPartyCorrelationKeys { get; set; }

        public bool ShowKBArticleDeprecationNotification { get; set; }

        public bool IsMailboxForcedUnlockingEnabled { get; set; }

        public string ExternalPartyEntitySettings { get; set; }

        public bool IsOfficeGraphEnabled { get; set; }

        public bool IsExternalSearchIndexEnabled { get; set; }

        public int CurrentKaNumber { get; set; }

        public Guid? DelegatedAdminUserId { get; set; }

        public bool EnforceReadOnlyPlugins { get; set; }

        public bool IsEmailServerProfileContentFilteringEnabled { get; set; }

        public bool UseLegacyRendering { get; set; }

        public bool IsMobileOfflineEnabled { get; set; }

        [StringLength(100)]
        public string AzureSchedulerJobCollectionName { get; set; }

        public bool AutoApplyDefaultonCaseUpdate { get; set; }

        public bool CortanaProactiveExperienceEnabled { get; set; }

        public bool OfficeAppsAutoDeploymentEnabled { get; set; }

        public bool IsEnabledForAllRoles { get; set; }

        public bool IsPreviewForEmailMonitoringAllowed { get; set; }

        public bool IsPreviewForAutoCaptureEnabled { get; set; }

        public bool IsResourceBookingExchangeSyncEnabled { get; set; }

        [StringLength(500)]
        public string PostMessageWhitelistDomains { get; set; }

        [StringLength(500)]
        public string ExternalBaseUrl { get; set; }

        public int? MaximumEntitiesWithActiveSLA { get; set; }

        [StringLength(250)]
        public string WidgetProperties { get; set; }

        public int? RiErrorStatus { get; set; }

        [Required]
        [StringLength(50)]
        public string DefaultCrmCustomName { get; set; }

        public bool AppDesignerExperienceEnabled { get; set; }

        public bool ProductRecommendationsEnabled { get; set; }

        public bool PowerBiFeatureEnabled { get; set; }

        public bool EnableMicrosoftFlowIntegration { get; set; }

        public bool UnresolveEmailAddressIfMultipleMatch { get; set; }

        public int CurrentCategoryNumber { get; set; }

        public bool? IsDelveActionHubIntegrationEnabled { get; set; }

        [Required]
        [StringLength(20)]
        public string CategoryPrefix { get; set; }

        public bool IsActionCardEnabled { get; set; }

        public bool? IsActivityAnalysisEnabled { get; set; }

        public bool IsFolderAutoCreatedonSP { get; set; }

        public bool TextAnalyticsEnabled { get; set; }

        public bool IsPreviewEnabledForActionCard { get; set; }

        public bool IsConflictDetectionEnabledForMobileClient { get; set; }

        public bool IsMobileClientOnDemandSyncEnabled { get; set; }

        public bool IsAutoDataCaptureEnabled { get; set; }

        public int? MaximumSLAKPIPerEntityWithActiveSLA { get; set; }

        public int? MaxConditionsForMobileOfflineFilters { get; set; }

        public bool EnableLPAuthoring { get; set; }

        public bool OrgInsightsEnabled { get; set; }

        public bool? IsRelationshipInsightsEnabled { get; set; }

        [StringLength(500)]
        public string ACIWebEndpointUrl { get; set; }

        public bool IsEmailMonitoringAllowed { get; set; }

        public virtual CalendarBase CalendarBase { get; set; }

        public virtual EmailServerProfileBase EmailServerProfileBase { get; set; }

        public virtual MobileOfflineProfileBaseIds MobileOfflineProfileBaseIds { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }

        public virtual TemplateBaseIds TemplateBaseIds { get; set; }
    }
}
