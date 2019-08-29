namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ActivityPointerBase")]
    public partial class ActivityPointerBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ActivityPointerBase()
        {
            ActivityPartyBase = new HashSet<ActivityPartyBase>();
            ActivityPointerBase1 = new HashSet<ActivityPointerBase>();
            EmailHashBase = new HashSet<EmailHashBase>();
            RecurrenceRuleBase = new HashSet<RecurrenceRuleBase>();
            BulkOperationLogBase = new HashSet<BulkOperationLogBase>();
            EmailHashBase1 = new HashSet<EmailHashBase>();
            ActivityPointerBase11 = new HashSet<ActivityPointerBase>();
            CampaignActivityItemBase = new HashSet<CampaignActivityItemBase>();
            new_project_initiativeBase = new HashSet<new_project_initiativeBase>();
            new_project_initiative_valuationBase = new HashSet<new_project_initiative_valuationBase>();
            new_t_activityBase = new HashSet<new_t_activityBase>();
        }

        public Guid? OwningBusinessUnit { get; set; }

        public DateTime? ActualEnd { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Key]
        public Guid ActivityId { get; set; }

        public bool? IsBilled { get; set; }

        public Guid? CreatedBy { get; set; }

        public string Description { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? ServiceId { get; set; }

        public int ActivityTypeCode { get; set; }

        public int StateCode { get; set; }

        public DateTime? ScheduledEnd { get; set; }

        public int? ScheduledDurationMinutes { get; set; }

        public int? ActualDurationMinutes { get; set; }

        public int? StatusCode { get; set; }

        public DateTime? ActualStart { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int? PriorityCode { get; set; }

        public Guid? RegardingObjectId { get; set; }

        [StringLength(200)]
        public string Subject { get; set; }

        public bool? IsWorkflowCreated { get; set; }

        public DateTime? ScheduledStart { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int? RegardingObjectTypeCode { get; set; }

        [StringLength(4000)]
        public string RegardingObjectIdName { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        [StringLength(4000)]
        public string RegardingObjectIdYomiName { get; set; }

        public DateTime? RecApptMstrOverriddenCreatedOn { get; set; }

        [StringLength(300)]
        public string RecApptMstrGlobalObjectId { get; set; }

        public bool? SeriesStatus { get; set; }

        public int? RecApptMstrOutlookOwnerApptId { get; set; }

        public string DeletedExceptionsList { get; set; }

        public DateTime? NextExpansionInstanceDate { get; set; }

        [StringLength(200)]
        public string RecApptMstrLocation { get; set; }

        public Guid? GroupId { get; set; }

        public DateTime? LastExpandedInstanceDate { get; set; }

        public int? ExpansionStateCode { get; set; }

        [StringLength(250)]
        public string RecApptMstrCategory { get; set; }

        public bool? RecApptMstrIsAllDayEvent { get; set; }

        [StringLength(250)]
        public string RecApptMstrSubcategory { get; set; }

        public Guid? RecApptMstrSubscriptionId { get; set; }

        public int? RecApptMstrImportSequenceNumber { get; set; }

        public string ModifiedFieldsMask { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid OwnerId { get; set; }

        public int InstanceTypeCode { get; set; }

        public Guid? SeriesId { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public decimal? ExchangeRate { get; set; }

        public bool IsRegularActivity { get; set; }

        public DateTime? OriginalStartDate { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int OwnerIdType { get; set; }

        public DateTime? QteCloseOverriddenCreatedOn { get; set; }

        [StringLength(100)]
        public string QuoteNumber { get; set; }

        public int? QteCloseImportSequenceNumber { get; set; }

        [StringLength(250)]
        public string QteCloseCategory { get; set; }

        public int? QteCloseRevision { get; set; }

        [StringLength(250)]
        public string QteCloseSubcategory { get; set; }

        [StringLength(250)]
        public string ApptCategory { get; set; }

        [StringLength(300)]
        public string ApptGlobalObjectId { get; set; }

        public bool? ApptIsAllDayEvent { get; set; }

        public int? ApptImportSequenceNumber { get; set; }

        public int? ApptOutlookOwnerApptId { get; set; }

        public DateTime? ApptOverriddenCreatedOn { get; set; }

        [StringLength(250)]
        public string ApptSubcategory { get; set; }

        public Guid? ApptSubscriptionId { get; set; }

        [StringLength(200)]
        public string ApptLocation { get; set; }

        [Column(TypeName = "money")]
        public decimal? ActualCost_Base { get; set; }

        public int? CampActImportSequenceNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal? BudgetedCost_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? ActualCost { get; set; }

        public bool? IgnoreInactiveListMembers { get; set; }

        public bool? DoNotSendOnOptOut { get; set; }

        public int? TypeCode { get; set; }

        [StringLength(250)]
        public string CampActSubcategory { get; set; }

        public DateTime? CampActOverriddenCreatedOn { get; set; }

        public int? ExcludeIfContactedInXDays { get; set; }

        [StringLength(250)]
        public string CampActCategory { get; set; }

        [Column(TypeName = "money")]
        public decimal? BudgetedCost { get; set; }

        public int? CampActChannelTypeCode { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        public DateTime? ReceivedOn { get; set; }

        public int? ResponseCode { get; set; }

        [StringLength(150)]
        public string YomiLastName { get; set; }

        public DateTime? CampResOverriddenCreatedOn { get; set; }

        [StringLength(150)]
        public string YomiFirstName { get; set; }

        [StringLength(100)]
        public string CompanyName { get; set; }

        [StringLength(250)]
        public string CampResCategory { get; set; }

        [StringLength(50)]
        public string Telephone { get; set; }

        public Guid? OriginatingActivityId { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public int? CampResImportSequenceNumber { get; set; }

        public int? OriginatingActivityIdTypeCode { get; set; }

        [StringLength(100)]
        public string EMailAddress { get; set; }

        public int? CampResChannelTypeCode { get; set; }

        [StringLength(100)]
        public string YomiCompanyName { get; set; }

        [StringLength(250)]
        public string PromotionCodeName { get; set; }

        [StringLength(250)]
        public string CampResSubcategory { get; set; }

        public int? SuccessCount { get; set; }

        public int? OperationTypeCode { get; set; }

        [StringLength(32)]
        public string BulkOperationNumber { get; set; }

        public int? TargetMembersCount { get; set; }

        public int? CreatedRecordTypeCode { get; set; }

        public string Parameters { get; set; }

        public int? ErrorNumber { get; set; }

        public int? TargetedRecordTypeCode { get; set; }

        public int? FailureCount { get; set; }

        public bool? Compressed { get; set; }

        public bool? ReadReceiptRequested { get; set; }

        public bool? DeliveryReceiptRequested { get; set; }

        [StringLength(250)]
        public string EmailSubcategory { get; set; }

        public int? Notifications { get; set; }

        [StringLength(320)]
        public string MessageId { get; set; }

        [StringLength(250)]
        public string Sender { get; set; }

        [StringLength(500)]
        public string ToRecipients { get; set; }

        public DateTime? EmailOverriddenCreatedOn { get; set; }

        [StringLength(250)]
        public string SubmittedBy { get; set; }

        public int? EmailImportSequenceNumber { get; set; }

        public bool? EmailDirectionCode { get; set; }

        [StringLength(256)]
        public string MimeType { get; set; }

        public Guid? MessageIdDupCheck { get; set; }

        public int? DeliveryAttempts { get; set; }

        [StringLength(50)]
        public string TrackingToken { get; set; }

        [StringLength(250)]
        public string EmailCategory { get; set; }

        public int? SvcApptImportSequenceNumber { get; set; }

        [StringLength(500)]
        public string SvcApptLocation { get; set; }

        public bool? SvcApptIsAllDayEvent { get; set; }

        [StringLength(250)]
        public string SvcApptSubcategory { get; set; }

        public Guid? SiteId { get; set; }

        public DateTime? SvcApptOverriddenCreatedOn { get; set; }

        [StringLength(250)]
        public string SvcApptCategory { get; set; }

        public Guid? SvcApptSubscriptionId { get; set; }

        [StringLength(250)]
        public string TaskCategory { get; set; }

        public int? PercentComplete { get; set; }

        public DateTime? TaskOverriddenCreatedOn { get; set; }

        public Guid? TaskSubscriptionId { get; set; }

        [StringLength(250)]
        public string TaskSubcategory { get; set; }

        public int? TaskImportSequenceNumber { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        public int? LetterImportSequenceNumber { get; set; }

        public Guid? LetterSubscriptionId { get; set; }

        [StringLength(250)]
        public string LetterCategory { get; set; }

        [StringLength(250)]
        public string LetterSubcategory { get; set; }

        public bool? LetterDirectionCode { get; set; }

        public DateTime? LetterOverriddenCreatedOn { get; set; }

        public DateTime? PhoneOverriddenCreatedOn { get; set; }

        public int? PhoneImportSequenceNumber { get; set; }

        [StringLength(200)]
        public string PhoneNumber { get; set; }

        [StringLength(250)]
        public string PhoneSubcategory { get; set; }

        public bool? PhoneDirectionCode { get; set; }

        public Guid? PhoneSubscriptionId { get; set; }

        [StringLength(250)]
        public string PhoneCategory { get; set; }

        [StringLength(250)]
        public string OrdCloseSubcategory { get; set; }

        public int? OrdCloseImportSequenceNumber { get; set; }

        public int? OrdCloseRevision { get; set; }

        [StringLength(100)]
        public string OrderNumber { get; set; }

        [StringLength(250)]
        public string OrdCloseCategory { get; set; }

        public DateTime? OrdCloseOverriddenCreatedOn { get; set; }

        [StringLength(200)]
        public string FaxNumber { get; set; }

        [StringLength(100)]
        public string CoverPageName { get; set; }

        public int? NumberOfPages { get; set; }

        public Guid? FaxSubscriptionId { get; set; }

        public int? FaxImportSequenceNumber { get; set; }

        [StringLength(50)]
        public string BillingCode { get; set; }

        [StringLength(20)]
        public string Tsid { get; set; }

        public bool? FaxDirectionCode { get; set; }

        public DateTime? FaxOverriddenCreatedOn { get; set; }

        [StringLength(250)]
        public string FaxSubcategory { get; set; }

        [StringLength(250)]
        public string FaxCategory { get; set; }

        [StringLength(250)]
        public string IncResSubcategory { get; set; }

        [StringLength(250)]
        public string IncResCategory { get; set; }

        public int? IncResImportSequenceNumber { get; set; }

        public DateTime? IncResOverriddenCreatedOn { get; set; }

        public int? TimeSpent { get; set; }

        public Guid? CompetitorId { get; set; }

        public DateTime? OppCloseOverriddenCreatedOn { get; set; }

        public int? OppCloseImportSequenceNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal? ActualRevenue_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? ActualRevenue { get; set; }

        [StringLength(250)]
        public string OppCloseSubcategory { get; set; }

        [StringLength(250)]
        public string OppCloseCategory { get; set; }

        public int EmailAttachmentCount { get; set; }

        [StringLength(2048)]
        public string ConversationIndex { get; set; }

        [StringLength(320)]
        public string InReplyTo { get; set; }

        public int? CorrelationMethod { get; set; }

        public int? BaseConversationIndexHash { get; set; }

        public Guid? ParentActivityId { get; set; }

        public Guid? SenderMailboxId { get; set; }

        public bool? IsMapiPrivate { get; set; }

        public bool? LeftVoiceMail { get; set; }

        public DateTime? DeliveryLastAttemptedOn { get; set; }

        public Guid? StageId { get; set; }

        public int? DeliveryPriorityCode { get; set; }

        public DateTime? SentOn { get; set; }

        public DateTime? PostponeActivityProcessingUntil { get; set; }

        public Guid? ProcessId { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? ImportSequenceNumber { get; set; }

        [StringLength(200)]
        public string PostURL { get; set; }

        public DateTime? PostedOn { get; set; }

        public Guid? PostAuthor { get; set; }

        [StringLength(160)]
        public string ThreadId { get; set; }

        public int? PostMessageType { get; set; }

        public double? SentimentValue { get; set; }

        [StringLength(160)]
        public string PostId { get; set; }

        public Guid? PostFromProfileId { get; set; }

        [StringLength(200)]
        public string PostToProfileId { get; set; }

        public bool? SocialActivityDirectionCode { get; set; }

        [StringLength(160)]
        public string InResponseTo { get; set; }

        public string SocialAdditionalParams { get; set; }

        public Guid? PostAuthorAccount { get; set; }

        public int? PostAuthorType { get; set; }

        [StringLength(4000)]
        public string PostAuthorAccountName { get; set; }

        public int? PostAuthorAccountType { get; set; }

        [StringLength(4000)]
        public string PostAuthorName { get; set; }

        [StringLength(4000)]
        public string PostAuthorYomiName { get; set; }

        [StringLength(4000)]
        public string PostAuthorAccountYomiName { get; set; }

        public Guid? EmailSender { get; set; }

        public Guid? SendersAccount { get; set; }

        [StringLength(4000)]
        public string EmailSenderName { get; set; }

        [StringLength(4000)]
        public string SendersAccountName { get; set; }

        public int? EmailSenderObjectTypeCode { get; set; }

        public int? SendersAccountObjectTypeCode { get; set; }

        [StringLength(4000)]
        public string SendersAccountYomiName { get; set; }

        [StringLength(4000)]
        public string EmailSenderYomiName { get; set; }

        public Guid? CrmTaskAssignedUniqueId { get; set; }

        public int? Community { get; set; }

        [StringLength(1250)]
        public string TraversedPath { get; set; }

        public int? AttachmentErrors { get; set; }

        public int? IsUnsafe { get; set; }

        public Guid? CreatedByExternalParty { get; set; }

        public Guid? ModifiedByExternalParty { get; set; }

        public string ActivityAdditionalParams { get; set; }

        public DateTime? SortDate { get; set; }

        [StringLength(1250)]
        public string ExchangeWebLink { get; set; }

        [StringLength(200)]
        public string ExchangeItemId { get; set; }

        public int? OnHoldTime { get; set; }

        public Guid? SLAInvokedId { get; set; }

        public Guid? SLAId { get; set; }

        public DateTime? LastOnHoldTime { get; set; }

        public bool? FollowEmailUserPreference { get; set; }

        public bool? IsEmailFollowed { get; set; }

        public Guid? EmailTrackingId { get; set; }

        public int? ReplyCount { get; set; }

        public int? EmailReminderStatus { get; set; }

        public int? EmailReminderType { get; set; }

        public DateTime? DelayedEmailSendTime { get; set; }

        public Guid? ReminderActionCardId { get; set; }

        public int? OpenCount { get; set; }

        public DateTime? EmailReminderExpiryTime { get; set; }

        public DateTime? LastOpenedTime { get; set; }

        public Guid? TemplateId { get; set; }

        public int? LinksClickedCount { get; set; }

        public int? AttachmentOpenCount { get; set; }

        [StringLength(1250)]
        public string EmailReminderText { get; set; }

        public Guid? ConversationTrackingId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityPartyBase> ActivityPartyBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityPointerBase> ActivityPointerBase1 { get; set; }

        public virtual ActivityPointerBase ActivityPointerBase2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmailHashBase> EmailHashBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecurrenceRuleBase> RecurrenceRuleBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BulkOperationLogBase> BulkOperationLogBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase1 { get; set; }

        public virtual CompetitorBase CompetitorBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmailHashBase> EmailHashBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityPointerBase> ActivityPointerBase11 { get; set; }

        public virtual ActivityPointerBase ActivityPointerBase3 { get; set; }

        public virtual AppointmentBase AppointmentBase { get; set; }

        public virtual CampaignActivityBase CampaignActivityBase { get; set; }

        public virtual CampaignResponseBase CampaignResponseBase { get; set; }

        public virtual EmailBase EmailBase { get; set; }

        public virtual FaxBase FaxBase { get; set; }

        public virtual LetterBase LetterBase { get; set; }

        public virtual PhoneCallBase PhoneCallBase { get; set; }

        public virtual RecurringAppointmentMasterExtensionBase RecurringAppointmentMasterExtensionBase { get; set; }

        public virtual ServiceAppointmentBase ServiceAppointmentBase { get; set; }

        public virtual SocialActivityBase SocialActivityBase { get; set; }

        public virtual TaskBase TaskBase { get; set; }

        public virtual UntrackedEmailBase UntrackedEmailBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CampaignActivityItemBase> CampaignActivityItemBase { get; set; }

        public virtual SLABaseIds SLABaseIds { get; set; }

        public virtual SLABaseIds SLABaseIds1 { get; set; }

        public virtual SLABaseIds SLABaseIds2 { get; set; }

        public virtual SLABaseIds SLABaseIds3 { get; set; }

        public virtual SLABaseIds SLABaseIds4 { get; set; }

        public virtual SLABaseIds SLABaseIds5 { get; set; }

        public virtual SLABaseIds SLABaseIds6 { get; set; }

        public virtual SLABaseIds SLABaseIds7 { get; set; }

        public virtual SLABaseIds SLABaseIds8 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_initiativeBase> new_project_initiativeBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_initiative_valuationBase> new_project_initiative_valuationBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_activityBase> new_t_activityBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        public virtual ServiceBase ServiceBase { get; set; }

        public virtual SiteBase SiteBase { get; set; }

        public virtual SocialProfileBase SocialProfileBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase1 { get; set; }
    }
}
