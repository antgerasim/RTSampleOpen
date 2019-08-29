namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MailboxBase")]
    public partial class MailboxBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MailboxBase()
        {
            QueueBase = new HashSet<QueueBase>();
            SystemUserBase = new HashSet<SystemUserBase>();
        }

        public int ProcessingStateCode { get; set; }

        public int? ACTDeliveryMethod { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public int? OutgoingEmailDeliveryMethod { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int? NoEmailCount { get; set; }

        [Key]
        public Guid MailboxId { get; set; }

        public bool EnabledForIncomingEmail { get; set; }

        public int? NoACTCount { get; set; }

        [StringLength(100)]
        public string EmailAddress { get; set; }

        public DateTime? ReceivingPostponedUntil { get; set; }

        public int? OutgoingEmailStatus { get; set; }

        public Guid OrganizationId { get; set; }

        public int? MailboxProcessingContext { get; set; }

        public int EmailRouterAccessApproval { get; set; }

        public int? IncomingEmailDeliveryMethod { get; set; }

        public DateTime? PostponeTestEmailConfigurationUntil { get; set; }

        public Guid? EmailServerProfile { get; set; }

        public bool EnabledForACT { get; set; }

        public DateTime? TestMailboxAccessCompletedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int StateCode { get; set; }

        public DateTime? ProcessEmailReceivedAfter { get; set; }

        public DateTime PostponeMailboxProcessingUntil { get; set; }

        public Guid OwnerId { get; set; }

        public DateTime LastActiveOn { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public DateTime? LastAutoDiscoveredOn { get; set; }

        public bool? TestEmailConfigurationScheduled { get; set; }

        public bool IsEmailAddressApprovedByO365Admin { get; set; }

        public Guid? ModifiedBy { get; set; }

        public byte[] Password { get; set; }

        public string ExchangeSyncStateXml { get; set; }

        public bool? ProcessAndDeleteEmails { get; set; }

        public Guid? RegardingObjectId { get; set; }

        public Guid? EntityImageId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int StatusCode { get; set; }

        public DateTime? ReceivingPostponedUntilForACT { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [StringLength(256)]
        public string UndeliverableFolder { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public bool IsForwardMailbox { get; set; }

        public DateTime PostponeSendingUntil { get; set; }

        public int TestEmailConfigurationRetryCount { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public bool? AllowEmailConnectorToUseCredentials { get; set; }

        [StringLength(256)]
        public string HostId { get; set; }

        [StringLength(320)]
        public string LastMessageId { get; set; }

        public int? IncomingEmailStatus { get; set; }

        [StringLength(200)]
        public string Username { get; set; }

        public Guid? CreatedBy { get; set; }

        [StringLength(1042)]
        public string EWSURL { get; set; }

        public int TransientFailureCount { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public bool? IsACTSyncOrgFlagSet { get; set; }

        public int? ACTStatus { get; set; }

        public bool EnabledForOutgoingEmail { get; set; }

        [StringLength(4000)]
        public string RegardingObjectIdName { get; set; }

        public int? RegardingObjectTypeCode { get; set; }

        public int OwnerIdType { get; set; }

        public DateTime? LastSuccessfulSyncCompletedOn { get; set; }

        public int? ProcessedTimes { get; set; }

        public int? AverageTotalDuration { get; set; }

        public DateTime? LastSyncErrorOccurredOn { get; set; }

        public int? ItemsFailedForLastSync { get; set; }

        [StringLength(160)]
        public string LastSyncErrorMachineName { get; set; }

        public int? LastSyncErrorCode { get; set; }

        public int? ItemsProcessedForLastSync { get; set; }

        public DateTime? LastSyncStartedOn { get; set; }

        [StringLength(1024)]
        public string LastSyncError { get; set; }

        public int? LastSyncErrorCount { get; set; }

        public bool? OrgMarkedAsPrimaryForExchangeSync { get; set; }

        public int? LastDuration { get; set; }

        public int ForcedUnlockCount { get; set; }

        public DateTime? ProcessingLastAttemptedOn { get; set; }

        public bool IsServiceAccount { get; set; }

        public int VerboseLoggingEnabled { get; set; }

        public string FolderHierarchy { get; set; }

        public DateTime? LastMailboxForcedUnlockOccurredOn { get; set; }

        public DateTime? OfficeAppsDeploymentCompleteOn { get; set; }

        public DateTime? PostponeOfficeAppsDeploymentUntil { get; set; }

        public bool? OfficeAppsDeploymentScheduled { get; set; }

        [StringLength(1024)]
        public string OfficeAppsDeploymentError { get; set; }

        public int? OfficeAppsDeploymentStatus { get; set; }

        public int? MailboxStatus { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual EmailServerProfileBase EmailServerProfileBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QueueBase> QueueBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SystemUserBase> SystemUserBase { get; set; }
    }
}
