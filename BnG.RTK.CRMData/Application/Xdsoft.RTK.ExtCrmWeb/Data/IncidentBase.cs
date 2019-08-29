namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IncidentBase")]
    public partial class IncidentBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IncidentBase()
        {
            IncidentKnowledgeBaseRecord = new HashSet<IncidentKnowledgeBaseRecord>();
            KnowledgeArticleIncidentBase = new HashSet<KnowledgeArticleIncidentBase>();
            LeadBase = new HashSet<LeadBase>();
        }

        [Key]
        public Guid IncidentId { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public Guid? ContractDetailId { get; set; }

        public Guid? SubjectId { get; set; }

        public Guid? ContractId { get; set; }

        public int? ActualServiceUnits { get; set; }

        public int? CaseOriginCode { get; set; }

        public int? BilledServiceUnits { get; set; }

        public int? CaseTypeCode { get; set; }

        [StringLength(100)]
        public string ProductSerialNumber { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        public Guid? ProductId { get; set; }

        public int? ContractServiceLevelCode { get; set; }

        public string Description { get; set; }

        public bool? IsDecrementing { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(100)]
        public string TicketNumber { get; set; }

        public int? PriorityCode { get; set; }

        public int? CustomerSatisfactionCode { get; set; }

        public int? IncidentStageCode { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? FollowupBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int StateCode { get; set; }

        public int? SeverityCode { get; set; }

        public int? StatusCode { get; set; }

        public Guid? ResponsibleContactId { get; set; }

        public Guid? KbArticleId { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public decimal? ExchangeRate { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? CustomerId { get; set; }

        public Guid OwnerId { get; set; }

        public int OwnerIdType { get; set; }

        public int? CustomerIdType { get; set; }

        [StringLength(4000)]
        public string CustomerIdName { get; set; }

        [StringLength(4000)]
        public string CustomerIdYomiName { get; set; }

        public bool? ActivitiesComplete { get; set; }

        public Guid? StageId { get; set; }

        public Guid? ExistingCase { get; set; }

        public int? ServiceStage { get; set; }

        public bool? CheckEmail { get; set; }

        public bool? FollowUpTaskCreated { get; set; }

        public Guid? EntityImageId { get; set; }

        public Guid? ProcessId { get; set; }

        [StringLength(1250)]
        public string TraversedPath { get; set; }

        public int? FirstResponseSLAStatus { get; set; }

        public int? OnHoldTime { get; set; }

        public Guid? SLAInvokedId { get; set; }

        public bool? CustomerContacted { get; set; }

        public DateTime? LastOnHoldTime { get; set; }

        public Guid? SocialProfileId { get; set; }

        public bool? RouteCase { get; set; }

        public bool? IsEscalated { get; set; }

        public Guid? MasterId { get; set; }

        public bool? BlockedProfile { get; set; }

        public Guid? PrimaryContactId { get; set; }

        public Guid? ResolveByKPIId { get; set; }

        public int? ResolveBySLAStatus { get; set; }

        public double? SentimentValue { get; set; }

        public bool? Merged { get; set; }

        public DateTime? ResponseBy { get; set; }

        public DateTime? EscalatedOn { get; set; }

        public Guid? ParentCaseId { get; set; }

        public Guid? FirstResponseByKPIId { get; set; }

        public int? MessageTypeCode { get; set; }

        public DateTime? ResolveBy { get; set; }

        public double? InfluenceScore { get; set; }

        public Guid? EntitlementId { get; set; }

        public bool? FirstResponseSent { get; set; }

        public Guid? SLAId { get; set; }

        public Guid? CreatedByExternalParty { get; set; }

        public Guid? ModifiedByExternalParty { get; set; }

        public bool? DecrementEntitlementTerm { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual ContactBase ContactBase { get; set; }

        public virtual ContactBase ContactBase1 { get; set; }

        public virtual ContractBase ContractBase { get; set; }

        public virtual ContractDetailBase ContractDetailBase { get; set; }

        public virtual EntitlementBase EntitlementBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IncidentKnowledgeBaseRecord> IncidentKnowledgeBaseRecord { get; set; }

        public virtual KbArticleBase KbArticleBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KnowledgeArticleIncidentBase> KnowledgeArticleIncidentBase { get; set; }

        public virtual SLABaseIds SLABaseIds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeadBase> LeadBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        public virtual ProductBase ProductBase { get; set; }

        public virtual SLAKPIInstanceBase SLAKPIInstanceBase { get; set; }

        public virtual SLAKPIInstanceBase SLAKPIInstanceBase1 { get; set; }

        public virtual SocialProfileBase SocialProfileBase { get; set; }

        public virtual SubjectBase SubjectBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
