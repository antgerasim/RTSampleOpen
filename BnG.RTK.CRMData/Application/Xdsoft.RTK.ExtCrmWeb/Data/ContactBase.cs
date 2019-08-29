namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactBase")]
    public partial class ContactBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContactBase()
        {
            AccountBase = new HashSet<AccountBase>();
            BookableResourceBase = new HashSet<BookableResourceBase>();
            IncidentBase = new HashSet<IncidentBase>();
            IncidentBase1 = new HashSet<IncidentBase>();
            EntitlementBase = new HashSet<EntitlementBase>();
            EntitlementContacts = new HashSet<EntitlementContacts>();
            ContactInvoices = new HashSet<ContactInvoices>();
            ContactLeads = new HashSet<ContactLeads>();
            ContactBase1 = new HashSet<ContactBase>();
            ContactOrders = new HashSet<ContactOrders>();
            ContactQuotes = new HashSet<ContactQuotes>();
            ServiceContractContacts = new HashSet<ServiceContractContacts>();
            LeadBase1 = new HashSet<LeadBase>();
            FeedbackBase = new HashSet<FeedbackBase>();
            FeedbackBase1 = new HashSet<FeedbackBase>();
            OpportunityBase = new HashSet<OpportunityBase>();
        }

        [Key]
        public Guid ContactId { get; set; }

        public Guid? DefaultPriceLevelId { get; set; }

        public int? CustomerSizeCode { get; set; }

        public int? CustomerTypeCode { get; set; }

        public int? PreferredContactMethodCode { get; set; }

        public int? LeadSourceCode { get; set; }

        public Guid? OriginatingLeadId { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public int? PaymentTermsCode { get; set; }

        public int? ShippingMethodCode { get; set; }

        public bool? ParticipatesInWorkflow { get; set; }

        public bool? IsBackofficeCustomer { get; set; }

        [StringLength(100)]
        public string Salutation { get; set; }

        [StringLength(100)]
        public string JobTitle { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string Department { get; set; }

        [StringLength(50)]
        public string NickName { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(10)]
        public string Suffix { get; set; }

        [StringLength(150)]
        public string YomiFirstName { get; set; }

        [StringLength(160)]
        public string FullName { get; set; }

        [StringLength(150)]
        public string YomiMiddleName { get; set; }

        [StringLength(150)]
        public string YomiLastName { get; set; }

        public DateTime? Anniversary { get; set; }

        public DateTime? BirthDate { get; set; }

        [StringLength(50)]
        public string GovernmentId { get; set; }

        [StringLength(450)]
        public string YomiFullName { get; set; }

        public string Description { get; set; }

        [StringLength(50)]
        public string EmployeeId { get; set; }

        public int? GenderCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? AnnualIncome { get; set; }

        public int? HasChildrenCode { get; set; }

        public int? EducationCode { get; set; }

        [StringLength(200)]
        public string WebSiteUrl { get; set; }

        public int? FamilyStatusCode { get; set; }

        [StringLength(200)]
        public string FtpSiteUrl { get; set; }

        [StringLength(100)]
        public string EMailAddress1 { get; set; }

        [StringLength(100)]
        public string SpousesName { get; set; }

        [StringLength(100)]
        public string AssistantName { get; set; }

        [StringLength(100)]
        public string EMailAddress2 { get; set; }

        [StringLength(50)]
        public string AssistantPhone { get; set; }

        [StringLength(100)]
        public string EMailAddress3 { get; set; }

        public bool? DoNotPhone { get; set; }

        [StringLength(100)]
        public string ManagerName { get; set; }

        [StringLength(50)]
        public string ManagerPhone { get; set; }

        public bool? DoNotFax { get; set; }

        public bool? DoNotEMail { get; set; }

        public bool? DoNotPostalMail { get; set; }

        public bool? DoNotBulkEMail { get; set; }

        public bool? DoNotBulkPostalMail { get; set; }

        public int? AccountRoleCode { get; set; }

        public int? TerritoryCode { get; set; }

        public bool? IsPrivate { get; set; }

        [Column(TypeName = "money")]
        public decimal? CreditLimit { get; set; }

        public DateTime? CreatedOn { get; set; }

        public bool? CreditOnHold { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int? NumberOfChildren { get; set; }

        [StringLength(255)]
        public string ChildrensNames { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [StringLength(50)]
        public string MobilePhone { get; set; }

        [StringLength(50)]
        public string Pager { get; set; }

        [StringLength(50)]
        public string Telephone1 { get; set; }

        [StringLength(50)]
        public string Telephone2 { get; set; }

        [StringLength(50)]
        public string Telephone3 { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [Column(TypeName = "money")]
        public decimal? Aging30 { get; set; }

        public int StateCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? Aging60 { get; set; }

        public int? StatusCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? Aging90 { get; set; }

        public Guid? PreferredSystemUserId { get; set; }

        public Guid? PreferredServiceId { get; set; }

        public Guid? MasterId { get; set; }

        public int? PreferredAppointmentDayCode { get; set; }

        public int? PreferredAppointmentTimeCode { get; set; }

        public bool? DoNotSendMM { get; set; }

        public bool? Merged { get; set; }

        [StringLength(50)]
        public string ExternalUserIdentifier { get; set; }

        public Guid? SubscriptionId { get; set; }

        public Guid? PreferredEquipmentId { get; set; }

        public DateTime? LastUsedInCampaign { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public decimal? ExchangeRate { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? AnnualIncome_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? CreditLimit_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? Aging60_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? Aging90_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? Aging30_Base { get; set; }

        public Guid OwnerId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public bool? IsAutoCreate { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? ParentCustomerId { get; set; }

        public int? ParentCustomerIdType { get; set; }

        [StringLength(4000)]
        public string ParentCustomerIdName { get; set; }

        public int OwnerIdType { get; set; }

        [StringLength(4000)]
        public string ParentCustomerIdYomiName { get; set; }

        public Guid? ProcessId { get; set; }

        public Guid? EntityImageId { get; set; }

        public Guid? StageId { get; set; }

        [StringLength(50)]
        public string Business2 { get; set; }

        [StringLength(50)]
        public string Company { get; set; }

        [StringLength(1250)]
        public string TraversedPath { get; set; }

        [StringLength(50)]
        public string Home2 { get; set; }

        [StringLength(50)]
        public string Callback { get; set; }

        public Guid? CreatedByExternalParty { get; set; }

        public Guid? ModifiedByExternalParty { get; set; }

        public DateTime? LastOnHoldTime { get; set; }

        public Guid? SLAId { get; set; }

        [StringLength(1250)]
        public string TimeSpentByMeOnEmailAndMeetings { get; set; }

        public int? OnHoldTime { get; set; }

        public bool? FollowEmail { get; set; }

        public Guid? SLAInvokedId { get; set; }

        public bool? MarketingOnly { get; set; }

        public Guid? new_link_contact_Id { get; set; }

        public int? new_Contact_Code { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountBase> AccountBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookableResourceBase> BookableResourceBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IncidentBase> IncidentBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IncidentBase> IncidentBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntitlementBase> EntitlementBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntitlementContacts> EntitlementContacts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactInvoices> ContactInvoices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactLeads> ContactLeads { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactBase> ContactBase1 { get; set; }

        public virtual ContactBase ContactBase2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactOrders> ContactOrders { get; set; }

        public virtual LeadBase LeadBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactQuotes> ContactQuotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceContractContacts> ServiceContractContacts { get; set; }

        public virtual EquipmentBase EquipmentBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeadBase> LeadBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FeedbackBase> FeedbackBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FeedbackBase> FeedbackBase1 { get; set; }

        public virtual SLABaseIds SLABaseIds { get; set; }

        public virtual new_t_activityBase new_t_activityBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpportunityBase> OpportunityBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        public virtual PriceLevelBase PriceLevelBase { get; set; }

        public virtual ServiceBase ServiceBase { get; set; }

        public virtual SystemUserBase SystemUserBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
