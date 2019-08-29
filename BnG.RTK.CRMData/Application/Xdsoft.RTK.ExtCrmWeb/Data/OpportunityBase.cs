namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OpportunityBase")]
    public partial class OpportunityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OpportunityBase()
        {
            CustomerOpportunityRoleBase = new HashSet<CustomerOpportunityRoleBase>();
            InvoiceBase = new HashSet<InvoiceBase>();
            LeadBase = new HashSet<LeadBase>();
            OpportunityCompetitors = new HashSet<OpportunityCompetitors>();
            QuoteBase = new HashSet<QuoteBase>();
            SalesOrderBase = new HashSet<SalesOrderBase>();
            OpportunityProductBase = new HashSet<OpportunityProductBase>();
        }

        [Key]
        public Guid OpportunityId { get; set; }

        public Guid? PriceLevelId { get; set; }

        public int? OpportunityRatingCode { get; set; }

        public int? PriorityCode { get; set; }

        [StringLength(300)]
        public string Name { get; set; }

        public Guid? StepId { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal? EstimatedValue { get; set; }

        [StringLength(200)]
        public string StepName { get; set; }

        public int? SalesStageCode { get; set; }

        public bool? ParticipatesInWorkflow { get; set; }

        public int? PricingErrorCode { get; set; }

        public DateTime? EstimatedCloseDate { get; set; }

        public int? CloseProbability { get; set; }

        [Column(TypeName = "money")]
        public decimal? ActualValue { get; set; }

        public DateTime? ActualCloseDate { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public Guid? OriginatingLeadId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public bool? IsPrivate { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int StateCode { get; set; }

        public int? StatusCode { get; set; }

        public bool? IsRevenueSystemCalculated { get; set; }

        public Guid? CampaignId { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public decimal? ExchangeRate { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        [Column(TypeName = "money")]
        public decimal? ActualValue_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? EstimatedValue_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalDiscountAmount { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAmount { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAmountLessFreight { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalLineItemDiscountAmount { get; set; }

        public Guid? CustomerId { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountAmount { get; set; }

        public Guid OwnerId { get; set; }

        [Column(TypeName = "money")]
        public decimal? FreightAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalTax { get; set; }

        public decimal? DiscountPercentage { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalLineItemAmount { get; set; }

        [StringLength(4000)]
        public string CustomerIdName { get; set; }

        public int? CustomerIdType { get; set; }

        public int OwnerIdType { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalDiscountAmount_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? FreightAmount_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalLineItemAmount_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalTax_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalLineItemDiscountAmount_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAmount_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountAmount_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAmountLessFreight_Base { get; set; }

        [StringLength(4000)]
        public string CustomerIdYomiName { get; set; }

        public bool? FileDebrief { get; set; }

        public int? BudgetStatus { get; set; }

        public bool? PresentProposal { get; set; }

        public bool? SendThankYouNote { get; set; }

        public bool? EvaluateFit { get; set; }

        public DateTime? FinalDecisionDate { get; set; }

        public bool? ConfirmInterest { get; set; }

        public bool? CompleteInternalReview { get; set; }

        public int? TimeLine { get; set; }

        public string CustomerPainPoints { get; set; }

        public bool? ResolveFeedback { get; set; }

        public string QuoteComments { get; set; }

        public int? PurchaseProcess { get; set; }

        public bool? CaptureProposalFeedback { get; set; }

        public Guid? ParentContactId { get; set; }

        public bool? IdentifyCustomerContacts { get; set; }

        public bool? CompleteFinalProposal { get; set; }

        [Column(TypeName = "money")]
        public decimal? BudgetAmount { get; set; }

        public Guid? ParentAccountId { get; set; }

        public DateTime? ScheduleFollowup_Qualify { get; set; }

        public int? Need { get; set; }

        public bool? PursuitDecision { get; set; }

        public Guid? ProcessId { get; set; }

        public DateTime? ScheduleProposalMeeting { get; set; }

        public Guid? StageId { get; set; }

        public string QualificationComments { get; set; }

        public int? SalesStage { get; set; }

        public int? InitialCommunication { get; set; }

        public bool? IdentifyPursuitTeam { get; set; }

        public DateTime? ScheduleFollowup_Prospect { get; set; }

        public int? PurchaseTimeframe { get; set; }

        public bool? IdentifyCompetitors { get; set; }

        public bool? DecisionMaker { get; set; }

        public string CurrentSituation { get; set; }

        public string CustomerNeed { get; set; }

        public string ProposedSolution { get; set; }

        public bool? PresentFinalProposal { get; set; }

        public bool? DevelopProposal { get; set; }

        [Column(TypeName = "money")]
        public decimal? BudgetAmount_Base { get; set; }

        [StringLength(1250)]
        public string TraversedPath { get; set; }

        [StringLength(1250)]
        public string TimeSpentByMeOnEmailAndMeetings { get; set; }

        public Guid? SLAInvokedId { get; set; }

        public DateTime? LastOnHoldTime { get; set; }

        public int? OnHoldTime { get; set; }

        public Guid? SLAId { get; set; }

        public virtual AccountBase AccountBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual CampaignBase CampaignBase { get; set; }

        public virtual ContactBase ContactBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerOpportunityRoleBase> CustomerOpportunityRoleBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceBase> InvoiceBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeadBase> LeadBase { get; set; }

        public virtual LeadBase LeadBase1 { get; set; }

        public virtual SLABaseIds SLABaseIds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpportunityCompetitors> OpportunityCompetitors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuoteBase> QuoteBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderBase> SalesOrderBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        public virtual PriceLevelBase PriceLevelBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpportunityProductBase> OpportunityProductBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
