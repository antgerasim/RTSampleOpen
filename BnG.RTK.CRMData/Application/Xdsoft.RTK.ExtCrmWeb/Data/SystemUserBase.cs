namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SystemUserBase")]
    public partial class SystemUserBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SystemUserBase()
        {
            AccountBase = new HashSet<AccountBase>();
            BookableResourceBase = new HashSet<BookableResourceBase>();
            ContactBase = new HashSet<ContactBase>();
            InvoiceDetailBase = new HashSet<InvoiceDetailBase>();
            KnowledgeArticleBase = new HashSet<KnowledgeArticleBase>();
            msdyn_wallsavedqueryusersettingsBase = new HashSet<msdyn_wallsavedqueryusersettingsBase>();
            new_businessunit_roleBase = new HashSet<new_businessunit_roleBase>();
            new_new_project_initiative_valuation_systemBase = new HashSet<new_new_project_initiative_valuation_systemBase>();
            new_project_initiative_valuationBase = new HashSet<new_project_initiative_valuationBase>();
            new_project_initiative_valuationBase1 = new HashSet<new_project_initiative_valuationBase>();
            new_t_projectBase = new HashSet<new_t_projectBase>();
            OwnerMappingBase = new HashSet<OwnerMappingBase>();
            PluginTypeStatisticBase = new HashSet<PluginTypeStatisticBase>();
            PluginTypeStatisticBase1 = new HashSet<PluginTypeStatisticBase>();
            QueueBase = new HashSet<QueueBase>();
            QueueMembership = new HashSet<QueueMembership>();
            QuoteDetailBase = new HashSet<QuoteDetailBase>();
            SalesLiteratureBase = new HashSet<SalesLiteratureBase>();
            SalesOrderDetailBase = new HashSet<SalesOrderDetailBase>();
            SdkMessageBase = new HashSet<SdkMessageBase>();
            SdkMessageBase1 = new HashSet<SdkMessageBase>();
            SdkMessageBase2 = new HashSet<SdkMessageBase>();
            SdkMessageBase3 = new HashSet<SdkMessageBase>();
            SdkMessageFilterBase = new HashSet<SdkMessageFilterBase>();
            SdkMessageFilterBase1 = new HashSet<SdkMessageFilterBase>();
            SdkMessageFilterBase2 = new HashSet<SdkMessageFilterBase>();
            SdkMessageFilterBase3 = new HashSet<SdkMessageFilterBase>();
            SdkMessagePairBase = new HashSet<SdkMessagePairBase>();
            SdkMessagePairBase1 = new HashSet<SdkMessagePairBase>();
            SdkMessagePairBase2 = new HashSet<SdkMessagePairBase>();
            SdkMessagePairBase3 = new HashSet<SdkMessagePairBase>();
            SdkMessageRequestBase = new HashSet<SdkMessageRequestBase>();
            SdkMessageRequestBase1 = new HashSet<SdkMessageRequestBase>();
            SdkMessageRequestBase2 = new HashSet<SdkMessageRequestBase>();
            SdkMessageRequestBase3 = new HashSet<SdkMessageRequestBase>();
            SdkMessageRequestFieldBase = new HashSet<SdkMessageRequestFieldBase>();
            SdkMessageRequestFieldBase1 = new HashSet<SdkMessageRequestFieldBase>();
            SdkMessageRequestFieldBase2 = new HashSet<SdkMessageRequestFieldBase>();
            SdkMessageRequestFieldBase3 = new HashSet<SdkMessageRequestFieldBase>();
            SdkMessageResponseBase = new HashSet<SdkMessageResponseBase>();
            SdkMessageResponseBase1 = new HashSet<SdkMessageResponseBase>();
            SdkMessageResponseBase2 = new HashSet<SdkMessageResponseBase>();
            SdkMessageResponseBase3 = new HashSet<SdkMessageResponseBase>();
            SdkMessageResponseFieldBase = new HashSet<SdkMessageResponseFieldBase>();
            SdkMessageResponseFieldBase1 = new HashSet<SdkMessageResponseFieldBase>();
            SdkMessageResponseFieldBase2 = new HashSet<SdkMessageResponseFieldBase>();
            SdkMessageResponseFieldBase3 = new HashSet<SdkMessageResponseFieldBase>();
            TaskBase = new HashSet<TaskBase>();
            SystemUserPrincipals = new HashSet<SystemUserPrincipals>();
            UserFiscalCalendarBase = new HashSet<UserFiscalCalendarBase>();
            SystemUserRoles = new HashSet<SystemUserRoles>();
            TeamMembership = new HashSet<TeamMembership>();
            TerritoryBase = new HashSet<TerritoryBase>();
            SystemUserProfiles = new HashSet<SystemUserProfiles>();
            SystemUserSyncMappingProfiles = new HashSet<SystemUserSyncMappingProfiles>();
            SystemUserBusinessUnitEntityMap = new HashSet<SystemUserBusinessUnitEntityMap>();
            SystemUserBase1 = new HashSet<SystemUserBase>();
        }

        [Key]
        public Guid SystemUserId { get; set; }

        public Guid? TerritoryId { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid BusinessUnitId { get; set; }

        public Guid? ParentSystemUserId { get; set; }

        [StringLength(64)]
        public string FirstName { get; set; }

        [StringLength(20)]
        public string Salutation { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        [StringLength(64)]
        public string LastName { get; set; }

        [StringLength(100)]
        public string PersonalEMailAddress { get; set; }

        [StringLength(200)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string NickName { get; set; }

        [StringLength(128)]
        public string Title { get; set; }

        [StringLength(100)]
        public string InternalEMailAddress { get; set; }

        [StringLength(100)]
        public string JobTitle { get; set; }

        [StringLength(100)]
        public string MobileAlertEMail { get; set; }

        public int? PreferredEmailCode { get; set; }

        [StringLength(50)]
        public string HomePhone { get; set; }

        [StringLength(64)]
        public string MobilePhone { get; set; }

        public int? PreferredPhoneCode { get; set; }

        public int? PreferredAddressCode { get; set; }

        [StringLength(200)]
        public string PhotoUrl { get; set; }

        [Required]
        [StringLength(1024)]
        public string DomainName { get; set; }

        public int? PassportLo { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int? PassportHi { get; set; }

        [StringLength(500)]
        public string DisabledReason { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        [StringLength(100)]
        public string EmployeeId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public bool? IsDisabled { get; set; }

        [StringLength(100)]
        public string GovernmentId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [StringLength(100)]
        public string Skills { get; set; }

        public bool? DisplayInServiceViews { get; set; }

        public Guid? CalendarId { get; set; }

        public Guid? ActiveDirectoryGuid { get; set; }

        public bool SetupUser { get; set; }

        public Guid? SiteId { get; set; }

        [StringLength(1024)]
        public string WindowsLiveID { get; set; }

        public int IncomingEmailDeliveryMethod { get; set; }

        public int OutgoingEmailDeliveryMethod { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public int AccessMode { get; set; }

        public int? InviteStatusCode { get; set; }

        public bool IsActiveDirectoryUser { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        [StringLength(200)]
        public string YomiFullName { get; set; }

        [StringLength(64)]
        public string YomiLastName { get; set; }

        [StringLength(50)]
        public string YomiMiddleName { get; set; }

        [StringLength(64)]
        public string YomiFirstName { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public decimal? ExchangeRate { get; set; }

        public bool IsIntegrationUser { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int EmailRouterAccessApproval { get; set; }

        public bool DefaultFiltersPopulated { get; set; }

        public int CALType { get; set; }

        public Guid? QueueId { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        [StringLength(100)]
        public string YammerEmailAddress { get; set; }

        public bool IsSyncWithDirectory { get; set; }

        public Guid? DefaultMailbox { get; set; }

        public Guid? ProcessId { get; set; }

        public int UserLicenseType { get; set; }

        public bool IsEmailAddressApprovedByO365Admin { get; set; }

        [StringLength(64)]
        public string YammerUserId { get; set; }

        public Guid? EntityImageId { get; set; }

        public bool IsLicensed { get; set; }

        public Guid? StageId { get; set; }

        public Guid? PositionId { get; set; }

        [StringLength(1250)]
        public string TraversedPath { get; set; }

        public Guid? MobileOfflineProfileId { get; set; }

        [Required]
        [StringLength(200)]
        public string DefaultOdbFolderName { get; set; }

        [StringLength(1024)]
        public string SharePointEmailAddress { get; set; }

        [StringLength(1024)]
        public string ApplicationIdUri { get; set; }

        public Guid? AzureActiveDirectoryObjectId { get; set; }

        public Guid? ApplicationId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountBase> AccountBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookableResourceBase> BookableResourceBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual CalendarBase CalendarBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactBase> ContactBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceDetailBase> InvoiceDetailBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KnowledgeArticleBase> KnowledgeArticleBase { get; set; }

        public virtual MailboxBase MailboxBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<msdyn_wallsavedqueryusersettingsBase> msdyn_wallsavedqueryusersettingsBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_businessunit_roleBase> new_businessunit_roleBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_new_project_initiative_valuation_systemBase> new_new_project_initiative_valuation_systemBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_initiative_valuationBase> new_project_initiative_valuationBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_initiative_valuationBase> new_project_initiative_valuationBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_projectBase> new_t_projectBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OwnerMappingBase> OwnerMappingBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PluginTypeStatisticBase> PluginTypeStatisticBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PluginTypeStatisticBase> PluginTypeStatisticBase1 { get; set; }

        public virtual PositionBase PositionBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QueueBase> QueueBase { get; set; }

        public virtual QueueBase QueueBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QueueMembership> QueueMembership { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuoteDetailBase> QuoteDetailBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesLiteratureBase> SalesLiteratureBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderDetailBase> SalesOrderDetailBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessageBase> SdkMessageBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessageBase> SdkMessageBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessageBase> SdkMessageBase2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessageBase> SdkMessageBase3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessageFilterBase> SdkMessageFilterBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessageFilterBase> SdkMessageFilterBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessageFilterBase> SdkMessageFilterBase2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessageFilterBase> SdkMessageFilterBase3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessagePairBase> SdkMessagePairBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessagePairBase> SdkMessagePairBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessagePairBase> SdkMessagePairBase2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessagePairBase> SdkMessagePairBase3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessageRequestBase> SdkMessageRequestBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessageRequestBase> SdkMessageRequestBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessageRequestBase> SdkMessageRequestBase2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessageRequestBase> SdkMessageRequestBase3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessageRequestFieldBase> SdkMessageRequestFieldBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessageRequestFieldBase> SdkMessageRequestFieldBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessageRequestFieldBase> SdkMessageRequestFieldBase2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessageRequestFieldBase> SdkMessageRequestFieldBase3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessageResponseBase> SdkMessageResponseBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessageResponseBase> SdkMessageResponseBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessageResponseBase> SdkMessageResponseBase2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessageResponseBase> SdkMessageResponseBase3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessageResponseFieldBase> SdkMessageResponseFieldBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessageResponseFieldBase> SdkMessageResponseFieldBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessageResponseFieldBase> SdkMessageResponseFieldBase2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessageResponseFieldBase> SdkMessageResponseFieldBase3 { get; set; }

        public virtual SiteBase SiteBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskBase> TaskBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SystemUserPrincipals> SystemUserPrincipals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserFiscalCalendarBase> UserFiscalCalendarBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SystemUserRoles> SystemUserRoles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeamMembership> TeamMembership { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TerritoryBase> TerritoryBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SystemUserProfiles> SystemUserProfiles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SystemUserSyncMappingProfiles> SystemUserSyncMappingProfiles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SystemUserBusinessUnitEntityMap> SystemUserBusinessUnitEntityMap { get; set; }

        public virtual TerritoryBase TerritoryBase1 { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SystemUserBase> SystemUserBase1 { get; set; }

        public virtual SystemUserBase SystemUserBase2 { get; set; }

        public virtual UserSettingsBase UserSettingsBase { get; set; }
    }
}
