namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransactionCurrencyBase")]
    public partial class TransactionCurrencyBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransactionCurrencyBase()
        {
            AccountBase = new HashSet<AccountBase>();
            ActionCardBase = new HashSet<ActionCardBase>();
            ActivityPointerBase = new HashSet<ActivityPointerBase>();
            ActivityPointerBase1 = new HashSet<ActivityPointerBase>();
            BookableResourceBase = new HashSet<BookableResourceBase>();
            BookableResourceBookingBase = new HashSet<BookableResourceBookingBase>();
            BookableResourceBookingHeaderBase = new HashSet<BookableResourceBookingHeaderBase>();
            BookableResourceCategoryAssnBase = new HashSet<BookableResourceCategoryAssnBase>();
            BookableResourceCategoryBase = new HashSet<BookableResourceCategoryBase>();
            BookableResourceCharacteristicBase = new HashSet<BookableResourceCharacteristicBase>();
            BookableResourceGroupBase = new HashSet<BookableResourceGroupBase>();
            BookingStatusBase = new HashSet<BookingStatusBase>();
            BusinessUnitBase = new HashSet<BusinessUnitBase>();
            CampaignBase = new HashSet<CampaignBase>();
            CategoryBase = new HashSet<CategoryBase>();
            CharacteristicBase = new HashSet<CharacteristicBase>();
            CompetitorBase = new HashSet<CompetitorBase>();
            ConnectionBase = new HashSet<ConnectionBase>();
            ContactBase = new HashSet<ContactBase>();
            ContractBase = new HashSet<ContractBase>();
            ContractDetailBase = new HashSet<ContractDetailBase>();
            CustomerAddressBase = new HashSet<CustomerAddressBase>();
            DiscountBase = new HashSet<DiscountBase>();
            DiscountTypeBase = new HashSet<DiscountTypeBase>();
            DynamicPropertyAssociationBase = new HashSet<DynamicPropertyAssociationBase>();
            DynamicPropertyOptionSetItemBase = new HashSet<DynamicPropertyOptionSetItemBase>();
            EntitlementBase = new HashSet<EntitlementBase>();
            EntitlementChannelBase = new HashSet<EntitlementChannelBase>();
            EntitlementTemplateBase = new HashSet<EntitlementTemplateBase>();
            EntitlementTemplateChannelBase = new HashSet<EntitlementTemplateChannelBase>();
            EquipmentBase = new HashSet<EquipmentBase>();
            ExternalPartyBase = new HashSet<ExternalPartyBase>();
            FeedbackBase = new HashSet<FeedbackBase>();
            IncidentBase = new HashSet<IncidentBase>();
            InteractionForEmailBase = new HashSet<InteractionForEmailBase>();
            InvoiceBase = new HashSet<InvoiceBase>();
            InvoiceDetailBase = new HashSet<InvoiceDetailBase>();
            KbArticleBase = new HashSet<KbArticleBase>();
            KnowledgeArticleBase = new HashSet<KnowledgeArticleBase>();
            KnowledgeArticleIncidentBase = new HashSet<KnowledgeArticleIncidentBase>();
            KnowledgeArticleViewsBase = new HashSet<KnowledgeArticleViewsBase>();
            KnowledgeBaseRecordBase = new HashSet<KnowledgeBaseRecordBase>();
            LeadAddressBase = new HashSet<LeadAddressBase>();
            LeadBase = new HashSet<LeadBase>();
            ListBase = new HashSet<ListBase>();
            OfficeGraphDocumentBase = new HashSet<OfficeGraphDocumentBase>();
            OpportunityBase = new HashSet<OpportunityBase>();
            OpportunityProductBase = new HashSet<OpportunityProductBase>();
            OrganizationBase = new HashSet<OrganizationBase>();
            PositionBase = new HashSet<PositionBase>();
            PriceLevelBase = new HashSet<PriceLevelBase>();
            ProductAssociationBase = new HashSet<ProductAssociationBase>();
            ProductBase = new HashSet<ProductBase>();
            ProductPriceLevelBase = new HashSet<ProductPriceLevelBase>();
            ProductSubstituteBase = new HashSet<ProductSubstituteBase>();
            QueueBase = new HashSet<QueueBase>();
            QueueItemBase = new HashSet<QueueItemBase>();
            QuoteBase = new HashSet<QuoteBase>();
            QuoteDetailBase = new HashSet<QuoteDetailBase>();
            RatingModelBase = new HashSet<RatingModelBase>();
            RatingValueBase = new HashSet<RatingValueBase>();
            RecommendedDocumentBase = new HashSet<RecommendedDocumentBase>();
            SalesLiteratureBase = new HashSet<SalesLiteratureBase>();
            SalesOrderBase = new HashSet<SalesOrderBase>();
            SalesOrderDetailBase = new HashSet<SalesOrderDetailBase>();
            SharePointDocumentBase = new HashSet<SharePointDocumentBase>();
            SharePointDocumentLocationBase = new HashSet<SharePointDocumentLocationBase>();
            SharePointSiteBase = new HashSet<SharePointSiteBase>();
            SocialProfileBase = new HashSet<SocialProfileBase>();
            SystemUserBase = new HashSet<SystemUserBase>();
            TeamBase = new HashSet<TeamBase>();
            TerritoryBase = new HashSet<TerritoryBase>();
            ThemeBase = new HashSet<ThemeBase>();
            ActionCardUserStateBase = new HashSet<ActionCardUserStateBase>();
            UserFiscalCalendarBase = new HashSet<UserFiscalCalendarBase>();
            DelveActionHubBase = new HashSet<DelveActionHubBase>();
            UserFiscalCalendarBase1 = new HashSet<UserFiscalCalendarBase>();
            UserFiscalCalendarBase2 = new HashSet<UserFiscalCalendarBase>();
            UserFiscalCalendarBase3 = new HashSet<UserFiscalCalendarBase>();
            UserFiscalCalendarBase4 = new HashSet<UserFiscalCalendarBase>();
            UserFiscalCalendarBase5 = new HashSet<UserFiscalCalendarBase>();
            UserMappingBase = new HashSet<UserMappingBase>();
            UserSettingsBase = new HashSet<UserSettingsBase>();
        }

        public int? StatusCode { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int StateCode { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public DateTime? CreatedOn { get; set; }

        [Key]
        public Guid TransactionCurrencyId { get; set; }

        public decimal? ExchangeRate { get; set; }

        [Required]
        [StringLength(13)]
        public string CurrencySymbol { get; set; }

        public Guid? UniqueDscId { get; set; }

        [Required]
        [StringLength(100)]
        public string CurrencyName { get; set; }

        public Guid? CreatedBy { get; set; }

        [Required]
        [StringLength(5)]
        public string ISOCurrencyCode { get; set; }

        public Guid OrganizationId { get; set; }

        public int CurrencyPrecision { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? EntityImageId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountBase> AccountBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActionCardBase> ActionCardBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityPointerBase> ActivityPointerBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityPointerBase> ActivityPointerBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookableResourceBase> BookableResourceBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookableResourceBookingBase> BookableResourceBookingBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookableResourceBookingHeaderBase> BookableResourceBookingHeaderBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookableResourceCategoryAssnBase> BookableResourceCategoryAssnBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookableResourceCategoryBase> BookableResourceCategoryBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookableResourceCharacteristicBase> BookableResourceCharacteristicBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookableResourceGroupBase> BookableResourceGroupBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingStatusBase> BookingStatusBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessUnitBase> BusinessUnitBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CampaignBase> CampaignBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CategoryBase> CategoryBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CharacteristicBase> CharacteristicBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompetitorBase> CompetitorBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConnectionBase> ConnectionBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactBase> ContactBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractBase> ContractBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractDetailBase> ContractDetailBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerAddressBase> CustomerAddressBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiscountBase> DiscountBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiscountTypeBase> DiscountTypeBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DynamicPropertyAssociationBase> DynamicPropertyAssociationBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DynamicPropertyOptionSetItemBase> DynamicPropertyOptionSetItemBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntitlementBase> EntitlementBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntitlementChannelBase> EntitlementChannelBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntitlementTemplateBase> EntitlementTemplateBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntitlementTemplateChannelBase> EntitlementTemplateChannelBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EquipmentBase> EquipmentBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExternalPartyBase> ExternalPartyBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FeedbackBase> FeedbackBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IncidentBase> IncidentBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InteractionForEmailBase> InteractionForEmailBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceBase> InvoiceBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceDetailBase> InvoiceDetailBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KbArticleBase> KbArticleBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KnowledgeArticleBase> KnowledgeArticleBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KnowledgeArticleIncidentBase> KnowledgeArticleIncidentBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KnowledgeArticleViewsBase> KnowledgeArticleViewsBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KnowledgeBaseRecordBase> KnowledgeBaseRecordBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeadAddressBase> LeadAddressBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeadBase> LeadBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListBase> ListBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OfficeGraphDocumentBase> OfficeGraphDocumentBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpportunityBase> OpportunityBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpportunityProductBase> OpportunityProductBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationBase> OrganizationBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PositionBase> PositionBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PriceLevelBase> PriceLevelBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductAssociationBase> ProductAssociationBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductBase> ProductBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductPriceLevelBase> ProductPriceLevelBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductSubstituteBase> ProductSubstituteBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QueueBase> QueueBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QueueItemBase> QueueItemBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuoteBase> QuoteBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuoteDetailBase> QuoteDetailBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RatingModelBase> RatingModelBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RatingValueBase> RatingValueBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecommendedDocumentBase> RecommendedDocumentBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesLiteratureBase> SalesLiteratureBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderBase> SalesOrderBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderDetailBase> SalesOrderDetailBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SharePointDocumentBase> SharePointDocumentBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SharePointDocumentLocationBase> SharePointDocumentLocationBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SharePointSiteBase> SharePointSiteBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SocialProfileBase> SocialProfileBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SystemUserBase> SystemUserBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeamBase> TeamBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TerritoryBase> TerritoryBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThemeBase> ThemeBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActionCardUserStateBase> ActionCardUserStateBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserFiscalCalendarBase> UserFiscalCalendarBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DelveActionHubBase> DelveActionHubBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserFiscalCalendarBase> UserFiscalCalendarBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserFiscalCalendarBase> UserFiscalCalendarBase2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserFiscalCalendarBase> UserFiscalCalendarBase3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserFiscalCalendarBase> UserFiscalCalendarBase4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserFiscalCalendarBase> UserFiscalCalendarBase5 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserMappingBase> UserMappingBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserSettingsBase> UserSettingsBase { get; set; }
    }
}
