namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccountBase")]
    public partial class AccountBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AccountBase()
        {
            BookableResourceBase = new HashSet<BookableResourceBase>();
            EntitlementBase = new HashSet<EntitlementBase>();
            AccountLeads = new HashSet<AccountLeads>();
            AccountBase1 = new HashSet<AccountBase>();
            AccountBase11 = new HashSet<AccountBase>();
            LeadBase1 = new HashSet<LeadBase>();
            new_commercial_offerBase = new HashSet<new_commercial_offerBase>();
            new_expense_contractBase = new HashSet<new_expense_contractBase>();
            new_lead_and_possible_contractBase = new HashSet<new_lead_and_possible_contractBase>();
            new_profit_contractBase = new HashSet<new_profit_contractBase>();
            new_project_calculation_parametrBase = new HashSet<new_project_calculation_parametrBase>();
            new_project_initiativeBase = new HashSet<new_project_initiativeBase>();
            new_project_initiative_valuationBase = new HashSet<new_project_initiative_valuationBase>();
            new_t_account_needBase = new HashSet<new_t_account_needBase>();
            new_t_activityBase = new HashSet<new_t_activityBase>();
            new_t_contractorBase = new HashSet<new_t_contractorBase>();
            new_t_projectBase = new HashSet<new_t_projectBase>();
            new_project_initiativeBase1 = new HashSet<new_project_initiativeBase>();
            new_project_initiativeBase2 = new HashSet<new_project_initiativeBase>();
            OpportunityBase = new HashSet<OpportunityBase>();
        }

        [Key]
        public Guid AccountId { get; set; }

        public int? AccountCategoryCode { get; set; }

        public Guid? TerritoryId { get; set; }

        public Guid? DefaultPriceLevelId { get; set; }

        public int? CustomerSizeCode { get; set; }

        public int? PreferredContactMethodCode { get; set; }

        public int? CustomerTypeCode { get; set; }

        public int? AccountRatingCode { get; set; }

        public int? IndustryCode { get; set; }

        public int? TerritoryCode { get; set; }

        public int? AccountClassificationCode { get; set; }

        public int? BusinessTypeCode { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public Guid? OriginatingLeadId { get; set; }

        public int? PaymentTermsCode { get; set; }

        public int? ShippingMethodCode { get; set; }

        public Guid? PrimaryContactId { get; set; }

        public bool? ParticipatesInWorkflow { get; set; }

        [StringLength(450)]
        public string Name { get; set; }

        [StringLength(20)]
        public string AccountNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal? Revenue { get; set; }

        public int? NumberOfEmployees { get; set; }

        public string Description { get; set; }

        [StringLength(20)]
        public string SIC { get; set; }

        public int? OwnershipCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? MarketCap { get; set; }

        public int? SharesOutstanding { get; set; }

        [StringLength(10)]
        public string TickerSymbol { get; set; }

        [StringLength(20)]
        public string StockExchange { get; set; }

        [StringLength(200)]
        public string WebSiteURL { get; set; }

        [StringLength(200)]
        public string FtpSiteURL { get; set; }

        [StringLength(100)]
        public string EMailAddress1 { get; set; }

        [StringLength(100)]
        public string EMailAddress2 { get; set; }

        [StringLength(100)]
        public string EMailAddress3 { get; set; }

        public bool? DoNotPhone { get; set; }

        public bool? DoNotFax { get; set; }

        [StringLength(50)]
        public string Telephone1 { get; set; }

        public bool? DoNotEMail { get; set; }

        [StringLength(50)]
        public string Telephone2 { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Telephone3 { get; set; }

        public bool? DoNotPostalMail { get; set; }

        public bool? DoNotBulkEMail { get; set; }

        public bool? DoNotBulkPostalMail { get; set; }

        [Column(TypeName = "money")]
        public decimal? CreditLimit { get; set; }

        public bool? CreditOnHold { get; set; }

        public bool? IsPrivate { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? ParentAccountId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Aging30 { get; set; }

        public int StateCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? Aging60 { get; set; }

        public int? StatusCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? Aging90 { get; set; }

        public int? PreferredAppointmentDayCode { get; set; }

        public Guid? PreferredSystemUserId { get; set; }

        public int? PreferredAppointmentTimeCode { get; set; }

        public bool? Merged { get; set; }

        public bool? DoNotSendMM { get; set; }

        public Guid? MasterId { get; set; }

        public DateTime? LastUsedInCampaign { get; set; }

        public Guid? PreferredServiceId { get; set; }

        public Guid? PreferredEquipmentId { get; set; }

        public decimal? ExchangeRate { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        [Column(TypeName = "money")]
        public decimal? CreditLimit_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? Aging30_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? Revenue_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? Aging90_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? MarketCap_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? Aging60_Base { get; set; }

        [StringLength(160)]
        public string YomiName { get; set; }

        public Guid OwnerId { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int OwnerIdType { get; set; }

        public Guid? StageId { get; set; }

        public Guid? ProcessId { get; set; }

        public Guid? EntityImageId { get; set; }

        [StringLength(1250)]
        public string TraversedPath { get; set; }

        public int? OpenDeals { get; set; }

        [Column(TypeName = "money")]
        public decimal? OpenRevenue { get; set; }

        public int? OpenDeals_State { get; set; }

        public int? OpenRevenue_State { get; set; }

        public DateTime? OpenRevenue_Date { get; set; }

        [Column(TypeName = "money")]
        public decimal? OpenRevenue_Base { get; set; }

        public DateTime? OpenDeals_Date { get; set; }

        [StringLength(200)]
        public string PrimarySatoriId { get; set; }

        public Guid? ModifiedByExternalParty { get; set; }

        public Guid? CreatedByExternalParty { get; set; }

        [StringLength(20)]
        public string PrimaryTwitterId { get; set; }

        public bool? FollowEmail { get; set; }

        public bool? MarketingOnly { get; set; }

        public DateTime? LastOnHoldTime { get; set; }

        public int? OnHoldTime { get; set; }

        [StringLength(1250)]
        public string TimeSpentByMeOnEmailAndMeetings { get; set; }

        public Guid? SLAInvokedId { get; set; }

        public Guid? SLAId { get; set; }

        [StringLength(1000)]
        public string new_short_name { get; set; }

        public int? new_physical_person_juristic_person { get; set; }

        public int? new_resident_nonresident { get; set; }

        [StringLength(12)]
        public string new_INN { get; set; }

        [StringLength(9)]
        public string new_KPP { get; set; }

        [StringLength(15)]
        public string new_OGRN { get; set; }

        public int? new_Account_Code { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookableResourceBase> BookableResourceBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntitlementBase> EntitlementBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountLeads> AccountLeads { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountBase> AccountBase1 { get; set; }

        public virtual AccountBase AccountBase2 { get; set; }

        public virtual LeadBase LeadBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountBase> AccountBase11 { get; set; }

        public virtual AccountBase AccountBase3 { get; set; }

        public virtual ContactBase ContactBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual EquipmentBase EquipmentBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeadBase> LeadBase1 { get; set; }

        public virtual SLABaseIds SLABaseIds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_commercial_offerBase> new_commercial_offerBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_expense_contractBase> new_expense_contractBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_lead_and_possible_contractBase> new_lead_and_possible_contractBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_profit_contractBase> new_profit_contractBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_calculation_parametrBase> new_project_calculation_parametrBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_initiativeBase> new_project_initiativeBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_initiative_valuationBase> new_project_initiative_valuationBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_account_needBase> new_t_account_needBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_activityBase> new_t_activityBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_contractorBase> new_t_contractorBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_projectBase> new_t_projectBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_initiativeBase> new_project_initiativeBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_initiativeBase> new_project_initiativeBase2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpportunityBase> OpportunityBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        public virtual PriceLevelBase PriceLevelBase { get; set; }

        public virtual ServiceBase ServiceBase { get; set; }

        public virtual SystemUserBase SystemUserBase { get; set; }

        public virtual TerritoryBase TerritoryBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
