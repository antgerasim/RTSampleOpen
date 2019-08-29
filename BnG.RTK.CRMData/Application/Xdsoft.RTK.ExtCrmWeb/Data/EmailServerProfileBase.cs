namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmailServerProfileBase")]
    public partial class EmailServerProfileBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmailServerProfileBase()
        {
            MailboxBase = new HashSet<MailboxBase>();
            OrganizationBase = new HashSet<OrganizationBase>();
        }

        [StringLength(250)]
        public string IncomingUserName { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public int StateCode { get; set; }

        public Guid? IncomingPartnerApplication { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public bool? IncomingUseImpersonation { get; set; }

        public int? ServerType { get; set; }

        public DateTime? ProcessEmailsReceivedAfter { get; set; }

        public int? IncomingAuthenticationProtocol { get; set; }

        [StringLength(1042)]
        public string OutgoingServerLocation { get; set; }

        public bool? UseSameSettingsForOutgoingConnections { get; set; }

        public bool? OutgoingAutoGrantDelegateAccess { get; set; }

        public int? StatusCode { get; set; }

        public Guid? EntityImageId { get; set; }

        [StringLength(100)]
        public string EncodingCodePage { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int? IncomingCredentialRetrieval { get; set; }

        public bool? MoveUndeliveredEmails { get; set; }

        public Guid? CreatedBy { get; set; }

        [Key]
        public Guid EmailServerProfileId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? OutgoingUseSSL { get; set; }

        public int? OutgoingPortNumber { get; set; }

        public Guid OwnerId { get; set; }

        public bool? IncomingUseSSL { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int? IncomingPortNumber { get; set; }

        [StringLength(250)]
        public string OutgoingUsername { get; set; }

        public string Description { get; set; }

        public Guid OrganizationId { get; set; }

        public int? OutgoingCredentialRetrieval { get; set; }

        [StringLength(1042)]
        public string IncomingServerLocation { get; set; }

        public int? MaxConcurrentConnections { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public Guid? OutgoingPartnerApplication { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public byte[] OutgoingPassword { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int? ExchangeVersion { get; set; }

        public int? MinPollingIntervalInMinutes { get; set; }

        public bool? OutgoingUseImpersonation { get; set; }

        public bool? UseAutoDiscover { get; set; }

        public byte[] IncomingPassword { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int? OutgoingAuthenticationProtocol { get; set; }

        public int OwnerIdType { get; set; }

        [StringLength(250)]
        public string OwnerEmailAddress { get; set; }

        public bool? SendEmailAlert { get; set; }

        public int? LastTestValidationStatus { get; set; }

        public DateTime? LastTestStartTime { get; set; }

        public string LastTestResponse { get; set; }

        public int? LastTestExecutionStatus { get; set; }

        public string LastTestRequest { get; set; }

        public bool? TimeoutMailboxConnection { get; set; }

        public long? LastTestTotalExecutionTime { get; set; }

        public int? TimeoutMailboxConnectionAfterAmount { get; set; }

        [StringLength(250)]
        public string EmailServerTypeName { get; set; }

        [StringLength(36)]
        public string ExchangeOnlineTenantId { get; set; }

        [StringLength(1042)]
        public string DefaultServerLocation { get; set; }

        public bool? UseDefaultTenantId { get; set; }

        public int? LastAuthorizationStatus { get; set; }

        public string LastCrmMessage { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MailboxBase> MailboxBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationBase> OrganizationBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
