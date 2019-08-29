namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LeadBase")]
    public partial class LeadBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LeadBase()
        {
            AccountBase = new HashSet<AccountBase>();
            AccountLeads = new HashSet<AccountLeads>();
            ContactBase = new HashSet<ContactBase>();
            ContactLeads = new HashSet<ContactLeads>();
            LeadAddressBase = new HashSet<LeadAddressBase>();
            LeadCompetitors = new HashSet<LeadCompetitors>();
            LeadBase1 = new HashSet<LeadBase>();
            OpportunityBase1 = new HashSet<OpportunityBase>();
            LeadProduct = new HashSet<LeadProduct>();
        }

        [Key]
        public Guid LeadId { get; set; }

        public int? LeadSourceCode { get; set; }

        public int? LeadQualityCode { get; set; }

        public int? PriorityCode { get; set; }

        public int? IndustryCode { get; set; }

        public int? PreferredContactMethodCode { get; set; }

        public int? SalesStageCode { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        [StringLength(300)]
        public string Subject { get; set; }

        public bool? ParticipatesInWorkflow { get; set; }

        public string Description { get; set; }

        public double? EstimatedValue { get; set; }

        public DateTime? EstimatedCloseDate { get; set; }

        [StringLength(100)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [Column(TypeName = "money")]
        public decimal? Revenue { get; set; }

        public int? NumberOfEmployees { get; set; }

        public bool? DoNotPhone { get; set; }

        [StringLength(20)]
        public string SIC { get; set; }

        public bool? DoNotFax { get; set; }

        [StringLength(100)]
        public string EMailAddress1 { get; set; }

        [StringLength(100)]
        public string JobTitle { get; set; }

        [StringLength(100)]
        public string Salutation { get; set; }

        public bool? DoNotEMail { get; set; }

        [StringLength(100)]
        public string EMailAddress2 { get; set; }

        public bool? DoNotPostalMail { get; set; }

        [StringLength(100)]
        public string EMailAddress3 { get; set; }

        [StringLength(160)]
        public string FullName { get; set; }

        [StringLength(150)]
        public string YomiFirstName { get; set; }

        [StringLength(200)]
        public string WebSiteUrl { get; set; }

        [StringLength(50)]
        public string Telephone1 { get; set; }

        [StringLength(50)]
        public string Telephone2 { get; set; }

        [StringLength(50)]
        public string Telephone3 { get; set; }

        public DateTime? CreatedOn { get; set; }

        public bool? IsPrivate { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(150)]
        public string YomiMiddleName { get; set; }

        [StringLength(150)]
        public string YomiLastName { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        [StringLength(450)]
        public string YomiFullName { get; set; }

        [StringLength(20)]
        public string MobilePhone { get; set; }

        public int StateCode { get; set; }

        [StringLength(20)]
        public string Pager { get; set; }

        public int? StatusCode { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? MasterId { get; set; }

        public Guid? CampaignId { get; set; }

        public bool? DoNotSendMM { get; set; }

        public bool? Merged { get; set; }

        public bool? DoNotBulkEMail { get; set; }

        public DateTime? LastUsedInCampaign { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public decimal? ExchangeRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? EstimatedAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? EstimatedAmount_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? Revenue_Base { get; set; }

        [StringLength(100)]
        public string YomiCompanyName { get; set; }

        public bool? IsAutoCreate { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid OwnerId { get; set; }

        public Guid? CustomerId { get; set; }

        public int? CustomerIdType { get; set; }

        [StringLength(4000)]
        public string CustomerIdName { get; set; }

        public int OwnerIdType { get; set; }

        [StringLength(4000)]
        public string CustomerIdYomiName { get; set; }

        public Guid? StageId { get; set; }

        public bool? DecisionMaker { get; set; }

        public int? Need { get; set; }

        [Column(TypeName = "money")]
        public decimal? BudgetAmount { get; set; }

        public string QualificationComments { get; set; }

        public Guid? QualifyingOpportunityId { get; set; }

        public DateTime? ScheduleFollowUp_Qualify { get; set; }

        public bool? ConfirmInterest { get; set; }

        public Guid? ParentAccountId { get; set; }

        public Guid? OriginatingCaseId { get; set; }

        public DateTime? ScheduleFollowUp_Prospect { get; set; }

        public Guid? EntityImageId { get; set; }

        public Guid? ParentContactId { get; set; }

        public int? InitialCommunication { get; set; }

        public int? SalesStage { get; set; }

        public int? BudgetStatus { get; set; }

        public Guid? ProcessId { get; set; }

        public int? PurchaseTimeFrame { get; set; }

        public int? PurchaseProcess { get; set; }

        public Guid? RelatedObjectId { get; set; }

        public bool? EvaluateFit { get; set; }

        [Column(TypeName = "money")]
        public decimal? BudgetAmount_Base { get; set; }

        [StringLength(1250)]
        public string TraversedPath { get; set; }

        public bool? FollowEmail { get; set; }

        public Guid? SLAInvokedId { get; set; }

        [StringLength(1250)]
        public string TimeSpentByMeOnEmailAndMeetings { get; set; }

        public Guid? SLAId { get; set; }

        public int? OnHoldTime { get; set; }

        public DateTime? LastOnHoldTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountBase> AccountBase { get; set; }

        public virtual AccountBase AccountBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountLeads> AccountLeads { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual CampaignBase CampaignBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactBase> ContactBase { get; set; }

        public virtual ContactBase ContactBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactLeads> ContactLeads { get; set; }

        public virtual IncidentBase IncidentBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeadAddressBase> LeadAddressBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeadCompetitors> LeadCompetitors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeadBase> LeadBase1 { get; set; }

        public virtual LeadBase LeadBase2 { get; set; }

        public virtual OpportunityBase OpportunityBase { get; set; }

        public virtual SLABaseIds SLABaseIds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpportunityBase> OpportunityBase1 { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeadProduct> LeadProduct { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
