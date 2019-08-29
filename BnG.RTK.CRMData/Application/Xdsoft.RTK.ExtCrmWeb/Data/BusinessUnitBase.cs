namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BusinessUnitBase")]
    public partial class BusinessUnitBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BusinessUnitBase()
        {
            AccountBase = new HashSet<AccountBase>();
            ActionCardBase = new HashSet<ActionCardBase>();
            ActionCardUserSettingsBase = new HashSet<ActionCardUserSettingsBase>();
            ActivityPointerBase = new HashSet<ActivityPointerBase>();
            ActivityPointerBase1 = new HashSet<ActivityPointerBase>();
            AnnotationBase = new HashSet<AnnotationBase>();
            bng_SchedulerSessionBase = new HashSet<bng_SchedulerSessionBase>();
            bng_ShedulerTaskBase = new HashSet<bng_ShedulerTaskBase>();
            BookableResourceBase = new HashSet<BookableResourceBase>();
            BookableResourceBookingBase = new HashSet<BookableResourceBookingBase>();
            BookableResourceBookingExchangeSyncIdMappingBase = new HashSet<BookableResourceBookingExchangeSyncIdMappingBase>();
            BookableResourceBookingHeaderBase = new HashSet<BookableResourceBookingHeaderBase>();
            BookableResourceCategoryAssnBase = new HashSet<BookableResourceCategoryAssnBase>();
            BookableResourceCategoryBase = new HashSet<BookableResourceCategoryBase>();
            BookableResourceCharacteristicBase = new HashSet<BookableResourceCharacteristicBase>();
            BookableResourceGroupBase = new HashSet<BookableResourceGroupBase>();
            BookingStatusBase = new HashSet<BookingStatusBase>();
            BulkDeleteOperationBase = new HashSet<BulkDeleteOperationBase>();
            BusinessUnitMap = new HashSet<BusinessUnitMap>();
            BusinessUnitMap1 = new HashSet<BusinessUnitMap>();
            CustomerOpportunityRoleBase = new HashSet<CustomerOpportunityRoleBase>();
            CalendarBase = new HashSet<CalendarBase>();
            CategoryBase = new HashSet<CategoryBase>();
            CharacteristicBase = new HashSet<CharacteristicBase>();
            ConnectionBase = new HashSet<ConnectionBase>();
            ConstraintBasedGroupBase = new HashSet<ConstraintBasedGroupBase>();
            ContactBase = new HashSet<ContactBase>();
            CustomerRelationshipBase = new HashSet<CustomerRelationshipBase>();
            DynamicPropertyInstanceBase = new HashSet<DynamicPropertyInstanceBase>();
            EmailServerProfileBase = new HashSet<EmailServerProfileBase>();
            EntitlementBase = new HashSet<EntitlementBase>();
            EquipmentBase = new HashSet<EquipmentBase>();
            ExchangeSyncIdMappingBase = new HashSet<ExchangeSyncIdMappingBase>();
            ExternalPartyBase = new HashSet<ExternalPartyBase>();
            GoalBase = new HashSet<GoalBase>();
            GoalRollupQueryBase = new HashSet<GoalRollupQueryBase>();
            IncidentBase = new HashSet<IncidentBase>();
            InteractionForEmailBase = new HashSet<InteractionForEmailBase>();
            InvoiceBase = new HashSet<InvoiceBase>();
            KnowledgeArticleBase = new HashSet<KnowledgeArticleBase>();
            LeadBase = new HashSet<LeadBase>();
            ListBase = new HashSet<ListBase>();
            MailboxBase = new HashSet<MailboxBase>();
            msdyn_PostAlbumBase = new HashSet<msdyn_PostAlbumBase>();
            msdyn_wallsavedqueryusersettingsBase = new HashSet<msdyn_wallsavedqueryusersettingsBase>();
            new_commercial_offerBase = new HashSet<new_commercial_offerBase>();
            new_contract_planBase = new HashSet<new_contract_planBase>();
            new_contract_plan_acceptionBase = new HashSet<new_contract_plan_acceptionBase>();
            new_contract_plan_adjustment_ccBase = new HashSet<new_contract_plan_adjustment_ccBase>();
            new_contract_plan_productBase = new HashSet<new_contract_plan_productBase>();
            new_contract_plan_quarterBase = new HashSet<new_contract_plan_quarterBase>();
            new_contract_stringBase = new HashSet<new_contract_stringBase>();
            new_contract_string_historyBase = new HashSet<new_contract_string_historyBase>();
            new_expense_contractBase = new HashSet<new_expense_contractBase>();
            new_expertiseBase = new HashSet<new_expertiseBase>();
            new_lead_and_possible_contractBase = new HashSet<new_lead_and_possible_contractBase>();
            new_licenseBase = new HashSet<new_licenseBase>();
            new_Package_of_documentsBase = new HashSet<new_Package_of_documentsBase>();
            new_parameter_project_initiative_evaluationBase = new HashSet<new_parameter_project_initiative_evaluationBase>();
            new_plan_factBase = new HashSet<new_plan_factBase>();
            new_potential_accountBase = new HashSet<new_potential_accountBase>();
            new_product_of_projectBase = new HashSet<new_product_of_projectBase>();
            new_profit_contractBase = new HashSet<new_profit_contractBase>();
            new_project_calculation_parametrBase = new HashSet<new_project_calculation_parametrBase>();
            new_Project_deviation_corrective_measureBase = new HashSet<new_Project_deviation_corrective_measureBase>();
            new_project_initiativeBase = new HashSet<new_project_initiativeBase>();
            new_project_initiative_valuationBase = new HashSet<new_project_initiative_valuationBase>();
            new_project_project_reporting_indexBase = new HashSet<new_project_project_reporting_indexBase>();
            new_project_reportingBase = new HashSet<new_project_reportingBase>();
            new_project_reporting_index_plan_factBase = new HashSet<new_project_reporting_index_plan_factBase>();
            new_purchaseBase = new HashSet<new_purchaseBase>();
            new_revenue_by_yearBase = new HashSet<new_revenue_by_yearBase>();
            new_RouteBase = new HashSet<new_RouteBase>();
            new_settingBase = new HashSet<new_settingBase>();
            new_StageBase = new HashSet<new_StageBase>();
            new_StepBase = new HashSet<new_StepBase>();
            new_successful_project_historyBase = new HashSet<new_successful_project_historyBase>();
            new_successful_project_history_productBase = new HashSet<new_successful_project_history_productBase>();
            new_t_account_needBase = new HashSet<new_t_account_needBase>();
            new_t_ActBase = new HashSet<new_t_ActBase>();
            new_t_activityBase = new HashSet<new_t_activityBase>();
            new_t_contract_productBase = new HashSet<new_t_contract_productBase>();
            new_t_contractorBase = new HashSet<new_t_contractorBase>();
            new_t_projectBase = new HashSet<new_t_projectBase>();
            new_t_project_riskBase = new HashSet<new_t_project_riskBase>();
            new_t_project_taskBase = new HashSet<new_t_project_taskBase>();
            new_TransferBase = new HashSet<new_TransferBase>();
            OpportunityBase = new HashSet<OpportunityBase>();
            SalesOrderBase = new HashSet<SalesOrderBase>();
            BusinessUnitBase1 = new HashSet<BusinessUnitBase>();
            PostFollowBase = new HashSet<PostFollowBase>();
            PostRegardingBase = new HashSet<PostRegardingBase>();
            QueueBase = new HashSet<QueueBase>();
            QueueBase1 = new HashSet<QueueBase>();
            QuoteBase = new HashSet<QuoteBase>();
            RatingModelBase = new HashSet<RatingModelBase>();
            RatingValueBase = new HashSet<RatingValueBase>();
            ResourceGroupBase = new HashSet<ResourceGroupBase>();
            ResourceSpecBase = new HashSet<ResourceSpecBase>();
            ResourceBase = new HashSet<ResourceBase>();
            ContractBase = new HashSet<ContractBase>();
            SharePointDocumentBase = new HashSet<SharePointDocumentBase>();
            SharePointDocumentBase1 = new HashSet<SharePointDocumentBase>();
            SharePointDocumentLocationBase = new HashSet<SharePointDocumentLocationBase>();
            SharePointSiteBase = new HashSet<SharePointSiteBase>();
            SocialProfileBase = new HashSet<SocialProfileBase>();
            SystemUserBase = new HashSet<SystemUserBase>();
            TeamBase = new HashSet<TeamBase>();
            TraceRegardingBase = new HashSet<TraceRegardingBase>();
            UserSettingsBase = new HashSet<UserSettingsBase>();
            UserApplicationMetadataBase = new HashSet<UserApplicationMetadataBase>();
            UserFormBase = new HashSet<UserFormBase>();
            UserQueryBase = new HashSet<UserQueryBase>();
            UserQueryVisualizationBase = new HashSet<UserQueryVisualizationBase>();
            CampaignBase = new HashSet<CampaignBase>();
            ImportDataBase = new HashSet<ImportDataBase>();
            ImportFileBase = new HashSet<ImportFileBase>();
            ImportLogBase = new HashSet<ImportLogBase>();
            ImportMapBase = new HashSet<ImportMapBase>();
            ImportBase = new HashSet<ImportBase>();
            MailboxTrackingFolderBase = new HashSet<MailboxTrackingFolderBase>();
            SyncErrorBase = new HashSet<SyncErrorBase>();
            new_contract_planBase1 = new HashSet<new_contract_planBase>();
            new_project_initiativeBase1 = new HashSet<new_project_initiativeBase>();
            new_territoryBase = new HashSet<new_territoryBase>();
            new_businessunit_roleBase = new HashSet<new_businessunit_roleBase>();
            new_contract_planBase2 = new HashSet<new_contract_planBase>();
            new_contract_plan_adjustment_ccBase1 = new HashSet<new_contract_plan_adjustment_ccBase>();
            new_expense_contractBase1 = new HashSet<new_expense_contractBase>();
            new_expertiseBase1 = new HashSet<new_expertiseBase>();
            new_profit_contractBase1 = new HashSet<new_profit_contractBase>();
            new_project_initiativeBase2 = new HashSet<new_project_initiativeBase>();
            new_project_reportingBase1 = new HashSet<new_project_reportingBase>();
            new_t_activityBase1 = new HashSet<new_t_activityBase>();
            new_t_activityBase2 = new HashSet<new_t_activityBase>();
            new_t_projectBase1 = new HashSet<new_t_projectBase>();
            new_t_project_taskBase1 = new HashSet<new_t_project_taskBase>();
            new_territoryBase1 = new HashSet<new_territoryBase>();
            ProcessSessionBase = new HashSet<ProcessSessionBase>();
            SystemUserBusinessUnitEntityMap = new HashSet<SystemUserBusinessUnitEntityMap>();
            UserEntityInstanceDataBase = new HashSet<UserEntityInstanceDataBase>();
            UserEntityUISettingsBase = new HashSet<UserEntityUISettingsBase>();
        }

        [Key]
        public Guid BusinessUnitId { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid? UserGroupId { get; set; }

        [Required]
        [StringLength(160)]
        public string Name { get; set; }

        public string Description { get; set; }

        [StringLength(100)]
        public string DivisionName { get; set; }

        [StringLength(100)]
        public string FileAsName { get; set; }

        [StringLength(10)]
        public string TickerSymbol { get; set; }

        [StringLength(20)]
        public string StockExchange { get; set; }

        public int? UTCOffset { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public double? CreditLimit { get; set; }

        [StringLength(100)]
        public string CostCenter { get; set; }

        [StringLength(200)]
        public string WebSiteUrl { get; set; }

        [StringLength(200)]
        public string FtpSiteUrl { get; set; }

        [StringLength(100)]
        public string EMailAddress { get; set; }

        public int? InheritanceMask { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        public bool? WorkflowSuspended { get; set; }

        public Guid? ParentBusinessUnitId { get; set; }

        public bool? IsDisabled { get; set; }

        [StringLength(500)]
        public string DisabledReason { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public string Picture { get; set; }

        public Guid? CalendarId { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public decimal? ExchangeRate { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public bool? new_MRF_sign { get; set; }

        public bool? new_RF_sign { get; set; }

        public bool? new_CC_sign { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountBase> AccountBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActionCardBase> ActionCardBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActionCardUserSettingsBase> ActionCardUserSettingsBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityPointerBase> ActivityPointerBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityPointerBase> ActivityPointerBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnnotationBase> AnnotationBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bng_SchedulerSessionBase> bng_SchedulerSessionBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bng_ShedulerTaskBase> bng_ShedulerTaskBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookableResourceBase> BookableResourceBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookableResourceBookingBase> BookableResourceBookingBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookableResourceBookingExchangeSyncIdMappingBase> BookableResourceBookingExchangeSyncIdMappingBase { get; set; }

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
        public virtual ICollection<BulkDeleteOperationBase> BulkDeleteOperationBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessUnitMap> BusinessUnitMap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessUnitMap> BusinessUnitMap1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerOpportunityRoleBase> CustomerOpportunityRoleBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CalendarBase> CalendarBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CategoryBase> CategoryBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CharacteristicBase> CharacteristicBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConnectionBase> ConnectionBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConstraintBasedGroupBase> ConstraintBasedGroupBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactBase> ContactBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerRelationshipBase> CustomerRelationshipBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DynamicPropertyInstanceBase> DynamicPropertyInstanceBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmailServerProfileBase> EmailServerProfileBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntitlementBase> EntitlementBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EquipmentBase> EquipmentBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExchangeSyncIdMappingBase> ExchangeSyncIdMappingBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExternalPartyBase> ExternalPartyBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoalBase> GoalBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoalRollupQueryBase> GoalRollupQueryBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IncidentBase> IncidentBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InteractionForEmailBase> InteractionForEmailBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceBase> InvoiceBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KnowledgeArticleBase> KnowledgeArticleBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeadBase> LeadBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListBase> ListBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MailboxBase> MailboxBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<msdyn_PostAlbumBase> msdyn_PostAlbumBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<msdyn_wallsavedqueryusersettingsBase> msdyn_wallsavedqueryusersettingsBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_commercial_offerBase> new_commercial_offerBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_contract_planBase> new_contract_planBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_contract_plan_acceptionBase> new_contract_plan_acceptionBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_contract_plan_adjustment_ccBase> new_contract_plan_adjustment_ccBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_contract_plan_productBase> new_contract_plan_productBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_contract_plan_quarterBase> new_contract_plan_quarterBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_contract_stringBase> new_contract_stringBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_contract_string_historyBase> new_contract_string_historyBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_expense_contractBase> new_expense_contractBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_expertiseBase> new_expertiseBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_lead_and_possible_contractBase> new_lead_and_possible_contractBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_licenseBase> new_licenseBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_Package_of_documentsBase> new_Package_of_documentsBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_parameter_project_initiative_evaluationBase> new_parameter_project_initiative_evaluationBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_plan_factBase> new_plan_factBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_potential_accountBase> new_potential_accountBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_product_of_projectBase> new_product_of_projectBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_profit_contractBase> new_profit_contractBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_calculation_parametrBase> new_project_calculation_parametrBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_Project_deviation_corrective_measureBase> new_Project_deviation_corrective_measureBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_initiativeBase> new_project_initiativeBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_initiative_valuationBase> new_project_initiative_valuationBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_project_reporting_indexBase> new_project_project_reporting_indexBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_reportingBase> new_project_reportingBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_reporting_index_plan_factBase> new_project_reporting_index_plan_factBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_purchaseBase> new_purchaseBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_revenue_by_yearBase> new_revenue_by_yearBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_RouteBase> new_RouteBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_settingBase> new_settingBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_StageBase> new_StageBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_StepBase> new_StepBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_successful_project_historyBase> new_successful_project_historyBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_successful_project_history_productBase> new_successful_project_history_productBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_account_needBase> new_t_account_needBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_ActBase> new_t_ActBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_activityBase> new_t_activityBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_contract_productBase> new_t_contract_productBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_contractorBase> new_t_contractorBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_projectBase> new_t_projectBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_project_riskBase> new_t_project_riskBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_project_taskBase> new_t_project_taskBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_TransferBase> new_TransferBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpportunityBase> OpportunityBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderBase> SalesOrderBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessUnitBase> BusinessUnitBase1 { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostFollowBase> PostFollowBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostRegardingBase> PostRegardingBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QueueBase> QueueBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QueueBase> QueueBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuoteBase> QuoteBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RatingModelBase> RatingModelBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RatingValueBase> RatingValueBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResourceGroupBase> ResourceGroupBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResourceSpecBase> ResourceSpecBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResourceBase> ResourceBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractBase> ContractBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SharePointDocumentBase> SharePointDocumentBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SharePointDocumentBase> SharePointDocumentBase1 { get; set; }

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
        public virtual ICollection<TraceRegardingBase> TraceRegardingBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserSettingsBase> UserSettingsBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserApplicationMetadataBase> UserApplicationMetadataBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserFormBase> UserFormBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserQueryBase> UserQueryBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserQueryVisualizationBase> UserQueryVisualizationBase { get; set; }

        public virtual CalendarBase CalendarBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CampaignBase> CampaignBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportDataBase> ImportDataBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportFileBase> ImportFileBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportLogBase> ImportLogBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportMapBase> ImportMapBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportBase> ImportBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MailboxTrackingFolderBase> MailboxTrackingFolderBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SyncErrorBase> SyncErrorBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_contract_planBase> new_contract_planBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_initiativeBase> new_project_initiativeBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_territoryBase> new_territoryBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_businessunit_roleBase> new_businessunit_roleBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_contract_planBase> new_contract_planBase2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_contract_plan_adjustment_ccBase> new_contract_plan_adjustment_ccBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_expense_contractBase> new_expense_contractBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_expertiseBase> new_expertiseBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_profit_contractBase> new_profit_contractBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_initiativeBase> new_project_initiativeBase2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_reportingBase> new_project_reportingBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_activityBase> new_t_activityBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_activityBase> new_t_activityBase2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_projectBase> new_t_projectBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_project_taskBase> new_t_project_taskBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_territoryBase> new_territoryBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcessSessionBase> ProcessSessionBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SystemUserBusinessUnitEntityMap> SystemUserBusinessUnitEntityMap { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserEntityInstanceDataBase> UserEntityInstanceDataBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserEntityUISettingsBase> UserEntityUISettingsBase { get; set; }
    }
}
