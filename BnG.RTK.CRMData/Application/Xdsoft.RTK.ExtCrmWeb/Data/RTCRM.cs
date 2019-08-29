

namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RTCRM : DbContext
    {
        public RTCRM()
            : base("name=RTCRM")
        {
        }

        public virtual DbSet<AccountBase> AccountBase { get; set; }
        public virtual DbSet<AccountLeads> AccountLeads { get; set; }
        public virtual DbSet<ActionCardBase> ActionCardBase { get; set; }
        public virtual DbSet<ActionCardUserSettingsBase> ActionCardUserSettingsBase { get; set; }
        public virtual DbSet<ActivityMimeAttachment> ActivityMimeAttachment { get; set; }
        public virtual DbSet<ActivityPartyBase> ActivityPartyBase { get; set; }
        public virtual DbSet<ActivityPointerBase> ActivityPointerBase { get; set; }
        public virtual DbSet<AdvancedSimilarityRuleBase> AdvancedSimilarityRuleBase { get; set; }
        public virtual DbSet<AdvancedSimilarityRuleBaseIds> AdvancedSimilarityRuleBaseIds { get; set; }
        public virtual DbSet<AnnotationBase> AnnotationBase { get; set; }
        public virtual DbSet<ApplicationFileBase> ApplicationFileBase { get; set; }
        public virtual DbSet<AppModuleBase> AppModuleBase { get; set; }
        public virtual DbSet<AppModuleBaseIds> AppModuleBaseIds { get; set; }
        public virtual DbSet<AppModuleComponentBase> AppModuleComponentBase { get; set; }
        public virtual DbSet<AppModuleRolesBase> AppModuleRolesBase { get; set; }
        public virtual DbSet<AppointmentBase> AppointmentBase { get; set; }
        public virtual DbSet<AsyncOperationBase> AsyncOperationBase { get; set; }
        public virtual DbSet<Attachment> Attachment { get; set; }
        public virtual DbSet<AttributeIds> AttributeIds { get; set; }
        public virtual DbSet<AttributeMapBase> AttributeMapBase { get; set; }
        public virtual DbSet<AuthorizationServerBase> AuthorizationServerBase { get; set; }
        public virtual DbSet<AzureServiceConnectionBase> AzureServiceConnectionBase { get; set; }
        public virtual DbSet<bng_SchedulerSessionBase> bng_SchedulerSessionBase { get; set; }
        public virtual DbSet<bng_ShedulerTaskBase> bng_ShedulerTaskBase { get; set; }
        public virtual DbSet<BookableResourceBase> BookableResourceBase { get; set; }
        public virtual DbSet<BookableResourceBookingBase> BookableResourceBookingBase { get; set; }
        public virtual DbSet<BookableResourceBookingExchangeSyncIdMappingBase> BookableResourceBookingExchangeSyncIdMappingBase { get; set; }
        public virtual DbSet<BookableResourceBookingHeaderBase> BookableResourceBookingHeaderBase { get; set; }
        public virtual DbSet<BookableResourceCategoryAssnBase> BookableResourceCategoryAssnBase { get; set; }
        public virtual DbSet<BookableResourceCategoryBase> BookableResourceCategoryBase { get; set; }
        public virtual DbSet<BookableResourceCharacteristicBase> BookableResourceCharacteristicBase { get; set; }
        public virtual DbSet<BookableResourceGroupBase> BookableResourceGroupBase { get; set; }
        public virtual DbSet<BookingStatusBase> BookingStatusBase { get; set; }
        public virtual DbSet<BuildVersion> BuildVersion { get; set; }
        public virtual DbSet<BulkDeleteFailureBase> BulkDeleteFailureBase { get; set; }
        public virtual DbSet<BulkDeleteOperationBase> BulkDeleteOperationBase { get; set; }
        public virtual DbSet<BulkOperationLogBase> BulkOperationLogBase { get; set; }
        public virtual DbSet<BusinessDataLocalizedLabelBase> BusinessDataLocalizedLabelBase { get; set; }
        public virtual DbSet<BusinessProcessFlowInstanceBase> BusinessProcessFlowInstanceBase { get; set; }
        public virtual DbSet<BusinessUnitBase> BusinessUnitBase { get; set; }
        public virtual DbSet<BusinessUnitMap> BusinessUnitMap { get; set; }
        public virtual DbSet<BusinessUnitNewsArticleBase> BusinessUnitNewsArticleBase { get; set; }
        public virtual DbSet<CalendarBase> CalendarBase { get; set; }
        public virtual DbSet<CalendarRuleBase> CalendarRuleBase { get; set; }
        public virtual DbSet<CampaignActivityBase> CampaignActivityBase { get; set; }
        public virtual DbSet<CampaignActivityItemBase> CampaignActivityItemBase { get; set; }
        public virtual DbSet<CampaignBase> CampaignBase { get; set; }
        public virtual DbSet<CampaignItemBase> CampaignItemBase { get; set; }
        public virtual DbSet<CampaignResponseBase> CampaignResponseBase { get; set; }
        public virtual DbSet<CardTypeBase> CardTypeBase { get; set; }
        public virtual DbSet<CascadeDeleteEntitiesSelfReferencing> CascadeDeleteEntitiesSelfReferencing { get; set; }
        public virtual DbSet<CascadeDeleteEntitiesTopologicalOrder> CascadeDeleteEntitiesTopologicalOrder { get; set; }
        public virtual DbSet<CascadeOperation> CascadeOperation { get; set; }
        public virtual DbSet<CategoryBase> CategoryBase { get; set; }
        public virtual DbSet<ChannelAccessProfileBase> ChannelAccessProfileBase { get; set; }
        public virtual DbSet<ChannelAccessProfileBaseIds> ChannelAccessProfileBaseIds { get; set; }
        public virtual DbSet<ChannelAccessProfileEntityAccessLevelBase> ChannelAccessProfileEntityAccessLevelBase { get; set; }
        public virtual DbSet<ChannelAccessProfileRuleBase> ChannelAccessProfileRuleBase { get; set; }
        public virtual DbSet<ChannelAccessProfileRuleBaseIds> ChannelAccessProfileRuleBaseIds { get; set; }
        public virtual DbSet<ChannelAccessProfileRuleItemBase> ChannelAccessProfileRuleItemBase { get; set; }
        public virtual DbSet<ChannelAccessProfileRuleItemBaseIds> ChannelAccessProfileRuleItemBaseIds { get; set; }
        public virtual DbSet<ChannelPropertyBase> ChannelPropertyBase { get; set; }
        public virtual DbSet<ChannelPropertyGroupBase> ChannelPropertyGroupBase { get; set; }
        public virtual DbSet<CharacteristicBase> CharacteristicBase { get; set; }
        public virtual DbSet<ClientUpdate> ClientUpdate { get; set; }
        public virtual DbSet<ColumnMappingBase> ColumnMappingBase { get; set; }
        public virtual DbSet<CompetitorAddressBase> CompetitorAddressBase { get; set; }
        public virtual DbSet<CompetitorBase> CompetitorBase { get; set; }
        public virtual DbSet<CompetitorProduct> CompetitorProduct { get; set; }
        public virtual DbSet<CompetitorSalesLiterature> CompetitorSalesLiterature { get; set; }
        public virtual DbSet<ComplexControlBase> ComplexControlBase { get; set; }
        public virtual DbSet<ConnectionBase> ConnectionBase { get; set; }
        public virtual DbSet<ConnectionRoleAssociation> ConnectionRoleAssociation { get; set; }
        public virtual DbSet<ConnectionRoleBase> ConnectionRoleBase { get; set; }
        public virtual DbSet<ConnectionRoleBaseIds> ConnectionRoleBaseIds { get; set; }
        public virtual DbSet<ConnectionRoleObjectTypeCodeBase> ConnectionRoleObjectTypeCodeBase { get; set; }
        public virtual DbSet<ConstraintBasedGroupBase> ConstraintBasedGroupBase { get; set; }
        public virtual DbSet<ContactBase> ContactBase { get; set; }
        public virtual DbSet<ContactInvoices> ContactInvoices { get; set; }
        public virtual DbSet<ContactLeads> ContactLeads { get; set; }
        public virtual DbSet<ContactOrders> ContactOrders { get; set; }
        public virtual DbSet<ContactQuotes> ContactQuotes { get; set; }
        public virtual DbSet<ContractBase> ContractBase { get; set; }
        public virtual DbSet<ContractDetailBase> ContractDetailBase { get; set; }
        public virtual DbSet<ContractTemplateBase> ContractTemplateBase { get; set; }
        public virtual DbSet<ContractTemplateBaseIds> ContractTemplateBaseIds { get; set; }
        public virtual DbSet<ConvertRuleBase> ConvertRuleBase { get; set; }
        public virtual DbSet<ConvertRuleBaseIds> ConvertRuleBaseIds { get; set; }
        public virtual DbSet<ConvertRuleItemBase> ConvertRuleItemBase { get; set; }
        public virtual DbSet<ConvertRuleItemBaseIds> ConvertRuleItemBaseIds { get; set; }
        public virtual DbSet<CustomControlBase> CustomControlBase { get; set; }
        public virtual DbSet<CustomControlResourceBase> CustomControlResourceBase { get; set; }
        public virtual DbSet<CustomerAddressBase> CustomerAddressBase { get; set; }
        public virtual DbSet<CustomerOpportunityRoleBase> CustomerOpportunityRoleBase { get; set; }
        public virtual DbSet<CustomerRelationshipBase> CustomerRelationshipBase { get; set; }
        public virtual DbSet<DataPerformance> DataPerformance { get; set; }
        public virtual DbSet<DateTimeConversionTracker> DateTimeConversionTracker { get; set; }
        public virtual DbSet<DependencyBase> DependencyBase { get; set; }
        public virtual DbSet<DependencyNodeBase> DependencyNodeBase { get; set; }
        public virtual DbSet<DiscountBase> DiscountBase { get; set; }
        public virtual DbSet<DiscountTypeBase> DiscountTypeBase { get; set; }
        public virtual DbSet<DisplayStringBase> DisplayStringBase { get; set; }
        public virtual DbSet<DisplayStringMapBase> DisplayStringMapBase { get; set; }
        public virtual DbSet<DocumentIndex> DocumentIndex { get; set; }
        public virtual DbSet<DocumentTemplateBase> DocumentTemplateBase { get; set; }
        public virtual DbSet<DuplicateRecordBase> DuplicateRecordBase { get; set; }
        public virtual DbSet<DuplicateRuleBase> DuplicateRuleBase { get; set; }
        public virtual DbSet<DuplicateRuleConditionBase> DuplicateRuleConditionBase { get; set; }
        public virtual DbSet<DynamicPropertyAssociationBase> DynamicPropertyAssociationBase { get; set; }
        public virtual DbSet<DynamicPropertyBase> DynamicPropertyBase { get; set; }
        public virtual DbSet<DynamicPropertyInstanceBase> DynamicPropertyInstanceBase { get; set; }
        public virtual DbSet<DynamicPropertyOptionSetItemBase> DynamicPropertyOptionSetItemBase { get; set; }
        public virtual DbSet<EmailBase> EmailBase { get; set; }
        public virtual DbSet<EmailHashBase> EmailHashBase { get; set; }
        public virtual DbSet<EmailSearchBase> EmailSearchBase { get; set; }
        public virtual DbSet<EmailServerProfileBase> EmailServerProfileBase { get; set; }
        public virtual DbSet<EmailSignatureBase> EmailSignatureBase { get; set; }
        public virtual DbSet<EmailSignatureBaseIds> EmailSignatureBaseIds { get; set; }
        public virtual DbSet<EntitlementBase> EntitlementBase { get; set; }
        public virtual DbSet<EntitlementChannelBase> EntitlementChannelBase { get; set; }
        public virtual DbSet<EntitlementContacts> EntitlementContacts { get; set; }
        public virtual DbSet<EntitlementProducts> EntitlementProducts { get; set; }
        public virtual DbSet<EntitlementTemplateBase> EntitlementTemplateBase { get; set; }
        public virtual DbSet<EntitlementTemplateChannelBase> EntitlementTemplateChannelBase { get; set; }
        public virtual DbSet<EntitlementTemplateProducts> EntitlementTemplateProducts { get; set; }
        public virtual DbSet<EntityIds> EntityIds { get; set; }
        public virtual DbSet<EntityKeyIds> EntityKeyIds { get; set; }
        public virtual DbSet<EntityMapBase> EntityMapBase { get; set; }
        public virtual DbSet<EntityRelationshipIds> EntityRelationshipIds { get; set; }
        public virtual DbSet<EquipmentBase> EquipmentBase { get; set; }
        public virtual DbSet<ExchangeSyncIdMappingBase> ExchangeSyncIdMappingBase { get; set; }
        public virtual DbSet<ExpiredProcessBase> ExpiredProcessBase { get; set; }
        public virtual DbSet<ExternalPartyBase> ExternalPartyBase { get; set; }
        public virtual DbSet<ExternalPartyItemBase> ExternalPartyItemBase { get; set; }
        public virtual DbSet<FaxBase> FaxBase { get; set; }
        public virtual DbSet<FeedbackBase> FeedbackBase { get; set; }
        public virtual DbSet<FieldPermissionBase> FieldPermissionBase { get; set; }
        public virtual DbSet<FieldSecurityProfileBase> FieldSecurityProfileBase { get; set; }
        public virtual DbSet<FilterTemplate> FilterTemplate { get; set; }
        public virtual DbSet<GoalBase> GoalBase { get; set; }
        public virtual DbSet<GoalRollupQueryBase> GoalRollupQueryBase { get; set; }
        public virtual DbSet<HierarchyRuleBase> HierarchyRuleBase { get; set; }
        public virtual DbSet<HierarchySecurityConfiguration> HierarchySecurityConfiguration { get; set; }
        public virtual DbSet<ImageDescriptor> ImageDescriptor { get; set; }
        public virtual DbSet<ImportBase> ImportBase { get; set; }
        public virtual DbSet<ImportDataBase> ImportDataBase { get; set; }
        public virtual DbSet<ImportEntityMappingBase> ImportEntityMappingBase { get; set; }
        public virtual DbSet<ImportFileBase> ImportFileBase { get; set; }
        public virtual DbSet<ImportJobBase> ImportJobBase { get; set; }
        public virtual DbSet<ImportLogBase> ImportLogBase { get; set; }
        public virtual DbSet<ImportMapBase> ImportMapBase { get; set; }
        public virtual DbSet<IncidentBase> IncidentBase { get; set; }
        public virtual DbSet<IncidentKnowledgeBaseRecord> IncidentKnowledgeBaseRecord { get; set; }
        public virtual DbSet<IntegrationStatusBase> IntegrationStatusBase { get; set; }
        public virtual DbSet<InteractionForEmailBase> InteractionForEmailBase { get; set; }
        public virtual DbSet<InternalAddressBase> InternalAddressBase { get; set; }
        public virtual DbSet<InterProcessLockBase> InterProcessLockBase { get; set; }
        public virtual DbSet<InvalidDependencyBase> InvalidDependencyBase { get; set; }
        public virtual DbSet<InvoiceBase> InvoiceBase { get; set; }
        public virtual DbSet<InvoiceDetailBase> InvoiceDetailBase { get; set; }
        public virtual DbSet<IsvConfigBase> IsvConfigBase { get; set; }
        public virtual DbSet<KbArticleBase> KbArticleBase { get; set; }
        public virtual DbSet<KbArticleCommentBase> KbArticleCommentBase { get; set; }
        public virtual DbSet<KbArticleTemplateBase> KbArticleTemplateBase { get; set; }
        public virtual DbSet<KbArticleTemplateBaseIds> KbArticleTemplateBaseIds { get; set; }
        public virtual DbSet<KnowledgeArticleBase> KnowledgeArticleBase { get; set; }
        public virtual DbSet<KnowledgeArticleIncidentBase> KnowledgeArticleIncidentBase { get; set; }
        public virtual DbSet<KnowledgeArticlesCategories> KnowledgeArticlesCategories { get; set; }
        public virtual DbSet<KnowledgeArticleViewsBase> KnowledgeArticleViewsBase { get; set; }
        public virtual DbSet<KnowledgeBaseRecordBase> KnowledgeBaseRecordBase { get; set; }
        public virtual DbSet<KnowledgeSearchModelBase> KnowledgeSearchModelBase { get; set; }
        public virtual DbSet<KnowledgeSearchModelBaseIds> KnowledgeSearchModelBaseIds { get; set; }
        public virtual DbSet<LanguageLocale> LanguageLocale { get; set; }
        public virtual DbSet<LeadAddressBase> LeadAddressBase { get; set; }
        public virtual DbSet<LeadBase> LeadBase { get; set; }
        public virtual DbSet<LeadCompetitors> LeadCompetitors { get; set; }
        public virtual DbSet<LeadProduct> LeadProduct { get; set; }
        public virtual DbSet<LeadToOpportunitySalesProcessBase> LeadToOpportunitySalesProcessBase { get; set; }
        public virtual DbSet<LetterBase> LetterBase { get; set; }
        public virtual DbSet<License> License { get; set; }
        public virtual DbSet<ListBase> ListBase { get; set; }
        public virtual DbSet<ListMemberBase> ListMemberBase { get; set; }
        public virtual DbSet<LocalConfigStoreBase> LocalConfigStoreBase { get; set; }
        public virtual DbSet<LookUpMappingBase> LookUpMappingBase { get; set; }
        public virtual DbSet<MailboxBase> MailboxBase { get; set; }
        public virtual DbSet<MailboxStatisticsBase> MailboxStatisticsBase { get; set; }
        public virtual DbSet<MailboxTrackingFolderBase> MailboxTrackingFolderBase { get; set; }
        public virtual DbSet<MailMergeTemplateBase> MailMergeTemplateBase { get; set; }
        public virtual DbSet<MailMergeTemplateBaseIds> MailMergeTemplateBaseIds { get; set; }
        public virtual DbSet<MetadataDifference> MetadataDifference { get; set; }
        public virtual DbSet<MetadataForMetadata> MetadataForMetadata { get; set; }
        public virtual DbSet<MetadataSyncTrackingDeletedObject> MetadataSyncTrackingDeletedObject { get; set; }
        public virtual DbSet<MetadataTimestamp> MetadataTimestamp { get; set; }
        public virtual DbSet<MetricBase> MetricBase { get; set; }
        public virtual DbSet<MobileOfflineProfileBase> MobileOfflineProfileBase { get; set; }
        public virtual DbSet<MobileOfflineProfileBaseIds> MobileOfflineProfileBaseIds { get; set; }
        public virtual DbSet<MobileOfflineProfileItemAssociationBase> MobileOfflineProfileItemAssociationBase { get; set; }
        public virtual DbSet<MobileOfflineProfileItemAssociationBaseIds> MobileOfflineProfileItemAssociationBaseIds { get; set; }
        public virtual DbSet<MobileOfflineProfileItemBase> MobileOfflineProfileItemBase { get; set; }
        public virtual DbSet<MobileOfflineProfileItemBaseIds> MobileOfflineProfileItemBaseIds { get; set; }
        public virtual DbSet<msdyn_PostAlbumBase> msdyn_PostAlbumBase { get; set; }
        public virtual DbSet<msdyn_PostConfigBase> msdyn_PostConfigBase { get; set; }
        public virtual DbSet<msdyn_PostRuleConfigBase> msdyn_PostRuleConfigBase { get; set; }
        public virtual DbSet<msdyn_wallsavedqueryBase> msdyn_wallsavedqueryBase { get; set; }
        public virtual DbSet<msdyn_wallsavedqueryusersettingsBase> msdyn_wallsavedqueryusersettingsBase { get; set; }
        public virtual DbSet<MultiEntitySearchBase> MultiEntitySearchBase { get; set; }
        public virtual DbSet<MultiEntitySearchEntities> MultiEntitySearchEntities { get; set; }
        public virtual DbSet<new_account_needBase> new_account_needBase { get; set; }
        public virtual DbSet<new_article_of_Profit_and_ExpenseBase> new_article_of_Profit_and_ExpenseBase { get; set; }
        public virtual DbSet<new_assessmentinitiativeBase> new_assessmentinitiativeBase { get; set; }
        public virtual DbSet<new_businessunit_roleBase> new_businessunit_roleBase { get; set; }
        public virtual DbSet<new_commercial_offerBase> new_commercial_offerBase { get; set; }
        public virtual DbSet<new_contract_plan_acceptionBase> new_contract_plan_acceptionBase { get; set; }
        public virtual DbSet<new_contract_plan_adjustment_ccBase> new_contract_plan_adjustment_ccBase { get; set; }
        public virtual DbSet<new_contract_plan_productBase> new_contract_plan_productBase { get; set; }
        public virtual DbSet<new_contract_plan_quarterBase> new_contract_plan_quarterBase { get; set; }
        public virtual DbSet<new_contract_planBase> new_contract_planBase { get; set; }
        public virtual DbSet<new_contract_string_historyBase> new_contract_string_historyBase { get; set; }
        public virtual DbSet<new_contract_stringBase> new_contract_stringBase { get; set; }
        public virtual DbSet<new_d_doc_typeBase> new_d_doc_typeBase { get; set; }
        public virtual DbSet<new_d_forms_of_possible_incomeBase> new_d_forms_of_possible_incomeBase { get; set; }
        public virtual DbSet<new_d_possible_legal_formBase> new_d_possible_legal_formBase { get; set; }
        public virtual DbSet<new_d_product_catalogBase> new_d_product_catalogBase { get; set; }
        public virtual DbSet<new_d_product_groupsBase> new_d_product_groupsBase { get; set; }
        public virtual DbSet<new_d_product_typesBase> new_d_product_typesBase { get; set; }
        public virtual DbSet<new_d_service_typesBase> new_d_service_typesBase { get; set; }
        public virtual DbSet<new_d_sphere_of_activityBase> new_d_sphere_of_activityBase { get; set; }
        public virtual DbSet<new_deal_typeBase> new_deal_typeBase { get; set; }
        public virtual DbSet<new_decision_making_levelBase> new_decision_making_levelBase { get; set; }
        public virtual DbSet<new_document_form_baseBase> new_document_form_baseBase { get; set; }
        public virtual DbSet<new_expense_contractBase> new_expense_contractBase { get; set; }
        public virtual DbSet<new_expertiseBase> new_expertiseBase { get; set; }
        public virtual DbSet<new_initiative_probabilityBase> new_initiative_probabilityBase { get; set; }
        public virtual DbSet<new_lead_and_possible_contractBase> new_lead_and_possible_contractBase { get; set; }
        public virtual DbSet<new_licenseBase> new_licenseBase { get; set; }
        public virtual DbSet<new_new_account_need_new_t_account_needBase> new_new_account_need_new_t_account_needBase { get; set; }
        public virtual DbSet<new_new_d_product_catalog_new_t_projectBase> new_new_d_product_catalog_new_t_projectBase { get; set; }
        public virtual DbSet<new_new_d_service_types_new_t_project_task2Base> new_new_d_service_types_new_t_project_task2Base { get; set; }
        public virtual DbSet<new_new_package_of_documents_new_expertiseBase> new_new_package_of_documents_new_expertiseBase { get; set; }
        public virtual DbSet<new_new_profit_contract_new_expense_contracBase> new_new_profit_contract_new_expense_contracBase { get; set; }
        public virtual DbSet<new_new_project_initiative_valuation_systemBase> new_new_project_initiative_valuation_systemBase { get; set; }
        public virtual DbSet<new_new_t_contractor_new_t_project_taskBase> new_new_t_contractor_new_t_project_taskBase { get; set; }
        public virtual DbSet<new_new_t_project_new_t_projectBase> new_new_t_project_new_t_projectBase { get; set; }
        public virtual DbSet<new_new_t_project_task_new_t_project_taskBase> new_new_t_project_task_new_t_project_taskBase { get; set; }
        public virtual DbSet<new_okiBase> new_okiBase { get; set; }
        public virtual DbSet<new_Package_of_documentsBase> new_Package_of_documentsBase { get; set; }
        public virtual DbSet<new_parameter_project_initiative_evaluationBase> new_parameter_project_initiative_evaluationBase { get; set; }
        public virtual DbSet<new_plan_factBase> new_plan_factBase { get; set; }
        public virtual DbSet<new_potential_accountBase> new_potential_accountBase { get; set; }
        public virtual DbSet<new_product_of_projectBase> new_product_of_projectBase { get; set; }
        public virtual DbSet<new_profit_contractBase> new_profit_contractBase { get; set; }
        public virtual DbSet<new_project_calculation_parametrBase> new_project_calculation_parametrBase { get; set; }
        public virtual DbSet<new_Project_deviation_corrective_measureBase> new_Project_deviation_corrective_measureBase { get; set; }
        public virtual DbSet<new_project_initiative_valuationBase> new_project_initiative_valuationBase { get; set; }
        public virtual DbSet<new_project_initiativeBase> new_project_initiativeBase { get; set; }
        public virtual DbSet<new_project_project_reporting_indexBase> new_project_project_reporting_indexBase { get; set; }
        public virtual DbSet<new_project_reporting_index_plan_factBase> new_project_reporting_index_plan_factBase { get; set; }
        public virtual DbSet<new_project_reporting_indexBase> new_project_reporting_indexBase { get; set; }
        public virtual DbSet<new_project_reportingBase> new_project_reportingBase { get; set; }
        public virtual DbSet<new_purchaseBase> new_purchaseBase { get; set; }
        public virtual DbSet<new_RatingBase> new_RatingBase { get; set; }
        public virtual DbSet<new_revenue_by_yearBase> new_revenue_by_yearBase { get; set; }
        public virtual DbSet<new_RouteBase> new_RouteBase { get; set; }
        public virtual DbSet<new_settingBase> new_settingBase { get; set; }
        public virtual DbSet<new_StageBase> new_StageBase { get; set; }
        public virtual DbSet<new_StepBase> new_StepBase { get; set; }
        public virtual DbSet<new_successful_project_history_productBase> new_successful_project_history_productBase { get; set; }
        public virtual DbSet<new_successful_project_historyBase> new_successful_project_historyBase { get; set; }
        public virtual DbSet<new_t_account_needBase> new_t_account_needBase { get; set; }
        public virtual DbSet<new_t_ActBase> new_t_ActBase { get; set; }
        public virtual DbSet<new_t_activityBase> new_t_activityBase { get; set; }
        public virtual DbSet<new_t_contract_productBase> new_t_contract_productBase { get; set; }
        public virtual DbSet<new_t_contractorBase> new_t_contractorBase { get; set; }
        public virtual DbSet<new_t_project_riskBase> new_t_project_riskBase { get; set; }
        public virtual DbSet<new_t_project_taskBase> new_t_project_taskBase { get; set; }
        public virtual DbSet<new_t_projectBase> new_t_projectBase { get; set; }
        public virtual DbSet<new_territoryBase> new_territoryBase { get; set; }
        public virtual DbSet<new_TransferBase> new_TransferBase { get; set; }
        public virtual DbSet<NewProcessBase> NewProcessBase { get; set; }
        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<OfficeDocumentBase> OfficeDocumentBase { get; set; }
        public virtual DbSet<OfficeGraphDocumentBase> OfficeGraphDocumentBase { get; set; }
        public virtual DbSet<OpportunityBase> OpportunityBase { get; set; }
        public virtual DbSet<OpportunityCompetitors> OpportunityCompetitors { get; set; }
        public virtual DbSet<OpportunityProductBase> OpportunityProductBase { get; set; }
        public virtual DbSet<OpportunitySalesProcessBase> OpportunitySalesProcessBase { get; set; }
        public virtual DbSet<OptionSetIds> OptionSetIds { get; set; }
        public virtual DbSet<OrganizationBase> OrganizationBase { get; set; }
        public virtual DbSet<OrganizationStatisticBase> OrganizationStatisticBase { get; set; }
        public virtual DbSet<OwnerBase> OwnerBase { get; set; }
        public virtual DbSet<OwnerMappingBase> OwnerMappingBase { get; set; }
        public virtual DbSet<PartnerApplicationBase> PartnerApplicationBase { get; set; }
        public virtual DbSet<PersonalDocumentTemplateBase> PersonalDocumentTemplateBase { get; set; }
        public virtual DbSet<PhoneCallBase> PhoneCallBase { get; set; }
        public virtual DbSet<PhoneToCaseProcessBase> PhoneToCaseProcessBase { get; set; }
        public virtual DbSet<PickListMappingBase> PickListMappingBase { get; set; }
        public virtual DbSet<PluginAssemblyBase> PluginAssemblyBase { get; set; }
        public virtual DbSet<PluginAssemblyBaseIds> PluginAssemblyBaseIds { get; set; }
        public virtual DbSet<PluginTraceLogBase> PluginTraceLogBase { get; set; }
        public virtual DbSet<PluginTypeBase> PluginTypeBase { get; set; }
        public virtual DbSet<PluginTypeBaseIds> PluginTypeBaseIds { get; set; }
        public virtual DbSet<PluginTypeStatisticBase> PluginTypeStatisticBase { get; set; }
        public virtual DbSet<PositionBase> PositionBase { get; set; }
        public virtual DbSet<PostBase> PostBase { get; set; }
        public virtual DbSet<PostCommentBase> PostCommentBase { get; set; }
        public virtual DbSet<PostFollowBase> PostFollowBase { get; set; }
        public virtual DbSet<PostLikeBase> PostLikeBase { get; set; }
        public virtual DbSet<PostRegardingBase> PostRegardingBase { get; set; }
        public virtual DbSet<PostRoleBase> PostRoleBase { get; set; }
        public virtual DbSet<PriceLevelBase> PriceLevelBase { get; set; }
        public virtual DbSet<PrincipalAttributeAccessMap> PrincipalAttributeAccessMap { get; set; }
        public virtual DbSet<PrincipalEntityMap> PrincipalEntityMap { get; set; }
        public virtual DbSet<PrincipalObjectAccess> PrincipalObjectAccess { get; set; }
        public virtual DbSet<PrincipalObjectAccessReadSnapshot> PrincipalObjectAccessReadSnapshot { get; set; }
        public virtual DbSet<PrincipalObjectAttributeAccessBase> PrincipalObjectAttributeAccessBase { get; set; }
        public virtual DbSet<PrivilegeBase> PrivilegeBase { get; set; }
        public virtual DbSet<PrivilegeObjectTypeCodes> PrivilegeObjectTypeCodes { get; set; }
        public virtual DbSet<ProcessSessionBase> ProcessSessionBase { get; set; }
        public virtual DbSet<ProcessStageBase> ProcessStageBase { get; set; }
        public virtual DbSet<ProcessTriggerBase> ProcessTriggerBase { get; set; }
        public virtual DbSet<ProductAssociationBase> ProductAssociationBase { get; set; }
        public virtual DbSet<ProductBase> ProductBase { get; set; }
        public virtual DbSet<ProductPriceLevelBase> ProductPriceLevelBase { get; set; }
        public virtual DbSet<ProductSalesLiterature> ProductSalesLiterature { get; set; }
        public virtual DbSet<ProductSubstituteBase> ProductSubstituteBase { get; set; }
        public virtual DbSet<PublisherAddressBase> PublisherAddressBase { get; set; }
        public virtual DbSet<PublisherBase> PublisherBase { get; set; }
        public virtual DbSet<QueueBase> QueueBase { get; set; }
        public virtual DbSet<QueueItemBase> QueueItemBase { get; set; }
        public virtual DbSet<QueueMembership> QueueMembership { get; set; }
        public virtual DbSet<QuoteBase> QuoteBase { get; set; }
        public virtual DbSet<QuoteDetailBase> QuoteDetailBase { get; set; }
        public virtual DbSet<RatingModelBase> RatingModelBase { get; set; }
        public virtual DbSet<RatingValueBase> RatingValueBase { get; set; }
        public virtual DbSet<RecommendationCacheBase> RecommendationCacheBase { get; set; }
        public virtual DbSet<RecommendationModelBase> RecommendationModelBase { get; set; }
        public virtual DbSet<RecommendationModelBaseIds> RecommendationModelBaseIds { get; set; }
        public virtual DbSet<RecommendationModelMappingBase> RecommendationModelMappingBase { get; set; }
        public virtual DbSet<RecommendationModelVersionBase> RecommendationModelVersionBase { get; set; }
        public virtual DbSet<RecommendationModelVersionHistoryBase> RecommendationModelVersionHistoryBase { get; set; }
        public virtual DbSet<RecommendedDocumentBase> RecommendedDocumentBase { get; set; }
        public virtual DbSet<RecordCountSnapshot> RecordCountSnapshot { get; set; }
        public virtual DbSet<RecurrenceRuleBase> RecurrenceRuleBase { get; set; }
        public virtual DbSet<RecurringAppointmentMasterExtensionBase> RecurringAppointmentMasterExtensionBase { get; set; }
        public virtual DbSet<RelationshipIds> RelationshipIds { get; set; }
        public virtual DbSet<RelationshipRoleBase> RelationshipRoleBase { get; set; }
        public virtual DbSet<RelationshipRoleMapBase> RelationshipRoleMapBase { get; set; }
        public virtual DbSet<ReplicationBacklogBase> ReplicationBacklogBase { get; set; }
        public virtual DbSet<ReportBase> ReportBase { get; set; }
        public virtual DbSet<ReportCategoryBase> ReportCategoryBase { get; set; }
        public virtual DbSet<ReportCategoryBaseIds> ReportCategoryBaseIds { get; set; }
        public virtual DbSet<ReportEntityBase> ReportEntityBase { get; set; }
        public virtual DbSet<ReportLinkBase> ReportLinkBase { get; set; }
        public virtual DbSet<ReportVisibilityBase> ReportVisibilityBase { get; set; }
        public virtual DbSet<ResourceBase> ResourceBase { get; set; }
        public virtual DbSet<ResourceGroupBase> ResourceGroupBase { get; set; }
        public virtual DbSet<ResourceGroupExpansionBase> ResourceGroupExpansionBase { get; set; }
        public virtual DbSet<ResourceSpecBase> ResourceSpecBase { get; set; }
        public virtual DbSet<RibbonCommandBase> RibbonCommandBase { get; set; }
        public virtual DbSet<RibbonContextGroupBase> RibbonContextGroupBase { get; set; }
        public virtual DbSet<RibbonCustomizationBase> RibbonCustomizationBase { get; set; }
        public virtual DbSet<RibbonDiffBase> RibbonDiffBase { get; set; }
        public virtual DbSet<RibbonRuleBase> RibbonRuleBase { get; set; }
        public virtual DbSet<RibbonTabToCommandMapBase> RibbonTabToCommandMapBase { get; set; }
        public virtual DbSet<RoleBase> RoleBase { get; set; }
        public virtual DbSet<RoleBaseIds> RoleBaseIds { get; set; }
        public virtual DbSet<RolePrivilegesBase> RolePrivilegesBase { get; set; }
        public virtual DbSet<RoleTemplateBase> RoleTemplateBase { get; set; }
        public virtual DbSet<RoleTemplatePrivileges> RoleTemplatePrivileges { get; set; }
        public virtual DbSet<Rollup_Bootstrap_1f7005efada6e81180d3dbe78f6b8753> Rollup_Bootstrap_1f7005efada6e81180d3dbe78f6b8753 { get; set; }
        public virtual DbSet<Rollup_Bootstrap_2721056d22ade81180d3dbe78f6b8753> Rollup_Bootstrap_2721056d22ade81180d3dbe78f6b8753 { get; set; }
        public virtual DbSet<Rollup_Bootstrap_306845ef446a42e58df811c31bafaded> Rollup_Bootstrap_306845ef446a42e58df811c31bafaded { get; set; }
        public virtual DbSet<Rollup_Bootstrap_4349ff878d36e81180d2d91123acd40c> Rollup_Bootstrap_4349ff878d36e81180d2d91123acd40c { get; set; }
        public virtual DbSet<Rollup_Bootstrap_94030e73a23ce81180d3dbe78f6b8753> Rollup_Bootstrap_94030e73a23ce81180d3dbe78f6b8753 { get; set; }
        public virtual DbSet<Rollup_Bootstrap_9f58728f0f38e81180d2d91123acd40c> Rollup_Bootstrap_9f58728f0f38e81180d2d91123acd40c { get; set; }
        public virtual DbSet<Rollup_Bootstrap_b6fac3703879e81180d3dbe78f6b8753> Rollup_Bootstrap_b6fac3703879e81180d3dbe78f6b8753 { get; set; }
        public virtual DbSet<Rollup_Bootstrap_bacebbde18e243a7b3fb4bbdf2b2c0e5> Rollup_Bootstrap_bacebbde18e243a7b3fb4bbdf2b2c0e5 { get; set; }
        public virtual DbSet<Rollup_Bootstrap_d2c321243c79e81180d3dbe78f6b8753> Rollup_Bootstrap_d2c321243c79e81180d3dbe78f6b8753 { get; set; }
        public virtual DbSet<Rollup_Bootstrap_e10cdd445c7f4ac8a5d1b2118926f2bd> Rollup_Bootstrap_e10cdd445c7f4ac8a5d1b2118926f2bd { get; set; }
        public virtual DbSet<Rollup_Bootstrap_f9e939a60f38e81180d2d91123acd40c> Rollup_Bootstrap_f9e939a60f38e81180d2d91123acd40c { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Orphans_1f7005efada6e81180d3dbe78f6b8753> Rollup_Bootstrap_Orphans_1f7005efada6e81180d3dbe78f6b8753 { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Orphans_2721056d22ade81180d3dbe78f6b8753> Rollup_Bootstrap_Orphans_2721056d22ade81180d3dbe78f6b8753 { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Orphans_306845ef446a42e58df811c31bafaded> Rollup_Bootstrap_Orphans_306845ef446a42e58df811c31bafaded { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Orphans_4349ff878d36e81180d2d91123acd40c> Rollup_Bootstrap_Orphans_4349ff878d36e81180d2d91123acd40c { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Orphans_94030e73a23ce81180d3dbe78f6b8753> Rollup_Bootstrap_Orphans_94030e73a23ce81180d3dbe78f6b8753 { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Orphans_9f58728f0f38e81180d2d91123acd40c> Rollup_Bootstrap_Orphans_9f58728f0f38e81180d2d91123acd40c { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Orphans_b6fac3703879e81180d3dbe78f6b8753> Rollup_Bootstrap_Orphans_b6fac3703879e81180d3dbe78f6b8753 { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Orphans_bacebbde18e243a7b3fb4bbdf2b2c0e5> Rollup_Bootstrap_Orphans_bacebbde18e243a7b3fb4bbdf2b2c0e5 { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Orphans_d2c321243c79e81180d3dbe78f6b8753> Rollup_Bootstrap_Orphans_d2c321243c79e81180d3dbe78f6b8753 { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Orphans_e10cdd445c7f4ac8a5d1b2118926f2bd> Rollup_Bootstrap_Orphans_e10cdd445c7f4ac8a5d1b2118926f2bd { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Orphans_f9e939a60f38e81180d2d91123acd40c> Rollup_Bootstrap_Orphans_f9e939a60f38e81180d2d91123acd40c { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Source_1f7005efada6e81180d3dbe78f6b8753> Rollup_Bootstrap_Source_1f7005efada6e81180d3dbe78f6b8753 { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Source_2721056d22ade81180d3dbe78f6b8753> Rollup_Bootstrap_Source_2721056d22ade81180d3dbe78f6b8753 { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Source_306845ef446a42e58df811c31bafaded> Rollup_Bootstrap_Source_306845ef446a42e58df811c31bafaded { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Source_4349ff878d36e81180d2d91123acd40c> Rollup_Bootstrap_Source_4349ff878d36e81180d2d91123acd40c { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Source_94030e73a23ce81180d3dbe78f6b8753> Rollup_Bootstrap_Source_94030e73a23ce81180d3dbe78f6b8753 { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Source_9f58728f0f38e81180d2d91123acd40c> Rollup_Bootstrap_Source_9f58728f0f38e81180d2d91123acd40c { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Source_b6fac3703879e81180d3dbe78f6b8753> Rollup_Bootstrap_Source_b6fac3703879e81180d3dbe78f6b8753 { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Source_bacebbde18e243a7b3fb4bbdf2b2c0e5> Rollup_Bootstrap_Source_bacebbde18e243a7b3fb4bbdf2b2c0e5 { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Source_d2c321243c79e81180d3dbe78f6b8753> Rollup_Bootstrap_Source_d2c321243c79e81180d3dbe78f6b8753 { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Source_e10cdd445c7f4ac8a5d1b2118926f2bd> Rollup_Bootstrap_Source_e10cdd445c7f4ac8a5d1b2118926f2bd { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Source_f9e939a60f38e81180d2d91123acd40c> Rollup_Bootstrap_Source_f9e939a60f38e81180d2d91123acd40c { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Target_1f7005efada6e81180d3dbe78f6b8753> Rollup_Bootstrap_Target_1f7005efada6e81180d3dbe78f6b8753 { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Target_2721056d22ade81180d3dbe78f6b8753> Rollup_Bootstrap_Target_2721056d22ade81180d3dbe78f6b8753 { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Target_306845ef446a42e58df811c31bafaded> Rollup_Bootstrap_Target_306845ef446a42e58df811c31bafaded { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Target_4349ff878d36e81180d2d91123acd40c> Rollup_Bootstrap_Target_4349ff878d36e81180d2d91123acd40c { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Target_94030e73a23ce81180d3dbe78f6b8753> Rollup_Bootstrap_Target_94030e73a23ce81180d3dbe78f6b8753 { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Target_9f58728f0f38e81180d2d91123acd40c> Rollup_Bootstrap_Target_9f58728f0f38e81180d2d91123acd40c { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Target_b6fac3703879e81180d3dbe78f6b8753> Rollup_Bootstrap_Target_b6fac3703879e81180d3dbe78f6b8753 { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Target_bacebbde18e243a7b3fb4bbdf2b2c0e5> Rollup_Bootstrap_Target_bacebbde18e243a7b3fb4bbdf2b2c0e5 { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Target_d2c321243c79e81180d3dbe78f6b8753> Rollup_Bootstrap_Target_d2c321243c79e81180d3dbe78f6b8753 { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Target_e10cdd445c7f4ac8a5d1b2118926f2bd> Rollup_Bootstrap_Target_e10cdd445c7f4ac8a5d1b2118926f2bd { get; set; }
        public virtual DbSet<Rollup_Bootstrap_Target_f9e939a60f38e81180d2d91123acd40c> Rollup_Bootstrap_Target_f9e939a60f38e81180d2d91123acd40c { get; set; }
        public virtual DbSet<RollupFieldBase> RollupFieldBase { get; set; }
        public virtual DbSet<RollupJobBase> RollupJobBase { get; set; }
        public virtual DbSet<RollupPropertiesBase> RollupPropertiesBase { get; set; }
        public virtual DbSet<RoutingRuleBase> RoutingRuleBase { get; set; }
        public virtual DbSet<RoutingRuleBaseIds> RoutingRuleBaseIds { get; set; }
        public virtual DbSet<RoutingRuleItemBase> RoutingRuleItemBase { get; set; }
        public virtual DbSet<RoutingRuleItemBaseIds> RoutingRuleItemBaseIds { get; set; }
        public virtual DbSet<SalesLiteratureBase> SalesLiteratureBase { get; set; }
        public virtual DbSet<SalesLiteratureItemBase> SalesLiteratureItemBase { get; set; }
        public virtual DbSet<SalesOrderBase> SalesOrderBase { get; set; }
        public virtual DbSet<SalesOrderDetailBase> SalesOrderDetailBase { get; set; }
        public virtual DbSet<SavedOrgInsightsConfigurationBase> SavedOrgInsightsConfigurationBase { get; set; }
        public virtual DbSet<SavedQueryBase> SavedQueryBase { get; set; }
        public virtual DbSet<SavedQueryVisualizationBase> SavedQueryVisualizationBase { get; set; }
        public virtual DbSet<SdkMessageBase> SdkMessageBase { get; set; }
        public virtual DbSet<SdkMessageBaseIds> SdkMessageBaseIds { get; set; }
        public virtual DbSet<SdkMessageFilterBase> SdkMessageFilterBase { get; set; }
        public virtual DbSet<SdkMessageFilterBaseIds> SdkMessageFilterBaseIds { get; set; }
        public virtual DbSet<SdkMessagePairBase> SdkMessagePairBase { get; set; }
        public virtual DbSet<SdkMessagePairBaseIds> SdkMessagePairBaseIds { get; set; }
        public virtual DbSet<SdkMessageProcessingStepBase> SdkMessageProcessingStepBase { get; set; }
        public virtual DbSet<SdkMessageProcessingStepBaseIds> SdkMessageProcessingStepBaseIds { get; set; }
        public virtual DbSet<SdkMessageProcessingStepImageBase> SdkMessageProcessingStepImageBase { get; set; }
        public virtual DbSet<SdkMessageProcessingStepSecureConfigBase> SdkMessageProcessingStepSecureConfigBase { get; set; }
        public virtual DbSet<SdkMessageProcessingStepSecureConfigBaseIds> SdkMessageProcessingStepSecureConfigBaseIds { get; set; }
        public virtual DbSet<SdkMessageRequestBase> SdkMessageRequestBase { get; set; }
        public virtual DbSet<SdkMessageRequestBaseIds> SdkMessageRequestBaseIds { get; set; }
        public virtual DbSet<SdkMessageRequestFieldBase> SdkMessageRequestFieldBase { get; set; }
        public virtual DbSet<SdkMessageResponseBase> SdkMessageResponseBase { get; set; }
        public virtual DbSet<SdkMessageResponseBaseIds> SdkMessageResponseBaseIds { get; set; }
        public virtual DbSet<SdkMessageResponseFieldBase> SdkMessageResponseFieldBase { get; set; }
        public virtual DbSet<ServiceAppointmentBase> ServiceAppointmentBase { get; set; }
        public virtual DbSet<ServiceBase> ServiceBase { get; set; }
        public virtual DbSet<ServiceContractContacts> ServiceContractContacts { get; set; }
        public virtual DbSet<ServiceEndpointBase> ServiceEndpointBase { get; set; }
        public virtual DbSet<SharedCacheState> SharedCacheState { get; set; }
        public virtual DbSet<SharePointDataBase> SharePointDataBase { get; set; }
        public virtual DbSet<SharePointDocumentBase> SharePointDocumentBase { get; set; }
        public virtual DbSet<SharePointDocumentLocationBase> SharePointDocumentLocationBase { get; set; }
        public virtual DbSet<SharePointSiteBase> SharePointSiteBase { get; set; }
        public virtual DbSet<SimilarityRuleBase> SimilarityRuleBase { get; set; }
        public virtual DbSet<SimilarityRuleBaseIds> SimilarityRuleBaseIds { get; set; }
        public virtual DbSet<SiteBase> SiteBase { get; set; }
        public virtual DbSet<SiteMapBase> SiteMapBase { get; set; }
        public virtual DbSet<SLABase> SLABase { get; set; }
        public virtual DbSet<SLABaseIds> SLABaseIds { get; set; }
        public virtual DbSet<SLAItemBase> SLAItemBase { get; set; }
        public virtual DbSet<SLAItemBaseIds> SLAItemBaseIds { get; set; }
        public virtual DbSet<SLAKPIInstanceBase> SLAKPIInstanceBase { get; set; }
        public virtual DbSet<SLAKPIInstanceBaseIds> SLAKPIInstanceBaseIds { get; set; }
        public virtual DbSet<SocialActivityBase> SocialActivityBase { get; set; }
        public virtual DbSet<SocialInsightsConfigurationBase> SocialInsightsConfigurationBase { get; set; }
        public virtual DbSet<SocialProfileBase> SocialProfileBase { get; set; }
        public virtual DbSet<SolutionBase> SolutionBase { get; set; }
        public virtual DbSet<SolutionComponentBase> SolutionComponentBase { get; set; }
        public virtual DbSet<SqlEncryptionAudit> SqlEncryptionAudit { get; set; }
        public virtual DbSet<StatusMapBase> StatusMapBase { get; set; }
        public virtual DbSet<StringMapBase> StringMapBase { get; set; }
        public virtual DbSet<SubjectBase> SubjectBase { get; set; }
        public virtual DbSet<Subscription> Subscription { get; set; }
        public virtual DbSet<SubscriptionClients> SubscriptionClients { get; set; }
        public virtual DbSet<SubscriptionManuallyTrackedObject> SubscriptionManuallyTrackedObject { get; set; }
        public virtual DbSet<SubscriptionStatisticsOfflineBase> SubscriptionStatisticsOfflineBase { get; set; }
        public virtual DbSet<SubscriptionStatisticsOutlookBase> SubscriptionStatisticsOutlookBase { get; set; }
        public virtual DbSet<SubscriptionSyncEntryOfflineBase> SubscriptionSyncEntryOfflineBase { get; set; }
        public virtual DbSet<SubscriptionSyncEntryOutlookBase> SubscriptionSyncEntryOutlookBase { get; set; }
        public virtual DbSet<SubscriptionSyncInfo> SubscriptionSyncInfo { get; set; }
        public virtual DbSet<SubscriptionTrackingDeletedObject> SubscriptionTrackingDeletedObject { get; set; }
        public virtual DbSet<SyncErrorBase> SyncErrorBase { get; set; }
        public virtual DbSet<SystemApplicationMetadataBase> SystemApplicationMetadataBase { get; set; }
        public virtual DbSet<SystemApplicationMetadataChild> SystemApplicationMetadataChild { get; set; }
        public virtual DbSet<SystemFormBase> SystemFormBase { get; set; }
        public virtual DbSet<SystemUserBase> SystemUserBase { get; set; }
        public virtual DbSet<SystemUserBusinessUnitEntityMap> SystemUserBusinessUnitEntityMap { get; set; }
        public virtual DbSet<SystemUserLicenses> SystemUserLicenses { get; set; }
        public virtual DbSet<SystemUserPrincipals> SystemUserPrincipals { get; set; }
        public virtual DbSet<SystemUserProfiles> SystemUserProfiles { get; set; }
        public virtual DbSet<SystemUserRoles> SystemUserRoles { get; set; }
        public virtual DbSet<TaskBase> TaskBase { get; set; }
        public virtual DbSet<TeamBase> TeamBase { get; set; }
        public virtual DbSet<TeamMembership> TeamMembership { get; set; }
        public virtual DbSet<TeamProfiles> TeamProfiles { get; set; }
        public virtual DbSet<TeamRoles> TeamRoles { get; set; }
        public virtual DbSet<TeamTemplateBase> TeamTemplateBase { get; set; }
        public virtual DbSet<TemplateBase> TemplateBase { get; set; }
        public virtual DbSet<TemplateBaseIds> TemplateBaseIds { get; set; }
        public virtual DbSet<TerritoryBase> TerritoryBase { get; set; }
        public virtual DbSet<TextAnalyticsEntityMappingBase> TextAnalyticsEntityMappingBase { get; set; }
        public virtual DbSet<ThemeBase> ThemeBase { get; set; }
        public virtual DbSet<TimeStampDateMapping> TimeStampDateMapping { get; set; }
        public virtual DbSet<TimeZoneDefinitionBase> TimeZoneDefinitionBase { get; set; }
        public virtual DbSet<TimeZoneLocalizedNameBase> TimeZoneLocalizedNameBase { get; set; }
        public virtual DbSet<TimeZoneRuleBase> TimeZoneRuleBase { get; set; }
        public virtual DbSet<TopicBase> TopicBase { get; set; }
        public virtual DbSet<TopicHistoryBase> TopicHistoryBase { get; set; }
        public virtual DbSet<TopicModelBase> TopicModelBase { get; set; }
        public virtual DbSet<TopicModelConfigurationBase> TopicModelConfigurationBase { get; set; }
        public virtual DbSet<TopicModelConfigurationBaseIds> TopicModelConfigurationBaseIds { get; set; }
        public virtual DbSet<TopicModelExecutionHistoryBase> TopicModelExecutionHistoryBase { get; set; }
        public virtual DbSet<TraceAssociationBase> TraceAssociationBase { get; set; }
        public virtual DbSet<TraceLogBase> TraceLogBase { get; set; }
        public virtual DbSet<TraceRegardingBase> TraceRegardingBase { get; set; }
        public virtual DbSet<TransactionCurrencyBase> TransactionCurrencyBase { get; set; }
        public virtual DbSet<TransformationMappingBase> TransformationMappingBase { get; set; }
        public virtual DbSet<TransformationParameterMappingBase> TransformationParameterMappingBase { get; set; }
        public virtual DbSet<TranslationProcessBase> TranslationProcessBase { get; set; }
        public virtual DbSet<UnresolvedAddressBase> UnresolvedAddressBase { get; set; }
        public virtual DbSet<UntrackedEmailBase> UntrackedEmailBase { get; set; }
        public virtual DbSet<UoMBase> UoMBase { get; set; }
        public virtual DbSet<UoMScheduleBase> UoMScheduleBase { get; set; }
        public virtual DbSet<UserApplicationMetadataBase> UserApplicationMetadataBase { get; set; }
        public virtual DbSet<UserEntityInstanceDataBase> UserEntityInstanceDataBase { get; set; }
        public virtual DbSet<UserEntityUISettingsBase> UserEntityUISettingsBase { get; set; }
        public virtual DbSet<UserFiscalCalendarBase> UserFiscalCalendarBase { get; set; }
        public virtual DbSet<UserFormBase> UserFormBase { get; set; }
        public virtual DbSet<UserMappingBase> UserMappingBase { get; set; }
        public virtual DbSet<UserQueryBase> UserQueryBase { get; set; }
        public virtual DbSet<UserQueryVisualizationBase> UserQueryVisualizationBase { get; set; }
        public virtual DbSet<UserSearchFacetBase> UserSearchFacetBase { get; set; }
        public virtual DbSet<UserSettingsBase> UserSettingsBase { get; set; }
        public virtual DbSet<WebResourceBase> WebResourceBase { get; set; }
        public virtual DbSet<WebResourceBaseIds> WebResourceBaseIds { get; set; }
        public virtual DbSet<WebWizardBase> WebWizardBase { get; set; }
        public virtual DbSet<WizardAccessPrivilegeBase> WizardAccessPrivilegeBase { get; set; }
        public virtual DbSet<WizardPageBase> WizardPageBase { get; set; }
        public virtual DbSet<WorkflowBase> WorkflowBase { get; set; }
        public virtual DbSet<WorkflowBaseIds> WorkflowBaseIds { get; set; }
        public virtual DbSet<WorkflowDependencyBase> WorkflowDependencyBase { get; set; }
        public virtual DbSet<WorkflowLogBase> WorkflowLogBase { get; set; }
        public virtual DbSet<WorkflowWaitSubscriptionBase> WorkflowWaitSubscriptionBase { get; set; }
        public virtual DbSet<xd_activity_presaleBase> xd_activity_presaleBase { get; set; }
        public virtual DbSet<ActionCardUserStateBase> ActionCardUserStateBase { get; set; }
        public virtual DbSet<AuditBase> AuditBase { get; set; }
        public virtual DbSet<CustomControlDefaultConfigBase> CustomControlDefaultConfigBase { get; set; }
        public virtual DbSet<DelveActionHubBase> DelveActionHubBase { get; set; }
        public virtual DbSet<DependencyFeatureBase> DependencyFeatureBase { get; set; }
        public virtual DbSet<MatchCode6aefcc923b8b4c5ebe286f077c2227a3> MatchCode6aefcc923b8b4c5ebe286f077c2227a3 { get; set; }
        public virtual DbSet<OrganizationUIBase> OrganizationUIBase { get; set; }
        public virtual DbSet<OrgInsightsMetricBase> OrgInsightsMetricBase { get; set; }
        public virtual DbSet<PrincipalSyncAttributeMapBase> PrincipalSyncAttributeMapBase { get; set; }
        public virtual DbSet<SolutionAwareEntitiesForUpgrade> SolutionAwareEntitiesForUpgrade { get; set; }
        public virtual DbSet<SyncAttributeMappingBase> SyncAttributeMappingBase { get; set; }
        public virtual DbSet<SyncAttributeMappingProfileBase> SyncAttributeMappingProfileBase { get; set; }
        public virtual DbSet<SystemUserManagerMap> SystemUserManagerMap { get; set; }
        public virtual DbSet<SystemUserSyncMappingProfiles> SystemUserSyncMappingProfiles { get; set; }
        public virtual DbSet<TeamSyncAttributeMappingProfiles> TeamSyncAttributeMappingProfiles { get; set; }
        public virtual DbSet<UpgradeActionTracker> UpgradeActionTracker { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountBase>()
                .Property(e => e.Revenue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountBase>()
                .Property(e => e.MarketCap)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountBase>()
                .Property(e => e.CreditLimit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<AccountBase>()
                .Property(e => e.Aging30)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountBase>()
                .Property(e => e.Aging60)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountBase>()
                .Property(e => e.Aging90)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<AccountBase>()
                .Property(e => e.CreditLimit_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountBase>()
                .Property(e => e.Aging30_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountBase>()
                .Property(e => e.Revenue_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountBase>()
                .Property(e => e.Aging90_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountBase>()
                .Property(e => e.MarketCap_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountBase>()
                .Property(e => e.Aging60_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountBase>()
                .Property(e => e.OpenRevenue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountBase>()
                .Property(e => e.OpenRevenue_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountBase>()
                .HasMany(e => e.AccountLeads)
                .WithRequired(e => e.AccountBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AccountBase>()
                .HasMany(e => e.AccountBase1)
                .WithOptional(e => e.AccountBase2)
                .HasForeignKey(e => e.MasterId);

            modelBuilder.Entity<AccountBase>()
                .HasMany(e => e.AccountBase11)
                .WithOptional(e => e.AccountBase3)
                .HasForeignKey(e => e.ParentAccountId);

            modelBuilder.Entity<AccountBase>()
                .HasMany(e => e.LeadBase1)
                .WithOptional(e => e.AccountBase1)
                .HasForeignKey(e => e.ParentAccountId);

            modelBuilder.Entity<AccountBase>()
                .HasMany(e => e.new_commercial_offerBase)
                .WithOptional(e => e.AccountBase)
                .HasForeignKey(e => e.new_link_account_id);

            modelBuilder.Entity<AccountBase>()
                .HasMany(e => e.new_expense_contractBase)
                .WithOptional(e => e.AccountBase)
                .HasForeignKey(e => e.new_link_account_expense_contract);

            modelBuilder.Entity<AccountBase>()
                .HasMany(e => e.new_lead_and_possible_contractBase)
                .WithOptional(e => e.AccountBase)
                .HasForeignKey(e => e.new_account_Id);

            modelBuilder.Entity<AccountBase>()
                .HasMany(e => e.new_profit_contractBase)
                .WithOptional(e => e.AccountBase)
                .HasForeignKey(e => e.new_link_account_profit_contract);

            modelBuilder.Entity<AccountBase>()
                .HasMany(e => e.new_project_calculation_parametrBase)
                .WithOptional(e => e.AccountBase)
                .HasForeignKey(e => e.new_project_calculation_parametr_id);

            modelBuilder.Entity<AccountBase>()
                .HasMany(e => e.new_project_initiativeBase)
                .WithOptional(e => e.AccountBase)
                .HasForeignKey(e => e.new_t_account_id);

            modelBuilder.Entity<AccountBase>()
                .HasMany(e => e.new_project_initiative_valuationBase)
                .WithOptional(e => e.AccountBase)
                .HasForeignKey(e => e.new_link_account_id);

            modelBuilder.Entity<AccountBase>()
                .HasMany(e => e.new_t_account_needBase)
                .WithOptional(e => e.AccountBase)
                .HasForeignKey(e => e.new_link_account_id);

            modelBuilder.Entity<AccountBase>()
                .HasMany(e => e.new_t_activityBase)
                .WithOptional(e => e.AccountBase)
                .HasForeignKey(e => e.new_link_account_activity);

            modelBuilder.Entity<AccountBase>()
                .HasMany(e => e.new_t_contractorBase)
                .WithOptional(e => e.AccountBase)
                .HasForeignKey(e => e.new_account_id);

            modelBuilder.Entity<AccountBase>()
                .HasMany(e => e.new_t_projectBase)
                .WithOptional(e => e.AccountBase)
                .HasForeignKey(e => e.new_link_account_Id);

            modelBuilder.Entity<AccountBase>()
                .HasMany(e => e.new_project_initiativeBase1)
                .WithOptional(e => e.AccountBase1)
                .HasForeignKey(e => e.new_link_product_developer_id);

            modelBuilder.Entity<AccountBase>()
                .HasMany(e => e.new_project_initiativeBase2)
                .WithOptional(e => e.AccountBase2)
                .HasForeignKey(e => e.new_link_subsidiary_company_id);

            modelBuilder.Entity<AccountBase>()
                .HasMany(e => e.OpportunityBase)
                .WithOptional(e => e.AccountBase)
                .HasForeignKey(e => e.ParentAccountId);

            modelBuilder.Entity<AccountLeads>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ActionCardBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ActionCardBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ActionCardUserSettingsBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ActivityMimeAttachment>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ActivityPartyBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ActivityPointerBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ActivityPointerBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ActivityPointerBase>()
                .Property(e => e.ActualCost_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ActivityPointerBase>()
                .Property(e => e.BudgetedCost_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ActivityPointerBase>()
                .Property(e => e.ActualCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ActivityPointerBase>()
                .Property(e => e.BudgetedCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ActivityPointerBase>()
                .Property(e => e.ActualRevenue_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ActivityPointerBase>()
                .Property(e => e.ActualRevenue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ActivityPointerBase>()
                .HasMany(e => e.ActivityPartyBase)
                .WithRequired(e => e.ActivityPointerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ActivityPointerBase>()
                .HasMany(e => e.ActivityPointerBase1)
                .WithOptional(e => e.ActivityPointerBase2)
                .HasForeignKey(e => e.OriginatingActivityId);

            modelBuilder.Entity<ActivityPointerBase>()
                .HasMany(e => e.EmailHashBase)
                .WithOptional(e => e.ActivityPointerBase)
                .HasForeignKey(e => e.ActivityId);

            modelBuilder.Entity<ActivityPointerBase>()
                .HasMany(e => e.RecurrenceRuleBase)
                .WithOptional(e => e.ActivityPointerBase)
                .HasForeignKey(e => e.ObjectId);

            modelBuilder.Entity<ActivityPointerBase>()
                .HasMany(e => e.BulkOperationLogBase)
                .WithRequired(e => e.ActivityPointerBase)
                .HasForeignKey(e => e.BulkOperationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ActivityPointerBase>()
                .HasMany(e => e.EmailHashBase1)
                .WithOptional(e => e.ActivityPointerBase1)
                .HasForeignKey(e => e.ActivityId);

            modelBuilder.Entity<ActivityPointerBase>()
                .HasMany(e => e.ActivityPointerBase11)
                .WithOptional(e => e.ActivityPointerBase3)
                .HasForeignKey(e => e.ParentActivityId);

            modelBuilder.Entity<ActivityPointerBase>()
                .HasOptional(e => e.AppointmentBase)
                .WithRequired(e => e.ActivityPointerBase);

            modelBuilder.Entity<ActivityPointerBase>()
                .HasOptional(e => e.CampaignActivityBase)
                .WithRequired(e => e.ActivityPointerBase);

            modelBuilder.Entity<ActivityPointerBase>()
                .HasOptional(e => e.CampaignResponseBase)
                .WithRequired(e => e.ActivityPointerBase);

            modelBuilder.Entity<ActivityPointerBase>()
                .HasOptional(e => e.EmailBase)
                .WithRequired(e => e.ActivityPointerBase);

            modelBuilder.Entity<ActivityPointerBase>()
                .HasOptional(e => e.FaxBase)
                .WithRequired(e => e.ActivityPointerBase);

            modelBuilder.Entity<ActivityPointerBase>()
                .HasOptional(e => e.LetterBase)
                .WithRequired(e => e.ActivityPointerBase);

            modelBuilder.Entity<ActivityPointerBase>()
                .HasOptional(e => e.PhoneCallBase)
                .WithRequired(e => e.ActivityPointerBase);

            modelBuilder.Entity<ActivityPointerBase>()
                .HasOptional(e => e.RecurringAppointmentMasterExtensionBase)
                .WithRequired(e => e.ActivityPointerBase);

            modelBuilder.Entity<ActivityPointerBase>()
                .HasOptional(e => e.ServiceAppointmentBase)
                .WithRequired(e => e.ActivityPointerBase);

            modelBuilder.Entity<ActivityPointerBase>()
                .HasOptional(e => e.SocialActivityBase)
                .WithRequired(e => e.ActivityPointerBase);

            modelBuilder.Entity<ActivityPointerBase>()
                .HasOptional(e => e.TaskBase)
                .WithRequired(e => e.ActivityPointerBase);

            modelBuilder.Entity<ActivityPointerBase>()
                .HasOptional(e => e.UntrackedEmailBase)
                .WithRequired(e => e.ActivityPointerBase);

            modelBuilder.Entity<ActivityPointerBase>()
                .HasMany(e => e.CampaignActivityItemBase)
                .WithRequired(e => e.ActivityPointerBase)
                .HasForeignKey(e => e.CampaignActivityId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ActivityPointerBase>()
                .HasMany(e => e.new_project_initiativeBase)
                .WithOptional(e => e.ActivityPointerBase)
                .HasForeignKey(e => e.new_keytask_taskid);

            modelBuilder.Entity<ActivityPointerBase>()
                .HasMany(e => e.new_project_initiative_valuationBase)
                .WithOptional(e => e.ActivityPointerBase)
                .HasForeignKey(e => e.new_KeyTask_TaskId);

            modelBuilder.Entity<ActivityPointerBase>()
                .HasMany(e => e.new_t_activityBase)
                .WithOptional(e => e.ActivityPointerBase)
                .HasForeignKey(e => e.new_KeyTask_TaskId);

            modelBuilder.Entity<AnnotationBase>()
                .Property(e => e.DocumentBody)
                .IsUnicode(false);

            modelBuilder.Entity<AnnotationBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ApplicationFileBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<AppModuleBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<AppModuleComponentBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<AppModuleComponentBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<AppModuleRolesBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<AsyncOperationBase>()
                .Property(e => e.WorkflowState)
                .IsUnicode(false);

            modelBuilder.Entity<Attachment>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<Attachment>()
                .Property(e => e.Body)
                .IsUnicode(false);

            modelBuilder.Entity<AttributeMapBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<bng_SchedulerSessionBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<bng_ShedulerTaskBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<BookableResourceBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<BookableResourceBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<BookableResourceBase>()
                .HasMany(e => e.BookableResourceBookingBase)
                .WithOptional(e => e.BookableResourceBase)
                .HasForeignKey(e => e.Resource);

            modelBuilder.Entity<BookableResourceBase>()
                .HasMany(e => e.BookableResourceCategoryAssnBase)
                .WithOptional(e => e.BookableResourceBase)
                .HasForeignKey(e => e.Resource);

            modelBuilder.Entity<BookableResourceBase>()
                .HasMany(e => e.BookableResourceCharacteristicBase)
                .WithOptional(e => e.BookableResourceBase)
                .HasForeignKey(e => e.Resource);

            modelBuilder.Entity<BookableResourceBase>()
                .HasMany(e => e.BookableResourceGroupBase)
                .WithOptional(e => e.BookableResourceBase)
                .HasForeignKey(e => e.ChildResource);

            modelBuilder.Entity<BookableResourceBase>()
                .HasMany(e => e.BookableResourceGroupBase1)
                .WithOptional(e => e.BookableResourceBase1)
                .HasForeignKey(e => e.ParentResource);

            modelBuilder.Entity<BookableResourceBookingBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<BookableResourceBookingBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<BookableResourceBookingExchangeSyncIdMappingBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<BookableResourceBookingHeaderBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<BookableResourceBookingHeaderBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<BookableResourceBookingHeaderBase>()
                .HasMany(e => e.BookableResourceBookingBase)
                .WithOptional(e => e.BookableResourceBookingHeaderBase)
                .HasForeignKey(e => e.Header);

            modelBuilder.Entity<BookableResourceCategoryAssnBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<BookableResourceCategoryAssnBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<BookableResourceCategoryBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<BookableResourceCategoryBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<BookableResourceCategoryBase>()
                .HasMany(e => e.BookableResourceCategoryAssnBase)
                .WithOptional(e => e.BookableResourceCategoryBase)
                .HasForeignKey(e => e.ResourceCategory);

            modelBuilder.Entity<BookableResourceCharacteristicBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<BookableResourceCharacteristicBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<BookableResourceGroupBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<BookableResourceGroupBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<BookingStatusBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<BookingStatusBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<BookingStatusBase>()
                .HasMany(e => e.BookableResourceBookingBase)
                .WithOptional(e => e.BookingStatusBase)
                .HasForeignKey(e => e.BookingStatus);

            modelBuilder.Entity<BuildVersion>()
                .Property(e => e.TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<BusinessDataLocalizedLabelBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<BusinessProcessFlowInstanceBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<BusinessUnitBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<BusinessUnitBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.AccountBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.ActionCardBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.ActionCardUserSettingsBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.ActivityPointerBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.ActivityPointerBase1)
                .WithOptional(e => e.BusinessUnitBase1)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.AnnotationBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.bng_SchedulerSessionBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.bng_ShedulerTaskBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.BookableResourceBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.BookableResourceBookingBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.BookableResourceBookingExchangeSyncIdMappingBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.BookableResourceBookingHeaderBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.BookableResourceCategoryAssnBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.BookableResourceCategoryBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.BookableResourceCharacteristicBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.BookableResourceGroupBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.BookingStatusBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.BulkDeleteOperationBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.BusinessUnitMap)
                .WithRequired(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.BusinessId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.BusinessUnitMap1)
                .WithRequired(e => e.BusinessUnitBase1)
                .HasForeignKey(e => e.SubBusinessId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.CustomerOpportunityRoleBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.CalendarBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.BusinessUnitId);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.CategoryBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.CharacteristicBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.ConnectionBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.ConstraintBasedGroupBase)
                .WithRequired(e => e.BusinessUnitBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.ContactBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.CustomerRelationshipBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.DynamicPropertyInstanceBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.EmailServerProfileBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.EntitlementBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.EquipmentBase)
                .WithRequired(e => e.BusinessUnitBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.ExchangeSyncIdMappingBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.ExternalPartyBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.GoalBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.GoalRollupQueryBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.IncidentBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.InteractionForEmailBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.InvoiceBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.KnowledgeArticleBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.LeadBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.ListBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.MailboxBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.msdyn_PostAlbumBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.msdyn_wallsavedqueryusersettingsBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_commercial_offerBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_contract_planBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_contract_plan_acceptionBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_contract_plan_adjustment_ccBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_contract_plan_productBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_contract_plan_quarterBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_contract_stringBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_contract_string_historyBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_expense_contractBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_expertiseBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_lead_and_possible_contractBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_licenseBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_Package_of_documentsBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_parameter_project_initiative_evaluationBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_plan_factBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_potential_accountBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_product_of_projectBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_profit_contractBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_project_calculation_parametrBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_Project_deviation_corrective_measureBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_project_initiativeBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_project_initiative_valuationBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_project_project_reporting_indexBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_project_reportingBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_project_reporting_index_plan_factBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_purchaseBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_revenue_by_yearBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_RouteBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_settingBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_StageBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_StepBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_successful_project_historyBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_successful_project_history_productBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_t_account_needBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_t_ActBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_t_activityBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_t_contract_productBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_t_contractorBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_t_projectBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_t_project_riskBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_t_project_taskBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_TransferBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.OpportunityBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.SalesOrderBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.BusinessUnitBase1)
                .WithOptional(e => e.BusinessUnitBase2)
                .HasForeignKey(e => e.ParentBusinessUnitId);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.PostFollowBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.PostRegardingBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.RegardingObjectOwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.QueueBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.BusinessUnitId);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.QueueBase1)
                .WithOptional(e => e.BusinessUnitBase1)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.QuoteBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.RatingModelBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.RatingValueBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.ResourceSpecBase)
                .WithRequired(e => e.BusinessUnitBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.ResourceBase)
                .WithRequired(e => e.BusinessUnitBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.ContractBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.SharePointDocumentBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.SharePointDocumentBase1)
                .WithOptional(e => e.BusinessUnitBase1)
                .HasForeignKey(e => e.BusinessUnitId);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.SharePointDocumentLocationBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.SharePointSiteBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.SocialProfileBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.SystemUserBase)
                .WithRequired(e => e.BusinessUnitBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.TeamBase)
                .WithRequired(e => e.BusinessUnitBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.TraceRegardingBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.RegardingObjectOwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.UserSettingsBase)
                .WithRequired(e => e.BusinessUnitBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.UserApplicationMetadataBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.UserFormBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.UserQueryBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.UserQueryVisualizationBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.CampaignBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.ImportDataBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.ImportFileBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.ImportLogBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.ImportMapBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.ImportBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.MailboxTrackingFolderBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.SyncErrorBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_contract_planBase1)
                .WithOptional(e => e.BusinessUnitBase1)
                .HasForeignKey(e => e.new_link_businessunit_MRF_id);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_project_initiativeBase1)
                .WithOptional(e => e.BusinessUnitBase1)
                .HasForeignKey(e => e.new_link_businessunit_MRF_id);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_territoryBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.new_link_businessunit_MRF_id);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_businessunit_roleBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.new_businessunit_Id);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_contract_planBase2)
                .WithOptional(e => e.BusinessUnitBase2)
                .HasForeignKey(e => e.new_link_businessunit_id);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_contract_plan_adjustment_ccBase1)
                .WithOptional(e => e.BusinessUnitBase1)
                .HasForeignKey(e => e.new_link_businessunit_MRF_id);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_expense_contractBase1)
                .WithOptional(e => e.BusinessUnitBase1)
                .HasForeignKey(e => e.new_link_businessunit_expense_contrac);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_expertiseBase1)
                .WithOptional(e => e.BusinessUnitBase1)
                .HasForeignKey(e => e.new_link_businessunit_Id);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_profit_contractBase1)
                .WithOptional(e => e.BusinessUnitBase1)
                .HasForeignKey(e => e.new_link_businessunit_profit_contract);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_project_initiativeBase2)
                .WithOptional(e => e.BusinessUnitBase2)
                .HasForeignKey(e => e.new_link_department_project_initiativ);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_project_reportingBase1)
                .WithOptional(e => e.BusinessUnitBase1)
                .HasForeignKey(e => e.new_link_businessunit_Id);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_t_activityBase1)
                .WithOptional(e => e.BusinessUnitBase1)
                .HasForeignKey(e => e.new_link_d_businessunit_t_activity);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_t_activityBase2)
                .WithOptional(e => e.BusinessUnitBase2)
                .HasForeignKey(e => e.new_link_businessunit_MRF_id);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_t_projectBase1)
                .WithOptional(e => e.BusinessUnitBase1)
                .HasForeignKey(e => e.new_link_department_project);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_t_project_taskBase1)
                .WithOptional(e => e.BusinessUnitBase1)
                .HasForeignKey(e => e.new_link_department_project_task);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.new_territoryBase1)
                .WithOptional(e => e.BusinessUnitBase1)
                .HasForeignKey(e => e.new_link_businessunit_id);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.ProcessSessionBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.SystemUserBusinessUnitEntityMap)
                .WithRequired(e => e.BusinessUnitBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.UserEntityInstanceDataBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitBase>()
                .HasMany(e => e.UserEntityUISettingsBase)
                .WithOptional(e => e.BusinessUnitBase)
                .HasForeignKey(e => e.OwningBusinessUnit);

            modelBuilder.Entity<BusinessUnitMap>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<BusinessUnitNewsArticleBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<CalendarBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<CalendarBase>()
                .HasMany(e => e.BusinessUnitBase1)
                .WithOptional(e => e.CalendarBase1)
                .HasForeignKey(e => e.CalendarId);

            modelBuilder.Entity<CalendarBase>()
                .HasMany(e => e.CalendarRuleBase)
                .WithRequired(e => e.CalendarBase)
                .HasForeignKey(e => e.CalendarId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CalendarBase>()
                .HasMany(e => e.CalendarBase1)
                .WithOptional(e => e.CalendarBase2)
                .HasForeignKey(e => e.HolidayScheduleCalendarId);

            modelBuilder.Entity<CalendarBase>()
                .HasMany(e => e.EquipmentBase)
                .WithRequired(e => e.CalendarBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CalendarBase>()
                .HasMany(e => e.OrganizationBase)
                .WithOptional(e => e.CalendarBase)
                .HasForeignKey(e => e.BusinessClosureCalendarId);

            modelBuilder.Entity<CalendarBase>()
                .HasMany(e => e.CalendarRuleBase1)
                .WithOptional(e => e.CalendarBase1)
                .HasForeignKey(e => e.InnerCalendarId);

            modelBuilder.Entity<CalendarRuleBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<CampaignActivityItemBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<CampaignBase>()
                .Property(e => e.BudgetedCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CampaignBase>()
                .Property(e => e.TotalActualCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CampaignBase>()
                .Property(e => e.ExpectedRevenue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CampaignBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<CampaignBase>()
                .Property(e => e.OtherCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CampaignBase>()
                .Property(e => e.TotalCampaignActivityActualCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CampaignBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<CampaignBase>()
                .Property(e => e.TotalCampaignActivityActualCost_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CampaignBase>()
                .Property(e => e.BudgetedCost_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CampaignBase>()
                .Property(e => e.ExpectedRevenue_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CampaignBase>()
                .Property(e => e.OtherCost_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CampaignBase>()
                .Property(e => e.TotalActualCost_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CampaignBase>()
                .HasMany(e => e.CampaignItemBase)
                .WithRequired(e => e.CampaignBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CampaignItemBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<CardTypeBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<CardTypeBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<CategoryBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<CategoryBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<CategoryBase>()
                .HasMany(e => e.KnowledgeArticlesCategories)
                .WithRequired(e => e.CategoryBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChannelAccessProfileBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ChannelAccessProfileBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ChannelAccessProfileEntityAccessLevelBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ChannelAccessProfileRuleBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ChannelAccessProfileRuleBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ChannelAccessProfileRuleItemBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ChannelAccessProfileRuleItemBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ChannelPropertyBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ChannelPropertyGroupBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<CharacteristicBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<CharacteristicBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<CharacteristicBase>()
                .HasMany(e => e.BookableResourceCharacteristicBase)
                .WithOptional(e => e.CharacteristicBase)
                .HasForeignKey(e => e.Characteristic);

            modelBuilder.Entity<ClientUpdate>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<CompetitorAddressBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<CompetitorBase>()
                .Property(e => e.ReportedRevenue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CompetitorBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<CompetitorBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<CompetitorBase>()
                .Property(e => e.ReportedRevenue_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CompetitorBase>()
                .HasMany(e => e.CompetitorAddressBase)
                .WithRequired(e => e.CompetitorBase)
                .HasForeignKey(e => e.ParentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompetitorBase>()
                .HasMany(e => e.LeadCompetitors)
                .WithRequired(e => e.CompetitorBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompetitorBase>()
                .HasMany(e => e.OpportunityCompetitors)
                .WithRequired(e => e.CompetitorBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompetitorBase>()
                .HasMany(e => e.CompetitorProduct)
                .WithRequired(e => e.CompetitorBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompetitorBase>()
                .HasMany(e => e.CompetitorSalesLiterature)
                .WithRequired(e => e.CompetitorBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompetitorProduct>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<CompetitorSalesLiterature>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ComplexControlBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ConnectionBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ConnectionBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ConnectionBase>()
                .HasMany(e => e.ConnectionBase1)
                .WithOptional(e => e.ConnectionBase2)
                .HasForeignKey(e => e.RelatedConnectionId);

            modelBuilder.Entity<ConnectionRoleAssociation>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ConnectionRoleBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ConnectionRoleBaseIds>()
                .HasMany(e => e.ConnectionBase)
                .WithOptional(e => e.ConnectionRoleBaseIds)
                .HasForeignKey(e => e.Record1RoleId);

            modelBuilder.Entity<ConnectionRoleBaseIds>()
                .HasMany(e => e.ConnectionBase1)
                .WithOptional(e => e.ConnectionRoleBaseIds1)
                .HasForeignKey(e => e.Record2RoleId);

            modelBuilder.Entity<ConnectionRoleBaseIds>()
                .HasMany(e => e.ConnectionRoleAssociation)
                .WithRequired(e => e.ConnectionRoleBaseIds)
                .HasForeignKey(e => e.AssociatedConnectionRoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConnectionRoleBaseIds>()
                .HasMany(e => e.ConnectionRoleAssociation1)
                .WithRequired(e => e.ConnectionRoleBaseIds1)
                .HasForeignKey(e => e.ConnectionRoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConnectionRoleBaseIds>()
                .HasMany(e => e.ConnectionRoleObjectTypeCodeBase)
                .WithRequired(e => e.ConnectionRoleBaseIds)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConnectionRoleObjectTypeCodeBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ConstraintBasedGroupBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ContactBase>()
                .Property(e => e.AnnualIncome)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ContactBase>()
                .Property(e => e.CreditLimit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ContactBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ContactBase>()
                .Property(e => e.Aging30)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ContactBase>()
                .Property(e => e.Aging60)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ContactBase>()
                .Property(e => e.Aging90)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ContactBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ContactBase>()
                .Property(e => e.AnnualIncome_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ContactBase>()
                .Property(e => e.CreditLimit_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ContactBase>()
                .Property(e => e.Aging60_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ContactBase>()
                .Property(e => e.Aging90_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ContactBase>()
                .Property(e => e.Aging30_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ContactBase>()
                .HasMany(e => e.AccountBase)
                .WithOptional(e => e.ContactBase)
                .HasForeignKey(e => e.PrimaryContactId);

            modelBuilder.Entity<ContactBase>()
                .HasMany(e => e.IncidentBase)
                .WithOptional(e => e.ContactBase)
                .HasForeignKey(e => e.PrimaryContactId);

            modelBuilder.Entity<ContactBase>()
                .HasMany(e => e.IncidentBase1)
                .WithOptional(e => e.ContactBase1)
                .HasForeignKey(e => e.ResponsibleContactId);

            modelBuilder.Entity<ContactBase>()
                .HasMany(e => e.EntitlementContacts)
                .WithRequired(e => e.ContactBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContactBase>()
                .HasMany(e => e.ContactInvoices)
                .WithRequired(e => e.ContactBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContactBase>()
                .HasMany(e => e.ContactLeads)
                .WithRequired(e => e.ContactBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContactBase>()
                .HasMany(e => e.ContactBase1)
                .WithOptional(e => e.ContactBase2)
                .HasForeignKey(e => e.MasterId);

            modelBuilder.Entity<ContactBase>()
                .HasMany(e => e.ContactOrders)
                .WithRequired(e => e.ContactBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContactBase>()
                .HasMany(e => e.ContactQuotes)
                .WithRequired(e => e.ContactBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContactBase>()
                .HasMany(e => e.ServiceContractContacts)
                .WithRequired(e => e.ContactBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContactBase>()
                .HasMany(e => e.LeadBase1)
                .WithOptional(e => e.ContactBase1)
                .HasForeignKey(e => e.ParentContactId);

            modelBuilder.Entity<ContactBase>()
                .HasMany(e => e.FeedbackBase)
                .WithOptional(e => e.ContactBase)
                .HasForeignKey(e => e.CreatedByContact);

            modelBuilder.Entity<ContactBase>()
                .HasMany(e => e.FeedbackBase1)
                .WithOptional(e => e.ContactBase1)
                .HasForeignKey(e => e.CreatedOnBehalfByContact);

            modelBuilder.Entity<ContactBase>()
                .HasMany(e => e.OpportunityBase)
                .WithOptional(e => e.ContactBase)
                .HasForeignKey(e => e.ParentContactId);

            modelBuilder.Entity<ContactInvoices>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ContactLeads>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ContactOrders>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ContactQuotes>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ContractBase>()
                .Property(e => e.TotalPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ContractBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ContractBase>()
                .Property(e => e.TotalDiscount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ContractBase>()
                .Property(e => e.NetPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ContractBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ContractBase>()
                .Property(e => e.TotalDiscount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ContractBase>()
                .Property(e => e.NetPrice_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ContractBase>()
                .Property(e => e.TotalPrice_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ContractBase>()
                .HasMany(e => e.ContractDetailBase)
                .WithRequired(e => e.ContractBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContractBase>()
                .HasMany(e => e.ContractBase1)
                .WithOptional(e => e.ContractBase2)
                .HasForeignKey(e => e.OriginatingContract);

            modelBuilder.Entity<ContractBase>()
                .HasMany(e => e.ServiceContractContacts)
                .WithRequired(e => e.ContractBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContractDetailBase>()
                .Property(e => e.Rate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ContractDetailBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ContractDetailBase>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ContractDetailBase>()
                .Property(e => e.Discount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ContractDetailBase>()
                .Property(e => e.Net)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ContractDetailBase>()
                .Property(e => e.DiscountPercentage)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ContractDetailBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ContractDetailBase>()
                .Property(e => e.Discount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ContractDetailBase>()
                .Property(e => e.Rate_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ContractDetailBase>()
                .Property(e => e.Price_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ContractDetailBase>()
                .Property(e => e.Net_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ContractTemplateBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ContractTemplateBaseIds>()
                .HasMany(e => e.ContractBase)
                .WithRequired(e => e.ContractTemplateBaseIds)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConvertRuleBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ConvertRuleBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ConvertRuleItemBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ConvertRuleItemBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<CustomControlBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<CustomControlResourceBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<CustomerAddressBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<CustomerAddressBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<CustomerAddressBase>()
                .HasMany(e => e.ContractBase)
                .WithOptional(e => e.CustomerAddressBase)
                .HasForeignKey(e => e.BillToAddress);

            modelBuilder.Entity<CustomerAddressBase>()
                .HasMany(e => e.ContractBase1)
                .WithOptional(e => e.CustomerAddressBase1)
                .HasForeignKey(e => e.ServiceAddress);

            modelBuilder.Entity<CustomerAddressBase>()
                .HasMany(e => e.ContractDetailBase)
                .WithOptional(e => e.CustomerAddressBase)
                .HasForeignKey(e => e.ServiceAddress);

            modelBuilder.Entity<CustomerOpportunityRoleBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<CustomerRelationshipBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<CustomerRelationshipBase>()
                .HasMany(e => e.CustomerRelationshipBase1)
                .WithOptional(e => e.CustomerRelationshipBase2)
                .HasForeignKey(e => e.ConverseRelationshipId);

            modelBuilder.Entity<DataPerformance>()
                .Property(e => e.Weight)
                .HasPrecision(23, 10);

            modelBuilder.Entity<DataPerformance>()
                .Property(e => e.OptimizationStorage)
                .HasPrecision(23, 10);

            modelBuilder.Entity<DataPerformance>()
                .Property(e => e.MedianTime)
                .HasPrecision(23, 10);

            modelBuilder.Entity<DataPerformance>()
                .Property(e => e.OptimizationImpact)
                .HasPrecision(23, 10);

            modelBuilder.Entity<DataPerformance>()
                .Property(e => e.MaxTime)
                .HasPrecision(23, 10);

            modelBuilder.Entity<DataPerformance>()
                .Property(e => e.MinTime)
                .HasPrecision(23, 10);

            modelBuilder.Entity<DependencyNodeBase>()
                .HasMany(e => e.DependencyBase)
                .WithOptional(e => e.DependencyNodeBase)
                .HasForeignKey(e => e.RequiredComponentNodeId);

            modelBuilder.Entity<DependencyNodeBase>()
                .HasMany(e => e.DependencyBase1)
                .WithOptional(e => e.DependencyNodeBase1)
                .HasForeignKey(e => e.DependentComponentNodeId);

            modelBuilder.Entity<DiscountBase>()
                .Property(e => e.LowQuantity)
                .HasPrecision(23, 10);

            modelBuilder.Entity<DiscountBase>()
                .Property(e => e.HighQuantity)
                .HasPrecision(23, 10);

            modelBuilder.Entity<DiscountBase>()
                .Property(e => e.Percentage)
                .HasPrecision(23, 10);

            modelBuilder.Entity<DiscountBase>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DiscountBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<DiscountBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<DiscountBase>()
                .Property(e => e.Amount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DiscountTypeBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<DiscountTypeBase>()
                .HasMany(e => e.DiscountBase)
                .WithRequired(e => e.DiscountTypeBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DisplayStringBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<DocumentIndex>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<DocumentTemplateBase>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentTemplateBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<DocumentTemplateBase>()
                .Property(e => e.ClientData)
                .IsUnicode(false);

            modelBuilder.Entity<DynamicPropertyAssociationBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<DynamicPropertyAssociationBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<DynamicPropertyBase>()
                .Property(e => e.MaxValueDecimal)
                .HasPrecision(23, 10);

            modelBuilder.Entity<DynamicPropertyBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<DynamicPropertyBase>()
                .Property(e => e.MinValueDecimal)
                .HasPrecision(23, 10);

            modelBuilder.Entity<DynamicPropertyBase>()
                .Property(e => e.DefaultValueDecimal)
                .HasPrecision(23, 10);

            modelBuilder.Entity<DynamicPropertyBase>()
                .HasMany(e => e.DynamicPropertyBase1)
                .WithOptional(e => e.DynamicPropertyBase2)
                .HasForeignKey(e => e.BaseDynamicPropertyId);

            modelBuilder.Entity<DynamicPropertyInstanceBase>()
                .Property(e => e.ValueDecimal)
                .HasPrecision(23, 10);

            modelBuilder.Entity<DynamicPropertyInstanceBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<DynamicPropertyInstanceBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<DynamicPropertyOptionSetItemBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<DynamicPropertyOptionSetItemBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<EmailHashBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<EmailSearchBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<EmailServerProfileBase>()
                .HasMany(e => e.MailboxBase)
                .WithOptional(e => e.EmailServerProfileBase)
                .HasForeignKey(e => e.EmailServerProfile);

            modelBuilder.Entity<EmailServerProfileBase>()
                .HasMany(e => e.OrganizationBase)
                .WithOptional(e => e.EmailServerProfileBase)
                .HasForeignKey(e => e.DefaultEmailServerProfileId);

            modelBuilder.Entity<EntitlementBase>()
                .Property(e => e.RemainingTerms)
                .HasPrecision(23, 10);

            modelBuilder.Entity<EntitlementBase>()
                .Property(e => e.TotalTerms)
                .HasPrecision(23, 10);

            modelBuilder.Entity<EntitlementBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<EntitlementBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<EntitlementBase>()
                .HasMany(e => e.EntitlementContacts)
                .WithRequired(e => e.EntitlementBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EntitlementBase>()
                .HasMany(e => e.EntitlementProducts)
                .WithRequired(e => e.EntitlementBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EntitlementChannelBase>()
                .Property(e => e.TotalTerms)
                .HasPrecision(23, 10);

            modelBuilder.Entity<EntitlementChannelBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<EntitlementChannelBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<EntitlementChannelBase>()
                .Property(e => e.RemainingTerms)
                .HasPrecision(23, 10);

            modelBuilder.Entity<EntitlementContacts>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<EntitlementProducts>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<EntitlementTemplateBase>()
                .Property(e => e.TotalTerms)
                .HasPrecision(23, 10);

            modelBuilder.Entity<EntitlementTemplateBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<EntitlementTemplateBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<EntitlementTemplateBase>()
                .HasMany(e => e.EntitlementTemplateProducts)
                .WithRequired(e => e.EntitlementTemplateBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EntitlementTemplateChannelBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<EntitlementTemplateChannelBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<EntitlementTemplateChannelBase>()
                .Property(e => e.TotalTerms)
                .HasPrecision(23, 10);

            modelBuilder.Entity<EntitlementTemplateProducts>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<EntityMapBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<EquipmentBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<EquipmentBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<EquipmentBase>()
                .HasMany(e => e.AccountBase)
                .WithOptional(e => e.EquipmentBase)
                .HasForeignKey(e => e.PreferredEquipmentId);

            modelBuilder.Entity<EquipmentBase>()
                .HasMany(e => e.ContactBase)
                .WithOptional(e => e.EquipmentBase)
                .HasForeignKey(e => e.PreferredEquipmentId);

            modelBuilder.Entity<ExchangeSyncIdMappingBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ExpiredProcessBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ExpiredProcessBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ExternalPartyBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ExternalPartyBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ExternalPartyItemBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ExternalPartyItemBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<FeedbackBase>()
                .Property(e => e.NormalizedRating)
                .HasPrecision(23, 10);

            modelBuilder.Entity<FeedbackBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<FeedbackBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<FieldPermissionBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<FieldSecurityProfileBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<GoalBase>()
                .Property(e => e.ComputedTargetAsOfTodayMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GoalBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<GoalBase>()
                .Property(e => e.InProgressDecimal)
                .HasPrecision(23, 10);

            modelBuilder.Entity<GoalBase>()
                .Property(e => e.Percentage)
                .HasPrecision(23, 10);

            modelBuilder.Entity<GoalBase>()
                .Property(e => e.StretchTargetDecimal)
                .HasPrecision(23, 10);

            modelBuilder.Entity<GoalBase>()
                .Property(e => e.ActualMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GoalBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<GoalBase>()
                .Property(e => e.ActualDecimal)
                .HasPrecision(23, 10);

            modelBuilder.Entity<GoalBase>()
                .Property(e => e.CustomRollupFieldDecimal)
                .HasPrecision(23, 10);

            modelBuilder.Entity<GoalBase>()
                .Property(e => e.ComputedTargetAsOfTodayDecimal)
                .HasPrecision(23, 10);

            modelBuilder.Entity<GoalBase>()
                .Property(e => e.TargetDecimal)
                .HasPrecision(23, 10);

            modelBuilder.Entity<GoalBase>()
                .Property(e => e.StretchTargetMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GoalBase>()
                .Property(e => e.TargetMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GoalBase>()
                .Property(e => e.InProgressMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GoalBase>()
                .Property(e => e.ComputedTargetAsOfTodayPercentageAchieved)
                .HasPrecision(23, 10);

            modelBuilder.Entity<GoalBase>()
                .Property(e => e.CustomRollupFieldMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GoalBase>()
                .Property(e => e.CustomRollupFieldMoney_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GoalBase>()
                .Property(e => e.ActualMoney_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GoalBase>()
                .Property(e => e.TargetMoney_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GoalBase>()
                .Property(e => e.StretchTargetMoney_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GoalBase>()
                .Property(e => e.InProgressMoney_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GoalBase>()
                .Property(e => e.ComputedTargetAsOfTodayMoney_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GoalBase>()
                .HasMany(e => e.GoalBase1)
                .WithOptional(e => e.GoalBase2)
                .HasForeignKey(e => e.ParentGoalId);

            modelBuilder.Entity<GoalBase>()
                .HasMany(e => e.GoalBase11)
                .WithOptional(e => e.GoalBase3)
                .HasForeignKey(e => e.GoalWithErrorId);

            modelBuilder.Entity<GoalRollupQueryBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<GoalRollupQueryBase>()
                .HasMany(e => e.GoalBase)
                .WithOptional(e => e.GoalRollupQueryBase)
                .HasForeignKey(e => e.RollUpQueryActualDecimalId);

            modelBuilder.Entity<GoalRollupQueryBase>()
                .HasMany(e => e.GoalBase1)
                .WithOptional(e => e.GoalRollupQueryBase1)
                .HasForeignKey(e => e.RollUpQueryActualMoneyId);

            modelBuilder.Entity<GoalRollupQueryBase>()
                .HasMany(e => e.GoalBase2)
                .WithOptional(e => e.GoalRollupQueryBase2)
                .HasForeignKey(e => e.RollUpQueryCustomDecimalId);

            modelBuilder.Entity<GoalRollupQueryBase>()
                .HasMany(e => e.GoalBase3)
                .WithOptional(e => e.GoalRollupQueryBase3)
                .HasForeignKey(e => e.RollUpQueryCustomIntegerId);

            modelBuilder.Entity<GoalRollupQueryBase>()
                .HasMany(e => e.GoalBase4)
                .WithOptional(e => e.GoalRollupQueryBase4)
                .HasForeignKey(e => e.RollUpQueryCustomMoneyId);

            modelBuilder.Entity<GoalRollupQueryBase>()
                .HasMany(e => e.GoalBase5)
                .WithOptional(e => e.GoalRollupQueryBase5)
                .HasForeignKey(e => e.RollUpQueryInprogressDecimalId);

            modelBuilder.Entity<GoalRollupQueryBase>()
                .HasMany(e => e.GoalBase6)
                .WithOptional(e => e.GoalRollupQueryBase6)
                .HasForeignKey(e => e.RollUpQueryInprogressIntegerId);

            modelBuilder.Entity<GoalRollupQueryBase>()
                .HasMany(e => e.GoalBase7)
                .WithOptional(e => e.GoalRollupQueryBase7)
                .HasForeignKey(e => e.RollUpQueryInprogressMoneyId);

            modelBuilder.Entity<GoalRollupQueryBase>()
                .HasMany(e => e.GoalBase8)
                .WithOptional(e => e.GoalRollupQueryBase8)
                .HasForeignKey(e => e.RollupQueryActualIntegerId);

            modelBuilder.Entity<HierarchyRuleBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<HierarchySecurityConfiguration>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ImportBase>()
                .HasMany(e => e.ImportFileBase)
                .WithRequired(e => e.ImportBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IncidentBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<IncidentBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<IncidentBase>()
                .HasMany(e => e.IncidentKnowledgeBaseRecord)
                .WithRequired(e => e.IncidentBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IncidentBase>()
                .HasMany(e => e.LeadBase)
                .WithOptional(e => e.IncidentBase)
                .HasForeignKey(e => e.OriginatingCaseId);

            modelBuilder.Entity<IncidentKnowledgeBaseRecord>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<IntegrationStatusBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<InteractionForEmailBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<InteractionForEmailBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<InternalAddressBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<InvoiceBase>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceBase>()
                .Property(e => e.FreightAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceBase>()
                .Property(e => e.TotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceBase>()
                .Property(e => e.TotalLineItemAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceBase>()
                .Property(e => e.TotalLineItemDiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceBase>()
                .Property(e => e.TotalAmountLessFreight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceBase>()
                .Property(e => e.TotalDiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceBase>()
                .Property(e => e.TotalTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<InvoiceBase>()
                .Property(e => e.DiscountPercentage)
                .HasPrecision(23, 10);

            modelBuilder.Entity<InvoiceBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<InvoiceBase>()
                .Property(e => e.TotalLineItemAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceBase>()
                .Property(e => e.TotalLineItemDiscountAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceBase>()
                .Property(e => e.TotalTax_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceBase>()
                .Property(e => e.TotalAmountLessFreight_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceBase>()
                .Property(e => e.DiscountAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceBase>()
                .Property(e => e.TotalAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceBase>()
                .Property(e => e.FreightAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceBase>()
                .Property(e => e.TotalDiscountAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceBase>()
                .HasMany(e => e.ContactInvoices)
                .WithRequired(e => e.InvoiceBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InvoiceBase>()
                .HasMany(e => e.InvoiceDetailBase)
                .WithRequired(e => e.InvoiceBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InvoiceDetailBase>()
                .Property(e => e.QuantityBackordered)
                .HasPrecision(23, 10);

            modelBuilder.Entity<InvoiceDetailBase>()
                .Property(e => e.Quantity)
                .HasPrecision(23, 10);

            modelBuilder.Entity<InvoiceDetailBase>()
                .Property(e => e.ManualDiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceDetailBase>()
                .Property(e => e.VolumeDiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceDetailBase>()
                .Property(e => e.PricePerUnit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceDetailBase>()
                .Property(e => e.BaseAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceDetailBase>()
                .Property(e => e.QuantityCancelled)
                .HasPrecision(23, 10);

            modelBuilder.Entity<InvoiceDetailBase>()
                .Property(e => e.ExtendedAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceDetailBase>()
                .Property(e => e.Tax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceDetailBase>()
                .Property(e => e.QuantityShipped)
                .HasPrecision(23, 10);

            modelBuilder.Entity<InvoiceDetailBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<InvoiceDetailBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<InvoiceDetailBase>()
                .Property(e => e.VolumeDiscountAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceDetailBase>()
                .Property(e => e.BaseAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceDetailBase>()
                .Property(e => e.PricePerUnit_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceDetailBase>()
                .Property(e => e.Tax_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceDetailBase>()
                .Property(e => e.ExtendedAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceDetailBase>()
                .Property(e => e.ManualDiscountAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceDetailBase>()
                .HasMany(e => e.InvoiceDetailBase1)
                .WithOptional(e => e.InvoiceDetailBase2)
                .HasForeignKey(e => e.ParentBundleId);

            modelBuilder.Entity<IsvConfigBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<KbArticleBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<KbArticleBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<KbArticleBase>()
                .HasMany(e => e.KbArticleCommentBase)
                .WithRequired(e => e.KbArticleBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KbArticleCommentBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<KbArticleTemplateBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<KbArticleTemplateBaseIds>()
                .HasMany(e => e.KbArticleBase)
                .WithRequired(e => e.KbArticleTemplateBaseIds)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KnowledgeArticleBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<KnowledgeArticleBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<KnowledgeArticleBase>()
                .Property(e => e.Rating)
                .HasPrecision(23, 10);

            modelBuilder.Entity<KnowledgeArticleBase>()
                .Property(e => e.Rating_Sum)
                .HasPrecision(23, 10);

            modelBuilder.Entity<KnowledgeArticleBase>()
                .HasMany(e => e.KnowledgeArticlesCategories)
                .WithRequired(e => e.KnowledgeArticleBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KnowledgeArticleBase>()
                .HasMany(e => e.KnowledgeArticleBase1)
                .WithOptional(e => e.KnowledgeArticleBase2)
                .HasForeignKey(e => e.ParentArticleContentId);

            modelBuilder.Entity<KnowledgeArticleBase>()
                .HasMany(e => e.KnowledgeArticleBase11)
                .WithOptional(e => e.KnowledgeArticleBase3)
                .HasForeignKey(e => e.PreviousArticleContentId);

            modelBuilder.Entity<KnowledgeArticleBase>()
                .HasMany(e => e.KnowledgeArticleBase12)
                .WithOptional(e => e.KnowledgeArticleBase4)
                .HasForeignKey(e => e.RootArticleId);

            modelBuilder.Entity<KnowledgeArticleIncidentBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<KnowledgeArticleIncidentBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<KnowledgeArticlesCategories>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<KnowledgeArticleViewsBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<KnowledgeArticleViewsBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<KnowledgeBaseRecordBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<KnowledgeBaseRecordBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<KnowledgeBaseRecordBase>()
                .HasMany(e => e.IncidentKnowledgeBaseRecord)
                .WithRequired(e => e.KnowledgeBaseRecordBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LanguageLocale>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<LeadAddressBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<LeadAddressBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<LeadBase>()
                .Property(e => e.Revenue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LeadBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<LeadBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<LeadBase>()
                .Property(e => e.EstimatedAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LeadBase>()
                .Property(e => e.EstimatedAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LeadBase>()
                .Property(e => e.Revenue_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LeadBase>()
                .Property(e => e.BudgetAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LeadBase>()
                .Property(e => e.BudgetAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LeadBase>()
                .HasMany(e => e.AccountBase)
                .WithOptional(e => e.LeadBase)
                .HasForeignKey(e => e.OriginatingLeadId);

            modelBuilder.Entity<LeadBase>()
                .HasMany(e => e.AccountLeads)
                .WithRequired(e => e.LeadBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LeadBase>()
                .HasMany(e => e.ContactBase)
                .WithOptional(e => e.LeadBase)
                .HasForeignKey(e => e.OriginatingLeadId);

            modelBuilder.Entity<LeadBase>()
                .HasMany(e => e.ContactLeads)
                .WithRequired(e => e.LeadBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LeadBase>()
                .HasMany(e => e.LeadAddressBase)
                .WithRequired(e => e.LeadBase)
                .HasForeignKey(e => e.ParentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LeadBase>()
                .HasMany(e => e.LeadCompetitors)
                .WithRequired(e => e.LeadBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LeadBase>()
                .HasMany(e => e.LeadBase1)
                .WithOptional(e => e.LeadBase2)
                .HasForeignKey(e => e.MasterId);

            modelBuilder.Entity<LeadBase>()
                .HasMany(e => e.OpportunityBase1)
                .WithOptional(e => e.LeadBase1)
                .HasForeignKey(e => e.OriginatingLeadId);

            modelBuilder.Entity<LeadBase>()
                .HasMany(e => e.LeadProduct)
                .WithRequired(e => e.LeadBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LeadCompetitors>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<LeadProduct>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<LeadToOpportunitySalesProcessBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<LeadToOpportunitySalesProcessBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ListBase>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ListBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ListBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ListBase>()
                .Property(e => e.Cost_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ListBase>()
                .HasMany(e => e.ListMemberBase)
                .WithRequired(e => e.ListBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ListMemberBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<MailboxBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<MailboxBase>()
                .HasMany(e => e.QueueBase)
                .WithOptional(e => e.MailboxBase)
                .HasForeignKey(e => e.DefaultMailbox);

            modelBuilder.Entity<MailboxBase>()
                .HasMany(e => e.SystemUserBase)
                .WithOptional(e => e.MailboxBase)
                .HasForeignKey(e => e.DefaultMailbox);

            modelBuilder.Entity<MailMergeTemplateBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<MailMergeTemplateBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<MetadataSyncTrackingDeletedObject>()
                .Property(e => e.Timestamp)
                .IsFixedLength();

            modelBuilder.Entity<MetadataTimestamp>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<MetricBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<MobileOfflineProfileBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<MobileOfflineProfileBaseIds>()
                .HasMany(e => e.OrganizationBase)
                .WithOptional(e => e.MobileOfflineProfileBaseIds)
                .HasForeignKey(e => e.DefaultMobileOfflineProfileId);

            modelBuilder.Entity<MobileOfflineProfileItemAssociationBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<MobileOfflineProfileItemBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<msdyn_PostAlbumBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<msdyn_PostConfigBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<msdyn_PostConfigBase>()
                .HasMany(e => e.msdyn_wallsavedqueryBase)
                .WithOptional(e => e.msdyn_PostConfigBase)
                .HasForeignKey(e => e.msdyn_postconfigurationid);

            modelBuilder.Entity<msdyn_PostRuleConfigBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<msdyn_wallsavedqueryBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<msdyn_wallsavedqueryusersettingsBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<MultiEntitySearchBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<MultiEntitySearchBase>()
                .HasMany(e => e.MultiEntitySearchEntities)
                .WithRequired(e => e.MultiEntitySearchBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MultiEntitySearchEntities>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_account_needBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_account_needBase>()
                .HasMany(e => e.new_new_account_need_new_t_account_needBase)
                .WithRequired(e => e.new_account_needBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<new_article_of_Profit_and_ExpenseBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_article_of_Profit_and_ExpenseBase>()
                .HasMany(e => e.new_contract_stringBase)
                .WithOptional(e => e.new_article_of_Profit_and_ExpenseBase)
                .HasForeignKey(e => e.new_article_of_profit_and_expense_Id);

            modelBuilder.Entity<new_assessmentinitiativeBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_businessunit_roleBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_commercial_offerBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_commercial_offerBase>()
                .Property(e => e.new_sum)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_contract_plan_acceptionBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_contract_plan_acceptionBase>()
                .HasMany(e => e.new_contract_planBase)
                .WithOptional(e => e.new_contract_plan_acceptionBase)
                .HasForeignKey(e => e.new_contract_plan_acception_id);

            modelBuilder.Entity<new_contract_plan_adjustment_ccBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_contract_plan_productBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_contract_plan_productBase>()
                .Property(e => e.new_consulting)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_contract_plan_productBase>()
                .Property(e => e.new_service_1_quarter)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_contract_plan_productBase>()
                .Property(e => e.new_service_2_quarter)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_contract_plan_productBase>()
                .Property(e => e.new_service_3_quarter)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_contract_plan_productBase>()
                .Property(e => e.new_service_4_quarter)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_contract_plan_productBase>()
                .Property(e => e.new_service_year)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_contract_plan_productBase>()
                .Property(e => e.new_consulting_1_quarter)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_contract_plan_productBase>()
                .Property(e => e.new_consulting_2_quarter)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_contract_plan_productBase>()
                .Property(e => e.new_consulting_3_quarter)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_contract_plan_productBase>()
                .Property(e => e.new_consulting_4_quarter)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_contract_plan_productBase>()
                .Property(e => e.new_consulting_year)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_contract_plan_productBase>()
                .Property(e => e.new_year_sum)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_contract_plan_productBase>()
                .Property(e => e.new_product_sum_service)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_contract_plan_productBase>()
                .Property(e => e.new_product_sum_consulting)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_contract_plan_quarterBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_contract_plan_quarterBase>()
                .Property(e => e.new_112_sum_service)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_contract_plan_quarterBase>()
                .Property(e => e.new_112_sum_consulting)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_contract_plan_quarterBase>()
                .Property(e => e.new_RT_medicine_sum_service)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_contract_plan_quarterBase>()
                .Property(e => e.new_RT_medicine_sum_consulting)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_contract_planBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_contract_planBase>()
                .Property(e => e.new_product_sum)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_contract_planBase>()
                .Property(e => e.new_1_auarter)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_contract_planBase>()
                .Property(e => e.new_total)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_contract_planBase>()
                .HasMany(e => e.new_contract_plan_productBase)
                .WithOptional(e => e.new_contract_planBase)
                .HasForeignKey(e => e.new_link_contract_plan_year_id);

            modelBuilder.Entity<new_contract_planBase>()
                .HasMany(e => e.new_contract_plan_quarterBase)
                .WithOptional(e => e.new_contract_planBase)
                .HasForeignKey(e => e.new_contract_plan_year_id);

            modelBuilder.Entity<new_contract_string_historyBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_contract_stringBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_contract_stringBase>()
                .Property(e => e.new_sum)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_contract_stringBase>()
                .HasMany(e => e.new_contract_string_historyBase)
                .WithOptional(e => e.new_contract_stringBase)
                .HasForeignKey(e => e.new_link_contract_string_id);

            modelBuilder.Entity<new_d_doc_typeBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_d_forms_of_possible_incomeBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_d_forms_of_possible_incomeBase>()
                .HasMany(e => e.new_project_initiativeBase)
                .WithOptional(e => e.new_d_forms_of_possible_incomeBase)
                .HasForeignKey(e => e.new_d_forms_of_possible_income_id);

            modelBuilder.Entity<new_d_forms_of_possible_incomeBase>()
                .HasMany(e => e.new_t_activityBase)
                .WithOptional(e => e.new_d_forms_of_possible_incomeBase)
                .HasForeignKey(e => e.new_d_forms_of_possible_income_id);

            modelBuilder.Entity<new_d_possible_legal_formBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_d_possible_legal_formBase>()
                .HasMany(e => e.new_project_initiativeBase)
                .WithOptional(e => e.new_d_possible_legal_formBase)
                .HasForeignKey(e => e.new_d_possible_legal_form_id);

            modelBuilder.Entity<new_d_possible_legal_formBase>()
                .HasMany(e => e.new_t_activityBase)
                .WithOptional(e => e.new_d_possible_legal_formBase)
                .HasForeignKey(e => e.new_d_possible_legal_form_id);

            modelBuilder.Entity<new_d_product_catalogBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_d_product_catalogBase>()
                .HasMany(e => e.new_contract_plan_productBase)
                .WithOptional(e => e.new_d_product_catalogBase)
                .HasForeignKey(e => e.new_link_product_id);

            modelBuilder.Entity<new_d_product_catalogBase>()
                .HasMany(e => e.new_contract_planBase)
                .WithOptional(e => e.new_d_product_catalogBase)
                .HasForeignKey(e => e.new_link_product_id);

            modelBuilder.Entity<new_d_product_catalogBase>()
                .HasMany(e => e.new_document_form_baseBase)
                .WithOptional(e => e.new_d_product_catalogBase)
                .HasForeignKey(e => e.new_product_catalog_Id);

            modelBuilder.Entity<new_d_product_catalogBase>()
                .HasMany(e => e.new_lead_and_possible_contractBase)
                .WithOptional(e => e.new_d_product_catalogBase)
                .HasForeignKey(e => e.new_link_product_Id);

            modelBuilder.Entity<new_d_product_catalogBase>()
                .HasMany(e => e.new_product_of_projectBase)
                .WithOptional(e => e.new_d_product_catalogBase)
                .HasForeignKey(e => e.new_link_product_Id);

            modelBuilder.Entity<new_d_product_catalogBase>()
                .HasMany(e => e.new_project_initiativeBase)
                .WithOptional(e => e.new_d_product_catalogBase)
                .HasForeignKey(e => e.new_d_product_catalog_id);

            modelBuilder.Entity<new_d_product_catalogBase>()
                .HasMany(e => e.new_successful_project_history_productBase)
                .WithOptional(e => e.new_d_product_catalogBase)
                .HasForeignKey(e => e.new_link_product_id);

            modelBuilder.Entity<new_d_product_catalogBase>()
                .HasMany(e => e.new_t_activityBase)
                .WithOptional(e => e.new_d_product_catalogBase)
                .HasForeignKey(e => e.new_link_product_activity);

            modelBuilder.Entity<new_d_product_catalogBase>()
                .HasMany(e => e.new_t_contract_productBase)
                .WithOptional(e => e.new_d_product_catalogBase)
                .HasForeignKey(e => e.new_product_id);

            modelBuilder.Entity<new_d_product_catalogBase>()
                .HasMany(e => e.new_new_d_product_catalog_new_t_projectBase)
                .WithRequired(e => e.new_d_product_catalogBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<new_d_product_groupsBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_d_product_groupsBase>()
                .HasMany(e => e.new_contract_plan_productBase)
                .WithOptional(e => e.new_d_product_groupsBase)
                .HasForeignKey(e => e.new_link_product_group_id);

            modelBuilder.Entity<new_d_product_groupsBase>()
                .HasMany(e => e.new_contract_plan_quarterBase)
                .WithOptional(e => e.new_d_product_groupsBase)
                .HasForeignKey(e => e.new_link_product_group_id);

            modelBuilder.Entity<new_d_product_groupsBase>()
                .HasMany(e => e.new_contract_planBase)
                .WithOptional(e => e.new_d_product_groupsBase)
                .HasForeignKey(e => e.new_link_product_group_id);

            modelBuilder.Entity<new_d_product_groupsBase>()
                .HasMany(e => e.new_d_product_catalogBase)
                .WithOptional(e => e.new_d_product_groupsBase)
                .HasForeignKey(e => e.new_link_product_group_id);

            modelBuilder.Entity<new_d_product_groupsBase>()
                .HasMany(e => e.new_d_sphere_of_activityBase)
                .WithOptional(e => e.new_d_product_groupsBase)
                .HasForeignKey(e => e.new_search_product_group);

            modelBuilder.Entity<new_d_product_groupsBase>()
                .HasMany(e => e.new_expense_contractBase)
                .WithOptional(e => e.new_d_product_groupsBase)
                .HasForeignKey(e => e.new_link_product_group_id);

            modelBuilder.Entity<new_d_product_groupsBase>()
                .HasMany(e => e.new_expertiseBase)
                .WithOptional(e => e.new_d_product_groupsBase)
                .HasForeignKey(e => e.new_link_product_group_Id);

            modelBuilder.Entity<new_d_product_groupsBase>()
                .HasMany(e => e.new_profit_contractBase)
                .WithOptional(e => e.new_d_product_groupsBase)
                .HasForeignKey(e => e.new_link_product_group_Id);

            modelBuilder.Entity<new_d_product_groupsBase>()
                .HasMany(e => e.new_project_initiativeBase)
                .WithOptional(e => e.new_d_product_groupsBase)
                .HasForeignKey(e => e.new_link_product_group_id);

            modelBuilder.Entity<new_d_product_groupsBase>()
                .HasMany(e => e.new_t_contract_productBase)
                .WithOptional(e => e.new_d_product_groupsBase)
                .HasForeignKey(e => e.new_link_product_group_Id);

            modelBuilder.Entity<new_d_product_typesBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_d_product_typesBase>()
                .HasMany(e => e.new_project_initiativeBase)
                .WithOptional(e => e.new_d_product_typesBase)
                .HasForeignKey(e => e.new_link_project_type);

            modelBuilder.Entity<new_d_product_typesBase>()
                .HasMany(e => e.new_t_projectBase)
                .WithOptional(e => e.new_d_product_typesBase)
                .HasForeignKey(e => e.new_project_type);

            modelBuilder.Entity<new_d_product_typesBase>()
                .HasMany(e => e.new_project_initiative_valuationBase)
                .WithOptional(e => e.new_d_product_typesBase)
                .HasForeignKey(e => e.new_project_type_id);

            modelBuilder.Entity<new_d_service_typesBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_d_service_typesBase>()
                .HasMany(e => e.new_t_contract_productBase)
                .WithOptional(e => e.new_d_service_typesBase)
                .HasForeignKey(e => e.new_link_service_type_id);

            modelBuilder.Entity<new_d_service_typesBase>()
                .HasMany(e => e.new_t_project_taskBase)
                .WithOptional(e => e.new_d_service_typesBase)
                .HasForeignKey(e => e.new_service_type);

            modelBuilder.Entity<new_d_service_typesBase>()
                .HasMany(e => e.new_new_d_service_types_new_t_project_task2Base)
                .WithRequired(e => e.new_d_service_typesBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<new_d_sphere_of_activityBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_d_sphere_of_activityBase>()
                .HasMany(e => e.new_businessunit_roleBase)
                .WithOptional(e => e.new_d_sphere_of_activityBase)
                .HasForeignKey(e => e.new_sphere_of_activity_Id);

            modelBuilder.Entity<new_d_sphere_of_activityBase>()
                .HasMany(e => e.new_d_product_catalogBase)
                .WithOptional(e => e.new_d_sphere_of_activityBase)
                .HasForeignKey(e => e.new_link_sphere_of_activity_Id);

            modelBuilder.Entity<new_d_sphere_of_activityBase>()
                .HasMany(e => e.new_document_form_baseBase)
                .WithOptional(e => e.new_d_sphere_of_activityBase)
                .HasForeignKey(e => e.new_link_sphere_of_activity_Id);

            modelBuilder.Entity<new_d_sphere_of_activityBase>()
                .HasMany(e => e.new_expense_contractBase)
                .WithOptional(e => e.new_d_sphere_of_activityBase)
                .HasForeignKey(e => e.new_link_sphere_of_activity_id);

            modelBuilder.Entity<new_d_sphere_of_activityBase>()
                .HasMany(e => e.new_expertiseBase)
                .WithOptional(e => e.new_d_sphere_of_activityBase)
                .HasForeignKey(e => e.new_link_sphere_of_activity_Id);

            modelBuilder.Entity<new_d_sphere_of_activityBase>()
                .HasMany(e => e.new_product_of_projectBase)
                .WithOptional(e => e.new_d_sphere_of_activityBase)
                .HasForeignKey(e => e.new_link_sphere_of_activity_Id);

            modelBuilder.Entity<new_d_sphere_of_activityBase>()
                .HasMany(e => e.new_profit_contractBase)
                .WithOptional(e => e.new_d_sphere_of_activityBase)
                .HasForeignKey(e => e.new_link_sphere_of_activity_Id);

            modelBuilder.Entity<new_d_sphere_of_activityBase>()
                .HasMany(e => e.new_project_initiativeBase)
                .WithOptional(e => e.new_d_sphere_of_activityBase)
                .HasForeignKey(e => e.new_new_d_sphere_of_activity_id);

            modelBuilder.Entity<new_d_sphere_of_activityBase>()
                .HasMany(e => e.new_successful_project_historyBase)
                .WithOptional(e => e.new_d_sphere_of_activityBase)
                .HasForeignKey(e => e.new_link_sphere_of_activity_id);

            modelBuilder.Entity<new_d_sphere_of_activityBase>()
                .HasMany(e => e.new_t_activityBase)
                .WithOptional(e => e.new_d_sphere_of_activityBase)
                .HasForeignKey(e => e.new_new_d_sphere_of_activityId);

            modelBuilder.Entity<new_d_sphere_of_activityBase>()
                .HasMany(e => e.new_t_contract_productBase)
                .WithOptional(e => e.new_d_sphere_of_activityBase)
                .HasForeignKey(e => e.new_link_sphere_of_activity_Id);

            modelBuilder.Entity<new_d_sphere_of_activityBase>()
                .HasMany(e => e.new_t_projectBase)
                .WithOptional(e => e.new_d_sphere_of_activityBase)
                .HasForeignKey(e => e.new_link_sphere_of_activity_Id);

            modelBuilder.Entity<new_deal_typeBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_deal_typeBase>()
                .HasMany(e => e.new_project_initiative_valuationBase)
                .WithOptional(e => e.new_deal_typeBase)
                .HasForeignKey(e => e.new_link_deal_type_id);

            modelBuilder.Entity<new_decision_making_levelBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_decision_making_levelBase>()
                .HasMany(e => e.new_project_initiative_valuationBase)
                .WithOptional(e => e.new_decision_making_levelBase)
                .HasForeignKey(e => e.new_link_decision_making_level_id);

            modelBuilder.Entity<new_document_form_baseBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_expense_contractBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_expense_contractBase>()
                .Property(e => e.new_expense_contract_sum)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_expense_contractBase>()
                .HasMany(e => e.new_contract_string_historyBase)
                .WithOptional(e => e.new_expense_contractBase)
                .HasForeignKey(e => e.new_linkexpense_contract_contract_s_h);

            modelBuilder.Entity<new_expense_contractBase>()
                .HasMany(e => e.new_contract_stringBase)
                .WithOptional(e => e.new_expense_contractBase)
                .HasForeignKey(e => e.new_linkexpense_contract_contract_str);

            modelBuilder.Entity<new_expense_contractBase>()
                .HasMany(e => e.new_plan_factBase)
                .WithOptional(e => e.new_expense_contractBase)
                .HasForeignKey(e => e.new_link_expense_contract_Id);

            modelBuilder.Entity<new_expense_contractBase>()
                .HasMany(e => e.new_t_ActBase)
                .WithOptional(e => e.new_expense_contractBase)
                .HasForeignKey(e => e.new_link_expense_contract_act);

            modelBuilder.Entity<new_expense_contractBase>()
                .HasMany(e => e.new_t_contract_productBase)
                .WithOptional(e => e.new_expense_contractBase)
                .HasForeignKey(e => e.new_expense_contract_contract_product);

            modelBuilder.Entity<new_expense_contractBase>()
                .HasMany(e => e.new_t_contractorBase)
                .WithOptional(e => e.new_expense_contractBase)
                .HasForeignKey(e => e.new_link_expense_contract_contractor);

            modelBuilder.Entity<new_expense_contractBase>()
                .HasMany(e => e.new_new_profit_contract_new_expense_contracBase)
                .WithRequired(e => e.new_expense_contractBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<new_expertiseBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_expertiseBase>()
                .Property(e => e.new_act_sum)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_expertiseBase>()
                .HasMany(e => e.new_licenseBase)
                .WithOptional(e => e.new_expertiseBase)
                .HasForeignKey(e => e.new_expertiseId);

            modelBuilder.Entity<new_expertiseBase>()
                .HasMany(e => e.new_profit_contractBase)
                .WithOptional(e => e.new_expertiseBase)
                .HasForeignKey(e => e.new_expertiseId);

            modelBuilder.Entity<new_expertiseBase>()
                .HasMany(e => e.new_t_ActBase)
                .WithOptional(e => e.new_expertiseBase)
                .HasForeignKey(e => e.new_expertiseId);

            modelBuilder.Entity<new_expertiseBase>()
                .HasMany(e => e.new_new_package_of_documents_new_expertiseBase)
                .WithRequired(e => e.new_expertiseBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<new_initiative_probabilityBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_initiative_probabilityBase>()
                .HasMany(e => e.new_project_initiativeBase)
                .WithOptional(e => e.new_initiative_probabilityBase)
                .HasForeignKey(e => e.new_link_initiative_probability_id);

            modelBuilder.Entity<new_lead_and_possible_contractBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_lead_and_possible_contractBase>()
                .Property(e => e.new_contract_sum)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_licenseBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_licenseBase>()
                .HasMany(e => e.new_expertiseBase1)
                .WithOptional(e => e.new_licenseBase1)
                .HasForeignKey(e => e.new_license_Id);

            modelBuilder.Entity<new_new_account_need_new_t_account_needBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_new_d_product_catalog_new_t_projectBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_new_d_service_types_new_t_project_task2Base>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_new_package_of_documents_new_expertiseBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_new_profit_contract_new_expense_contracBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_new_project_initiative_valuation_systemBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_new_t_contractor_new_t_project_taskBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_new_t_project_new_t_projectBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_new_t_project_task_new_t_project_taskBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_okiBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_Package_of_documentsBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_Package_of_documentsBase>()
                .HasMany(e => e.new_new_package_of_documents_new_expertiseBase)
                .WithRequired(e => e.new_Package_of_documentsBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<new_parameter_project_initiative_evaluationBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_parameter_project_initiative_evaluationBase>()
                .HasMany(e => e.new_project_initiative_valuationBase)
                .WithOptional(e => e.new_parameter_project_initiative_evaluationBase)
                .HasForeignKey(e => e.new_parameter_project_initiativeId);

            modelBuilder.Entity<new_parameter_project_initiative_evaluationBase>()
                .HasMany(e => e.new_project_calculation_parametrBase)
                .WithOptional(e => e.new_parameter_project_initiative_evaluationBase)
                .HasForeignKey(e => e.new_parameter_PI_evaluationId);

            modelBuilder.Entity<new_plan_factBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_plan_factBase>()
                .Property(e => e.new_plan)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_plan_factBase>()
                .Property(e => e.new_fact)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_potential_accountBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_product_of_projectBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_profit_contractBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_profit_contractBase>()
                .Property(e => e.new_discount_sum_wo_VAT_fact)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_profit_contractBase>()
                .Property(e => e.new_profit_contract_sum)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_profit_contractBase>()
                .HasMany(e => e.new_contract_string_historyBase)
                .WithOptional(e => e.new_profit_contractBase)
                .HasForeignKey(e => e.new_link_profit_contract_contract_s_h);

            modelBuilder.Entity<new_profit_contractBase>()
                .HasMany(e => e.new_contract_stringBase)
                .WithOptional(e => e.new_profit_contractBase)
                .HasForeignKey(e => e.new_link_profit_contract_contract_str);

            modelBuilder.Entity<new_profit_contractBase>()
                .HasMany(e => e.new_expertiseBase1)
                .WithOptional(e => e.new_profit_contractBase1)
                .HasForeignKey(e => e.new_profit_contract_Id);

            modelBuilder.Entity<new_profit_contractBase>()
                .HasMany(e => e.new_new_profit_contract_new_expense_contracBase)
                .WithRequired(e => e.new_profit_contractBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<new_profit_contractBase>()
                .HasMany(e => e.new_plan_factBase)
                .WithOptional(e => e.new_profit_contractBase)
                .HasForeignKey(e => e.new_link_profit_contract_Id);

            modelBuilder.Entity<new_profit_contractBase>()
                .HasMany(e => e.new_t_ActBase)
                .WithOptional(e => e.new_profit_contractBase)
                .HasForeignKey(e => e.new_profit_contract_Id);

            modelBuilder.Entity<new_profit_contractBase>()
                .HasMany(e => e.new_t_contract_productBase)
                .WithOptional(e => e.new_profit_contractBase)
                .HasForeignKey(e => e.new_profit_contract_contract_product);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_amortization)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_DS_income_of_operating_activity)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_DS_outcome_of_operating_activity)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_result_of_operating_activity)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_DS_outcome_investment_activity)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_CF)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_accumulative_CF)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_nominal_income_RSBU)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_discounting_effect_installment_12_months)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_Transformational_adjustment)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_income_of_non_initializing_CFO)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_outcome_on_contracting_organization)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_outcome_on_contracting_organization_DZO)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_PL_diroutcome_transformational_adjustment)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_PL_direct_outcome_outcome_1)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_PL_direct_outcome_outcome_2)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_other_direct_outcome)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_Contribution_to_RUO)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_PL_other_direct_outcome_outcome_1)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_PL_other_direct_outcome_outcome_2)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_Other_directoutcome_CFO_realisationmember)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_Other_direct_outcome_with_TK)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_PL_direct_outcome_initiating_CFO)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_PL_direct_outcome_sum)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_PL_income_MSFO)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_Gross_Margin)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_CAPEX_OKB_RSBU_external)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_CAPEX_OKB_RSBU_DZO)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_CAPEX_OKB_Transformational_adjustment)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_CAPEX_OKB)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_GM_outcome_on_stuff_KB)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_GM_GPH_COMM)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_GM_advertising_and_marketing)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_GM_other)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_Contribution_Margin)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_CM_outcome_on_AUP)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_CM_GPH_other)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_CM_Taxes_and_fees)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_CM_materials)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_CM_other)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_Gross_Margin_CFO_percent)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_EBIT_percent_for_issuing_bank_guarantee)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_percent_on_credit)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_EBIT_finance_income)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_Gross_Margin_percent)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_Contribution_Margin_percent)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_OIBDA)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_OIBDA_Margin_percent)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_EBIT)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_EBIT_Margin_percent)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_EBT)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_calculation_parametrBase>()
                .Property(e => e.new_EBT_Margin_percent)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_Project_deviation_corrective_measureBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_project_initiative_valuationBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_project_initiative_valuationBase>()
                .HasMany(e => e.new_new_project_initiative_valuation_systemBase)
                .WithRequired(e => e.new_project_initiative_valuationBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<new_project_initiative_valuationBase>()
                .HasMany(e => e.new_parameter_project_initiative_evaluationBase1)
                .WithOptional(e => e.new_project_initiative_valuationBase1)
                .HasForeignKey(e => e.new_project_initiative_valuationId);

            modelBuilder.Entity<new_project_initiative_valuationBase>()
                .HasMany(e => e.new_project_calculation_parametrBase)
                .WithOptional(e => e.new_project_initiative_valuationBase)
                .HasForeignKey(e => e.new_project_initiative_valuation_id);

            modelBuilder.Entity<new_project_initiative_valuationBase>()
                .HasMany(e => e.new_t_project_riskBase)
                .WithOptional(e => e.new_project_initiative_valuationBase)
                .HasForeignKey(e => e.new_link_project_initiative_valuat_id);

            modelBuilder.Entity<new_project_initiative_valuationBase>()
                .HasMany(e => e.new_project_initiativeBase1)
                .WithOptional(e => e.new_project_initiative_valuationBase1)
                .HasForeignKey(e => e.new_link_project_initiative_valuation);

            modelBuilder.Entity<new_project_initiativeBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_project_initiativeBase>()
                .Property(e => e.new_possible_amount_of_investments)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_initiativeBase>()
                .Property(e => e.new_possible_marginality)
                .HasPrecision(18, 0);

            modelBuilder.Entity<new_project_initiativeBase>()
                .Property(e => e.new_possible_revenue_msfo)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_initiativeBase>()
                .Property(e => e.new_possible_revenue_rsbu)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_initiativeBase>()
                .Property(e => e.new_sum_to_close_overall_rsbu)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_initiativeBase>()
                .Property(e => e.new_sum_VAT_to_close_overall_msfo)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_initiativeBase>()
                .Property(e => e.new_forecast_margin)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_initiativeBase>()
                .Property(e => e.new_forecast_margin_RSBU)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_initiativeBase>()
                .Property(e => e.new_forecast_margin_MSFO)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_initiativeBase>()
                .HasMany(e => e.new_potential_accountBase)
                .WithOptional(e => e.new_project_initiativeBase)
                .HasForeignKey(e => e.new_link_potential_account_Id);

            modelBuilder.Entity<new_project_initiativeBase>()
                .HasMany(e => e.new_project_initiative_valuationBase)
                .WithOptional(e => e.new_project_initiativeBase)
                .HasForeignKey(e => e.new_link_project_initiative_id);

            modelBuilder.Entity<new_project_initiativeBase>()
                .HasMany(e => e.new_revenue_by_yearBase)
                .WithOptional(e => e.new_project_initiativeBase)
                .HasForeignKey(e => e.new_link_revenue_by_year_Id);

            modelBuilder.Entity<new_project_initiativeBase>()
                .HasMany(e => e.new_t_activityBase)
                .WithOptional(e => e.new_project_initiativeBase)
                .HasForeignKey(e => e.new_link_project_initiative_id);

            modelBuilder.Entity<new_project_initiativeBase>()
                .HasMany(e => e.new_t_projectBase)
                .WithOptional(e => e.new_project_initiativeBase)
                .HasForeignKey(e => e.new_project_initiative_project);

            modelBuilder.Entity<new_project_initiativeBase>()
                .HasMany(e => e.new_t_project_riskBase)
                .WithOptional(e => e.new_project_initiativeBase)
                .HasForeignKey(e => e.new_link_project_initiative_Id);

            modelBuilder.Entity<new_project_project_reporting_indexBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_project_project_reporting_indexBase>()
                .Property(e => e.new_fact_value)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_project_reporting_indexBase>()
                .Property(e => e.new_plan_value)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_project_reporting_indexBase>()
                .HasMany(e => e.new_project_reporting_index_plan_factBase)
                .WithOptional(e => e.new_project_project_reporting_indexBase)
                .HasForeignKey(e => e.new_project_reporting_index_id);

            modelBuilder.Entity<new_project_reporting_index_plan_factBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_project_reporting_index_plan_factBase>()
                .Property(e => e.new_plan_value)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_reporting_index_plan_factBase>()
                .Property(e => e.new_fact_value)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_reporting_indexBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_project_reporting_indexBase>()
                .HasMany(e => e.new_project_project_reporting_indexBase)
                .WithOptional(e => e.new_project_reporting_indexBase)
                .HasForeignKey(e => e.new_link_project_reporting_index_id);

            modelBuilder.Entity<new_project_reporting_indexBase>()
                .HasMany(e => e.new_project_reportingBase)
                .WithOptional(e => e.new_project_reporting_indexBase)
                .HasForeignKey(e => e.new_link_project_reporting_index_id);

            modelBuilder.Entity<new_project_reportingBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_project_reportingBase>()
                .Property(e => e.new_plan_value)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_reportingBase>()
                .Property(e => e.new_fact_value)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_project_reportingBase>()
                .HasMany(e => e.new_Project_deviation_corrective_measureBase)
                .WithOptional(e => e.new_project_reportingBase)
                .HasForeignKey(e => e.new_link_new_project_reporting_id);

            modelBuilder.Entity<new_purchaseBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_purchaseBase>()
                .Property(e => e.new_max_contract_price)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_purchaseBase>()
                .HasMany(e => e.new_project_initiativeBase)
                .WithOptional(e => e.new_purchaseBase)
                .HasForeignKey(e => e.new_purchase_Id);

            modelBuilder.Entity<new_RatingBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_RatingBase>()
                .HasMany(e => e.new_parameter_project_initiative_evaluationBase)
                .WithOptional(e => e.new_RatingBase)
                .HasForeignKey(e => e.new_BDZPTZRate_RatingId);

            modelBuilder.Entity<new_RatingBase>()
                .HasMany(e => e.new_parameter_project_initiative_evaluationBase1)
                .WithOptional(e => e.new_RatingBase1)
                .HasForeignKey(e => e.new_CostRate_RatingId);

            modelBuilder.Entity<new_RatingBase>()
                .HasMany(e => e.new_parameter_project_initiative_evaluationBase2)
                .WithOptional(e => e.new_RatingBase2)
                .HasForeignKey(e => e.new_CustomerRate_RatingId);

            modelBuilder.Entity<new_RatingBase>()
                .HasMany(e => e.new_parameter_project_initiative_evaluationBase3)
                .WithOptional(e => e.new_RatingBase3)
                .HasForeignKey(e => e.new_RegRate_RatungId);

            modelBuilder.Entity<new_RatingBase>()
                .HasMany(e => e.new_parameter_project_initiative_evaluationBase4)
                .WithOptional(e => e.new_RatingBase4)
                .HasForeignKey(e => e.new_RiskRate_RatingId);

            modelBuilder.Entity<new_revenue_by_yearBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_revenue_by_yearBase>()
                .Property(e => e.new_possible_revenue_rsbu)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_revenue_by_yearBase>()
                .Property(e => e.new_possible_revenue_msfo)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_revenue_by_yearBase>()
                .Property(e => e.new_sum_VAT_to_close_in_particular_rsbu)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_revenue_by_yearBase>()
                .Property(e => e.new_sum_VAT_to_close_in_particular_msfo)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_RouteBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_settingBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_StageBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_StageBase>()
                .HasMany(e => e.new_TransferBase)
                .WithOptional(e => e.new_StageBase)
                .HasForeignKey(e => e.new_From_StageId);

            modelBuilder.Entity<new_StageBase>()
                .HasMany(e => e.new_TransferBase1)
                .WithOptional(e => e.new_StageBase1)
                .HasForeignKey(e => e.new_To_StageId);

            modelBuilder.Entity<new_StepBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_StepBase>()
                .HasMany(e => e.new_RouteBase)
                .WithOptional(e => e.new_StepBase)
                .HasForeignKey(e => e.new_FirstStep_StepId);

            modelBuilder.Entity<new_StepBase>()
                .HasMany(e => e.new_TransferBase)
                .WithOptional(e => e.new_StepBase)
                .HasForeignKey(e => e.new_From_StepId);

            modelBuilder.Entity<new_StepBase>()
                .HasMany(e => e.new_TransferBase1)
                .WithOptional(e => e.new_StepBase1)
                .HasForeignKey(e => e.new_To_StepId);

            modelBuilder.Entity<new_successful_project_history_productBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_successful_project_historyBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_successful_project_historyBase>()
                .HasMany(e => e.new_successful_project_history_productBase)
                .WithOptional(e => e.new_successful_project_historyBase)
                .HasForeignKey(e => e.new_link_successful_prject_history_id);

            modelBuilder.Entity<new_t_account_needBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_t_account_needBase>()
                .HasMany(e => e.new_new_account_need_new_t_account_needBase)
                .WithRequired(e => e.new_t_account_needBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<new_t_ActBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_t_ActBase>()
                .Property(e => e.new_sum)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_t_ActBase>()
                .HasMany(e => e.new_expertiseBase1)
                .WithOptional(e => e.new_t_ActBase1)
                .HasForeignKey(e => e.new_act_id);

            modelBuilder.Entity<new_t_activityBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_t_activityBase>()
                .Property(e => e.new_possible_amount_of_investments)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_t_activityBase>()
                .Property(e => e.new_possible_revenue_rsbu)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_t_activityBase>()
                .Property(e => e.new_possible_revenue_msfo)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_t_activityBase>()
                .HasMany(e => e.ContactBase)
                .WithOptional(e => e.new_t_activityBase)
                .HasForeignKey(e => e.new_link_contact_Id);

            modelBuilder.Entity<new_t_activityBase>()
                .HasMany(e => e.new_commercial_offerBase)
                .WithOptional(e => e.new_t_activityBase)
                .HasForeignKey(e => e.new_link_activity_id);

            modelBuilder.Entity<new_t_activityBase>()
                .HasMany(e => e.new_project_initiativeBase1)
                .WithOptional(e => e.new_t_activityBase1)
                .HasForeignKey(e => e.new_link_t_activity_t_project_initiat);

            modelBuilder.Entity<new_t_activityBase>()
                .HasMany(e => e.new_purchaseBase)
                .WithOptional(e => e.new_t_activityBase)
                .HasForeignKey(e => e.new_link_activity_id);

            modelBuilder.Entity<new_t_activityBase>()
                .HasMany(e => e.new_t_account_needBase)
                .WithOptional(e => e.new_t_activityBase)
                .HasForeignKey(e => e.new_link_activity_id);

            modelBuilder.Entity<new_t_activityBase>()
                .HasMany(e => e.new_t_project_riskBase)
                .WithOptional(e => e.new_t_activityBase)
                .HasForeignKey(e => e.new_activity_Id);

            modelBuilder.Entity<new_t_activityBase>()
                .HasMany(e => e.TaskBase)
                .WithOptional(e => e.new_t_activityBase)
                .HasForeignKey(e => e.new_link_t_activity_t_task);

            modelBuilder.Entity<new_t_contract_productBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_t_contract_productBase>()
                .Property(e => e.new_sum)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_t_contractorBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_t_contractorBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_t_contractorBase>()
                .Property(e => e.new_sum)
                .HasPrecision(19, 4);

            modelBuilder.Entity<new_t_contractorBase>()
                .Property(e => e.new_sum_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<new_t_contractorBase>()
                .Property(e => e.new_contract_sum)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_t_contractorBase>()
                .HasMany(e => e.new_new_t_contractor_new_t_project_taskBase)
                .WithRequired(e => e.new_t_contractorBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<new_t_contractorBase>()
                .HasMany(e => e.new_t_contractorBase1)
                .WithOptional(e => e.new_t_contractorBase2)
                .HasForeignKey(e => e.new_child_contractor);

            modelBuilder.Entity<new_t_project_riskBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_t_project_riskBase>()
                .Property(e => e.new_cost_object_of_influence)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_t_project_riskBase>()
                .Property(e => e.new_expected_cost_of_loss)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_t_project_taskBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_t_project_taskBase>()
                .Property(e => e.new_cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<new_t_project_taskBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_t_project_taskBase>()
                .Property(e => e.new_cost_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<new_t_project_taskBase>()
                .Property(e => e.new_complete_percent)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_t_project_taskBase>()
                .HasMany(e => e.new_new_d_service_types_new_t_project_task2Base)
                .WithRequired(e => e.new_t_project_taskBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<new_t_project_taskBase>()
                .HasMany(e => e.new_new_t_contractor_new_t_project_taskBase)
                .WithRequired(e => e.new_t_project_taskBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<new_t_project_taskBase>()
                .HasMany(e => e.new_new_t_project_task_new_t_project_taskBase)
                .WithRequired(e => e.new_t_project_taskBase)
                .HasForeignKey(e => e.new_t_project_taskidOne)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<new_t_project_taskBase>()
                .HasMany(e => e.new_new_t_project_task_new_t_project_taskBase1)
                .WithRequired(e => e.new_t_project_taskBase1)
                .HasForeignKey(e => e.new_t_project_taskidTwo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<new_t_project_taskBase>()
                .HasMany(e => e.new_t_contractorBase)
                .WithOptional(e => e.new_t_project_taskBase)
                .HasForeignKey(e => e.new_link_project_stage_id);

            modelBuilder.Entity<new_t_project_taskBase>()
                .HasMany(e => e.new_t_projectBase3)
                .WithOptional(e => e.new_t_project_taskBase3)
                .HasForeignKey(e => e.new_link_milestone_Id);

            modelBuilder.Entity<new_t_project_taskBase>()
                .HasMany(e => e.new_t_project_taskBase1)
                .WithOptional(e => e.new_t_project_taskBase2)
                .HasForeignKey(e => e.new_parent_task);

            modelBuilder.Entity<new_t_projectBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_t_projectBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_t_projectBase>()
                .Property(e => e.new_profitable_budget)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_t_projectBase>()
                .Property(e => e.new_expendable_budget_OPEX)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_t_projectBase>()
                .Property(e => e.new_expendable_budget_CAPEX)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_t_projectBase>()
                .Property(e => e.new_IRR)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_t_projectBase>()
                .Property(e => e.new_NPV)
                .HasPrecision(23, 10);

            modelBuilder.Entity<new_t_projectBase>()
                .HasMany(e => e.new_new_d_product_catalog_new_t_projectBase)
                .WithRequired(e => e.new_t_projectBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<new_t_projectBase>()
                .HasMany(e => e.new_new_t_project_new_t_projectBase)
                .WithRequired(e => e.new_t_projectBase)
                .HasForeignKey(e => e.new_t_projectidOne)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<new_t_projectBase>()
                .HasMany(e => e.new_new_t_project_new_t_projectBase1)
                .WithRequired(e => e.new_t_projectBase1)
                .HasForeignKey(e => e.new_t_projectidTwo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<new_t_projectBase>()
                .HasMany(e => e.new_product_of_projectBase)
                .WithOptional(e => e.new_t_projectBase)
                .HasForeignKey(e => e.new_link_project_Id);

            modelBuilder.Entity<new_t_projectBase>()
                .HasMany(e => e.new_profit_contractBase)
                .WithOptional(e => e.new_t_projectBase)
                .HasForeignKey(e => e.new_link_project_profit_contract);

            modelBuilder.Entity<new_t_projectBase>()
                .HasMany(e => e.new_project_calculation_parametrBase)
                .WithOptional(e => e.new_t_projectBase)
                .HasForeignKey(e => e.new_link_project_id);

            modelBuilder.Entity<new_t_projectBase>()
                .HasMany(e => e.new_project_project_reporting_indexBase)
                .WithOptional(e => e.new_t_projectBase)
                .HasForeignKey(e => e.new_link_project_id);

            modelBuilder.Entity<new_t_projectBase>()
                .HasMany(e => e.new_project_reporting_indexBase)
                .WithOptional(e => e.new_t_projectBase)
                .HasForeignKey(e => e.new_link_project_id);

            modelBuilder.Entity<new_t_projectBase>()
                .HasMany(e => e.new_project_reportingBase)
                .WithOptional(e => e.new_t_projectBase)
                .HasForeignKey(e => e.new_link_project_Id);

            modelBuilder.Entity<new_t_projectBase>()
                .HasMany(e => e.new_successful_project_historyBase)
                .WithOptional(e => e.new_t_projectBase)
                .HasForeignKey(e => e.new_link_project_id);

            modelBuilder.Entity<new_t_projectBase>()
                .HasMany(e => e.new_t_contractorBase)
                .WithOptional(e => e.new_t_projectBase)
                .HasForeignKey(e => e.new_link_t_project_t_contractor);

            modelBuilder.Entity<new_t_projectBase>()
                .HasMany(e => e.new_t_project_riskBase)
                .WithOptional(e => e.new_t_projectBase)
                .HasForeignKey(e => e.new_link_project_risk);

            modelBuilder.Entity<new_t_projectBase>()
                .HasMany(e => e.new_t_project_taskBase)
                .WithOptional(e => e.new_t_projectBase)
                .HasForeignKey(e => e.new_project_task_link);

            modelBuilder.Entity<new_t_projectBase>()
                .HasMany(e => e.new_t_project_taskBase1)
                .WithOptional(e => e.new_t_projectBase1)
                .HasForeignKey(e => e.new_link_t_project_t_task_stages);

            modelBuilder.Entity<new_t_projectBase>()
                .HasMany(e => e.new_t_project_taskBase2)
                .WithOptional(e => e.new_t_projectBase2)
                .HasForeignKey(e => e.new_veha);

            modelBuilder.Entity<new_territoryBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<new_territoryBase>()
                .HasMany(e => e.new_contract_planBase)
                .WithOptional(e => e.new_territoryBase)
                .HasForeignKey(e => e.new_link_territory_id);

            modelBuilder.Entity<new_territoryBase>()
                .HasMany(e => e.new_expense_contractBase)
                .WithOptional(e => e.new_territoryBase)
                .HasForeignKey(e => e.new_link_territory_Id);

            modelBuilder.Entity<new_territoryBase>()
                .HasMany(e => e.new_expertiseBase)
                .WithOptional(e => e.new_territoryBase)
                .HasForeignKey(e => e.new_link_territory_Id);

            modelBuilder.Entity<new_territoryBase>()
                .HasMany(e => e.new_profit_contractBase)
                .WithOptional(e => e.new_territoryBase)
                .HasForeignKey(e => e.new_link_territory_Id);

            modelBuilder.Entity<new_territoryBase>()
                .HasMany(e => e.new_project_initiativeBase)
                .WithOptional(e => e.new_territoryBase)
                .HasForeignKey(e => e.new_link_territory_id);

            modelBuilder.Entity<new_territoryBase>()
                .HasMany(e => e.new_successful_project_historyBase)
                .WithOptional(e => e.new_territoryBase)
                .HasForeignKey(e => e.new_link_territory_id);

            modelBuilder.Entity<new_territoryBase>()
                .HasMany(e => e.new_t_activityBase)
                .WithOptional(e => e.new_territoryBase)
                .HasForeignKey(e => e.new_link_territory_id);

            modelBuilder.Entity<new_territoryBase>()
                .HasMany(e => e.new_t_projectBase)
                .WithOptional(e => e.new_territoryBase)
                .HasForeignKey(e => e.new_link_territory_project);

            modelBuilder.Entity<new_TransferBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<NewProcessBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<NewProcessBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<OfficeDocumentBase>()
                .Property(e => e.ClientData)
                .IsUnicode(false);

            modelBuilder.Entity<OfficeDocumentBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<OfficeDocumentBase>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<OfficeGraphDocumentBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<OfficeGraphDocumentBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<OpportunityBase>()
                .Property(e => e.EstimatedValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityBase>()
                .Property(e => e.ActualValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<OpportunityBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<OpportunityBase>()
                .Property(e => e.ActualValue_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityBase>()
                .Property(e => e.EstimatedValue_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityBase>()
                .Property(e => e.TotalDiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityBase>()
                .Property(e => e.TotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityBase>()
                .Property(e => e.TotalAmountLessFreight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityBase>()
                .Property(e => e.TotalLineItemDiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityBase>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityBase>()
                .Property(e => e.FreightAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityBase>()
                .Property(e => e.TotalTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityBase>()
                .Property(e => e.DiscountPercentage)
                .HasPrecision(23, 10);

            modelBuilder.Entity<OpportunityBase>()
                .Property(e => e.TotalLineItemAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityBase>()
                .Property(e => e.TotalDiscountAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityBase>()
                .Property(e => e.FreightAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityBase>()
                .Property(e => e.TotalLineItemAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityBase>()
                .Property(e => e.TotalTax_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityBase>()
                .Property(e => e.TotalLineItemDiscountAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityBase>()
                .Property(e => e.TotalAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityBase>()
                .Property(e => e.DiscountAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityBase>()
                .Property(e => e.TotalAmountLessFreight_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityBase>()
                .Property(e => e.BudgetAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityBase>()
                .Property(e => e.BudgetAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityBase>()
                .HasMany(e => e.CustomerOpportunityRoleBase)
                .WithRequired(e => e.OpportunityBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OpportunityBase>()
                .HasMany(e => e.LeadBase)
                .WithOptional(e => e.OpportunityBase)
                .HasForeignKey(e => e.QualifyingOpportunityId);

            modelBuilder.Entity<OpportunityBase>()
                .HasMany(e => e.OpportunityCompetitors)
                .WithRequired(e => e.OpportunityBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OpportunityBase>()
                .HasMany(e => e.OpportunityProductBase)
                .WithRequired(e => e.OpportunityBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OpportunityCompetitors>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<OpportunityProductBase>()
                .Property(e => e.PricePerUnit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityProductBase>()
                .Property(e => e.BaseAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityProductBase>()
                .Property(e => e.ExtendedAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityProductBase>()
                .Property(e => e.ManualDiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityProductBase>()
                .Property(e => e.Quantity)
                .HasPrecision(23, 10);

            modelBuilder.Entity<OpportunityProductBase>()
                .Property(e => e.VolumeDiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityProductBase>()
                .Property(e => e.Tax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityProductBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<OpportunityProductBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<OpportunityProductBase>()
                .Property(e => e.BaseAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityProductBase>()
                .Property(e => e.ManualDiscountAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityProductBase>()
                .Property(e => e.VolumeDiscountAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityProductBase>()
                .Property(e => e.PricePerUnit_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityProductBase>()
                .Property(e => e.Tax_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityProductBase>()
                .Property(e => e.ExtendedAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpportunityProductBase>()
                .HasMany(e => e.OpportunityProductBase1)
                .WithOptional(e => e.OpportunityProductBase2)
                .HasForeignKey(e => e.ParentBundleId);

            modelBuilder.Entity<OpportunitySalesProcessBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<OpportunitySalesProcessBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<OrganizationBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<OwnerBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.AccountBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.ActionCardBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.ActionCardUserSettingsBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.ActivityPointerBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.AnnotationBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.bng_SchedulerSessionBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.bng_ShedulerTaskBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.BookableResourceBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.BookableResourceBookingBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.BookableResourceBookingExchangeSyncIdMappingBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.BookableResourceBookingHeaderBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.BookableResourceCategoryAssnBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.BookableResourceCategoryBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.BookableResourceCharacteristicBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.BookableResourceGroupBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.BookingStatusBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.CampaignBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.CategoryBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.CharacteristicBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.ConnectionBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.ContactBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.ContractBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.CustomerOpportunityRoleBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.CustomerRelationshipBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.DynamicPropertyInstanceBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.EmailServerProfileBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.EntitlementBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.ExchangeSyncIdMappingBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.ExternalPartyBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.FeedbackBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.GoalBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.GoalRollupQueryBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.ImportBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.ImportDataBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.ImportFileBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.ImportLogBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.ImportMapBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.IncidentBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.InteractionForEmailBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.InvoiceBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.KnowledgeArticleBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.LeadBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.ListBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.MailboxBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.MailboxTrackingFolderBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.msdyn_PostAlbumBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.msdyn_wallsavedqueryusersettingsBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_commercial_offerBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_contract_plan_acceptionBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_contract_plan_adjustment_ccBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_contract_plan_productBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_contract_plan_quarterBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_contract_planBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_contract_string_historyBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_contract_stringBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_expense_contractBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_expertiseBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_lead_and_possible_contractBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_licenseBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_Package_of_documentsBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_parameter_project_initiative_evaluationBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_plan_factBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_potential_accountBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_product_of_projectBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_profit_contractBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_project_calculation_parametrBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_Project_deviation_corrective_measureBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_project_initiative_valuationBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_project_initiativeBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_project_project_reporting_indexBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_project_reporting_index_plan_factBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_project_reportingBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_purchaseBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_revenue_by_yearBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_RouteBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_settingBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_StageBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_StepBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_successful_project_history_productBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_successful_project_historyBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_t_account_needBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_t_ActBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_t_activityBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_t_contract_productBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_t_contractorBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_t_project_riskBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_t_project_taskBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_t_projectBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.new_TransferBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.OfficeDocumentBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.OpportunityBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.PostFollowBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.PrincipalAttributeAccessMap)
                .WithRequired(e => e.OwnerBase)
                .HasForeignKey(e => e.PrincipalId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.PrincipalEntityMap)
                .WithRequired(e => e.OwnerBase)
                .HasForeignKey(e => e.PrincipalId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.ProcessSessionBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.QueueBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.QuoteBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.RatingModelBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.RatingValueBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.RecurrenceRuleBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.SalesOrderBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.SharePointDocumentBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.SharePointDocumentLocationBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.SharePointSiteBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.SocialProfileBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.SyncErrorBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.UserApplicationMetadataBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.UserEntityInstanceDataBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.UserEntityUISettingsBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.UserFormBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.UserQueryBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.UserQueryVisualizationBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OwnerBase>()
                .HasMany(e => e.SLAKPIInstanceBase)
                .WithRequired(e => e.OwnerBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonalDocumentTemplateBase>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<PersonalDocumentTemplateBase>()
                .Property(e => e.ClientData)
                .IsUnicode(false);

            modelBuilder.Entity<PersonalDocumentTemplateBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<PhoneToCaseProcessBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<PhoneToCaseProcessBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<PluginAssemblyBase>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<PluginAssemblyBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<PluginTypeBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<PluginTypeBaseIds>()
                .HasMany(e => e.PluginTypeStatisticBase)
                .WithRequired(e => e.PluginTypeBaseIds)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PositionBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<PositionBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<PositionBase>()
                .HasMany(e => e.PositionBase1)
                .WithOptional(e => e.PositionBase2)
                .HasForeignKey(e => e.ParentPositionId);

            modelBuilder.Entity<PostBase>()
                .HasMany(e => e.PostCommentBase)
                .WithRequired(e => e.PostBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PostBase>()
                .HasMany(e => e.PostLikeBase)
                .WithRequired(e => e.PostBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PostBase>()
                .HasMany(e => e.PostRoleBase)
                .WithRequired(e => e.PostBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PostFollowBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<PostRegardingBase>()
                .HasMany(e => e.PostBase)
                .WithRequired(e => e.PostRegardingBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PriceLevelBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<PriceLevelBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<PriceLevelBase>()
                .HasMany(e => e.AccountBase)
                .WithOptional(e => e.PriceLevelBase)
                .HasForeignKey(e => e.DefaultPriceLevelId);

            modelBuilder.Entity<PriceLevelBase>()
                .HasMany(e => e.CampaignBase)
                .WithOptional(e => e.PriceLevelBase)
                .HasForeignKey(e => e.PriceListId);

            modelBuilder.Entity<PriceLevelBase>()
                .HasMany(e => e.ContactBase)
                .WithOptional(e => e.PriceLevelBase)
                .HasForeignKey(e => e.DefaultPriceLevelId);

            modelBuilder.Entity<PriceLevelBase>()
                .HasMany(e => e.ProductPriceLevelBase)
                .WithRequired(e => e.PriceLevelBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PrincipalAttributeAccessMap>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<PrincipalEntityMap>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<PrincipalObjectAccess>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<PrincipalObjectAttributeAccessBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<PrivilegeBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<PrivilegeBase>()
                .HasMany(e => e.PrivilegeObjectTypeCodes)
                .WithRequired(e => e.PrivilegeBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PrivilegeBase>()
                .HasMany(e => e.RoleTemplatePrivileges)
                .WithRequired(e => e.PrivilegeBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PrivilegeObjectTypeCodes>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ProcessSessionBase>()
                .Property(e => e.ProtectionKey)
                .IsUnicode(false);

            modelBuilder.Entity<ProcessSessionBase>()
                .Property(e => e.ProcessState)
                .IsUnicode(false);

            modelBuilder.Entity<ProcessStageBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ProcessTriggerBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ProductAssociationBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ProductAssociationBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ProductAssociationBase>()
                .Property(e => e.Quantity)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ProductBase>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ProductBase>()
                .Property(e => e.CurrentCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ProductBase>()
                .Property(e => e.StockVolume)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ProductBase>()
                .Property(e => e.StandardCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ProductBase>()
                .Property(e => e.StockWeight)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ProductBase>()
                .Property(e => e.QuantityOnHand)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ProductBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ProductBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ProductBase>()
                .Property(e => e.CurrentCost_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ProductBase>()
                .Property(e => e.Price_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ProductBase>()
                .Property(e => e.StandardCost_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ProductBase>()
                .HasMany(e => e.CompetitorProduct)
                .WithRequired(e => e.ProductBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductBase>()
                .HasMany(e => e.EntitlementProducts)
                .WithRequired(e => e.ProductBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductBase>()
                .HasMany(e => e.EntitlementTemplateProducts)
                .WithRequired(e => e.ProductBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductBase>()
                .HasMany(e => e.LeadProduct)
                .WithRequired(e => e.ProductBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductBase>()
                .HasMany(e => e.ProductAssociationBase)
                .WithRequired(e => e.ProductBase)
                .HasForeignKey(e => e.AssociatedProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductBase>()
                .HasMany(e => e.ProductAssociationBase1)
                .WithRequired(e => e.ProductBase1)
                .HasForeignKey(e => e.ProductId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductBase>()
                .HasMany(e => e.ProductBase1)
                .WithOptional(e => e.ProductBase2)
                .HasForeignKey(e => e.ParentProductId);

            modelBuilder.Entity<ProductBase>()
                .HasMany(e => e.ProductPriceLevelBase)
                .WithRequired(e => e.ProductBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductBase>()
                .HasMany(e => e.ProductSubstituteBase)
                .WithRequired(e => e.ProductBase)
                .HasForeignKey(e => e.ProductId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductBase>()
                .HasMany(e => e.ProductSubstituteBase1)
                .WithRequired(e => e.ProductBase1)
                .HasForeignKey(e => e.SubstitutedProductId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductBase>()
                .HasMany(e => e.RecommendationCacheBase)
                .WithOptional(e => e.ProductBase)
                .HasForeignKey(e => e.ItemId);

            modelBuilder.Entity<ProductBase>()
                .HasMany(e => e.RecommendationCacheBase1)
                .WithOptional(e => e.ProductBase1)
                .HasForeignKey(e => e.RecommendedItemId);

            modelBuilder.Entity<ProductBase>()
                .HasMany(e => e.ProductSalesLiterature)
                .WithRequired(e => e.ProductBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductPriceLevelBase>()
                .Property(e => e.Percentage)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ProductPriceLevelBase>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ProductPriceLevelBase>()
                .Property(e => e.RoundingOptionAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ProductPriceLevelBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ProductPriceLevelBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ProductPriceLevelBase>()
                .Property(e => e.Amount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ProductPriceLevelBase>()
                .Property(e => e.RoundingOptionAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ProductPriceLevelBase>()
                .HasMany(e => e.RecommendationCacheBase)
                .WithOptional(e => e.ProductPriceLevelBase)
                .HasForeignKey(e => e.AdditionalDataRecordId);

            modelBuilder.Entity<ProductSalesLiterature>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ProductSubstituteBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ProductSubstituteBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<PublisherAddressBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<PublisherBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<PublisherBase>()
                .HasMany(e => e.SolutionBase)
                .WithRequired(e => e.PublisherBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QueueBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<QueueBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<QueueBase>()
                .HasMany(e => e.QueueMembership)
                .WithRequired(e => e.QueueBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QueueBase>()
                .HasMany(e => e.SystemUserBase1)
                .WithOptional(e => e.QueueBase1)
                .HasForeignKey(e => e.QueueId);

            modelBuilder.Entity<QueueItemBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<QueueItemBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<QueueMembership>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<QuoteBase>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<QuoteBase>()
                .Property(e => e.FreightAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<QuoteBase>()
                .Property(e => e.TotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<QuoteBase>()
                .Property(e => e.TotalLineItemAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<QuoteBase>()
                .Property(e => e.TotalLineItemDiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<QuoteBase>()
                .Property(e => e.TotalAmountLessFreight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<QuoteBase>()
                .Property(e => e.TotalTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<QuoteBase>()
                .Property(e => e.TotalDiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<QuoteBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<QuoteBase>()
                .Property(e => e.DiscountPercentage)
                .HasPrecision(23, 10);

            modelBuilder.Entity<QuoteBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<QuoteBase>()
                .Property(e => e.TotalLineItemDiscountAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<QuoteBase>()
                .Property(e => e.TotalAmountLessFreight_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<QuoteBase>()
                .Property(e => e.DiscountAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<QuoteBase>()
                .Property(e => e.FreightAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<QuoteBase>()
                .Property(e => e.TotalAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<QuoteBase>()
                .Property(e => e.TotalDiscountAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<QuoteBase>()
                .Property(e => e.TotalTax_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<QuoteBase>()
                .Property(e => e.TotalLineItemAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<QuoteBase>()
                .HasMany(e => e.ContactQuotes)
                .WithRequired(e => e.QuoteBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QuoteBase>()
                .HasMany(e => e.QuoteDetailBase)
                .WithRequired(e => e.QuoteBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QuoteDetailBase>()
                .Property(e => e.Quantity)
                .HasPrecision(23, 10);

            modelBuilder.Entity<QuoteDetailBase>()
                .Property(e => e.ManualDiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<QuoteDetailBase>()
                .Property(e => e.VolumeDiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<QuoteDetailBase>()
                .Property(e => e.PricePerUnit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<QuoteDetailBase>()
                .Property(e => e.BaseAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<QuoteDetailBase>()
                .Property(e => e.ExtendedAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<QuoteDetailBase>()
                .Property(e => e.Tax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<QuoteDetailBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<QuoteDetailBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<QuoteDetailBase>()
                .Property(e => e.Tax_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<QuoteDetailBase>()
                .Property(e => e.ExtendedAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<QuoteDetailBase>()
                .Property(e => e.PricePerUnit_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<QuoteDetailBase>()
                .Property(e => e.BaseAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<QuoteDetailBase>()
                .Property(e => e.ManualDiscountAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<QuoteDetailBase>()
                .Property(e => e.VolumeDiscountAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<QuoteDetailBase>()
                .HasMany(e => e.QuoteDetailBase1)
                .WithOptional(e => e.QuoteDetailBase2)
                .HasForeignKey(e => e.ParentBundleId);

            modelBuilder.Entity<RatingModelBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<RatingModelBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<RatingModelBase>()
                .HasMany(e => e.RatingValueBase)
                .WithOptional(e => e.RatingModelBase)
                .HasForeignKey(e => e.RatingModel);

            modelBuilder.Entity<RatingValueBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<RatingValueBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<RatingValueBase>()
                .HasMany(e => e.BookableResourceCharacteristicBase)
                .WithOptional(e => e.RatingValueBase)
                .HasForeignKey(e => e.RatingValue);

            modelBuilder.Entity<RecommendationCacheBase>()
                .Property(e => e.RecommendationRating)
                .HasPrecision(23, 10);

            modelBuilder.Entity<RecommendationModelBase>()
                .Property(e => e.ProductCatalogCrosssellLinkRating)
                .HasPrecision(23, 10);

            modelBuilder.Entity<RecommendationModelBase>()
                .Property(e => e.ProductCatalogAccessoryLinkRating)
                .HasPrecision(23, 10);

            modelBuilder.Entity<RecommendationModelBase>()
                .Property(e => e.MinRecommendationRating)
                .HasPrecision(23, 10);

            modelBuilder.Entity<RecommendationModelBaseIds>()
                .HasMany(e => e.RecommendationModelVersionBase)
                .WithRequired(e => e.RecommendationModelBaseIds)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RecommendationModelVersionBase>()
                .HasMany(e => e.RecommendationModelVersionHistoryBase)
                .WithRequired(e => e.RecommendationModelVersionBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RecommendedDocumentBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<RecommendedDocumentBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<RecurrenceRuleBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<RelationshipRoleBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<RelationshipRoleBase>()
                .HasMany(e => e.CustomerOpportunityRoleBase)
                .WithOptional(e => e.RelationshipRoleBase)
                .HasForeignKey(e => e.OpportunityRoleId);

            modelBuilder.Entity<RelationshipRoleBase>()
                .HasMany(e => e.CustomerRelationshipBase)
                .WithOptional(e => e.RelationshipRoleBase)
                .HasForeignKey(e => e.CustomerRoleId);

            modelBuilder.Entity<RelationshipRoleBase>()
                .HasMany(e => e.CustomerRelationshipBase1)
                .WithOptional(e => e.RelationshipRoleBase1)
                .HasForeignKey(e => e.PartnerRoleId);

            modelBuilder.Entity<RelationshipRoleBase>()
                .HasMany(e => e.RelationshipRoleMapBase)
                .WithRequired(e => e.RelationshipRoleBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RelationshipRoleMapBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ReportBase>()
                .Property(e => e.BodyBinary)
                .IsUnicode(false);

            modelBuilder.Entity<ReportBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ReportCategoryBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ReportCategoryBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ReportEntityBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ReportLinkBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ReportVisibilityBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ResourceBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ResourceGroupBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ResourceSpecBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ResourceSpecBase>()
                .HasMany(e => e.ServiceBase)
                .WithRequired(e => e.ResourceSpecBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RibbonCommandBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<RibbonContextGroupBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<RibbonCustomizationBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<RibbonDiffBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<RibbonRuleBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<RibbonTabToCommandMapBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<RoleBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<RoleBaseIds>()
                .HasMany(e => e.SystemUserRoles)
                .WithRequired(e => e.RoleBaseIds)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoleBaseIds>()
                .HasMany(e => e.TeamRoles)
                .WithRequired(e => e.RoleBaseIds)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RolePrivilegesBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<Rollup_Bootstrap_1f7005efada6e81180d3dbe78f6b8753>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_1f7005efada6e81180d3dbe78f6b8753>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_2721056d22ade81180d3dbe78f6b8753>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_2721056d22ade81180d3dbe78f6b8753>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_306845ef446a42e58df811c31bafaded>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_306845ef446a42e58df811c31bafaded>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_4349ff878d36e81180d2d91123acd40c>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_4349ff878d36e81180d2d91123acd40c>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_94030e73a23ce81180d3dbe78f6b8753>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_94030e73a23ce81180d3dbe78f6b8753>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_9f58728f0f38e81180d2d91123acd40c>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_9f58728f0f38e81180d2d91123acd40c>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_b6fac3703879e81180d3dbe78f6b8753>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_b6fac3703879e81180d3dbe78f6b8753>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_bacebbde18e243a7b3fb4bbdf2b2c0e5>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_bacebbde18e243a7b3fb4bbdf2b2c0e5>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_d2c321243c79e81180d3dbe78f6b8753>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_d2c321243c79e81180d3dbe78f6b8753>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_e10cdd445c7f4ac8a5d1b2118926f2bd>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_e10cdd445c7f4ac8a5d1b2118926f2bd>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_f9e939a60f38e81180d2d91123acd40c>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_f9e939a60f38e81180d2d91123acd40c>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Orphans_1f7005efada6e81180d3dbe78f6b8753>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Orphans_1f7005efada6e81180d3dbe78f6b8753>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Orphans_2721056d22ade81180d3dbe78f6b8753>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Orphans_2721056d22ade81180d3dbe78f6b8753>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Orphans_306845ef446a42e58df811c31bafaded>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Orphans_306845ef446a42e58df811c31bafaded>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Orphans_4349ff878d36e81180d2d91123acd40c>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Orphans_4349ff878d36e81180d2d91123acd40c>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Orphans_94030e73a23ce81180d3dbe78f6b8753>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Orphans_94030e73a23ce81180d3dbe78f6b8753>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Orphans_9f58728f0f38e81180d2d91123acd40c>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Orphans_9f58728f0f38e81180d2d91123acd40c>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Orphans_b6fac3703879e81180d3dbe78f6b8753>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Orphans_b6fac3703879e81180d3dbe78f6b8753>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Orphans_bacebbde18e243a7b3fb4bbdf2b2c0e5>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Orphans_bacebbde18e243a7b3fb4bbdf2b2c0e5>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Orphans_d2c321243c79e81180d3dbe78f6b8753>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Orphans_d2c321243c79e81180d3dbe78f6b8753>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Orphans_e10cdd445c7f4ac8a5d1b2118926f2bd>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Orphans_e10cdd445c7f4ac8a5d1b2118926f2bd>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Orphans_f9e939a60f38e81180d2d91123acd40c>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Orphans_f9e939a60f38e81180d2d91123acd40c>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Source_1f7005efada6e81180d3dbe78f6b8753>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Source_1f7005efada6e81180d3dbe78f6b8753>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Source_2721056d22ade81180d3dbe78f6b8753>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Source_2721056d22ade81180d3dbe78f6b8753>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Source_306845ef446a42e58df811c31bafaded>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Source_306845ef446a42e58df811c31bafaded>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Source_4349ff878d36e81180d2d91123acd40c>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Source_4349ff878d36e81180d2d91123acd40c>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Source_94030e73a23ce81180d3dbe78f6b8753>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Source_94030e73a23ce81180d3dbe78f6b8753>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Source_9f58728f0f38e81180d2d91123acd40c>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Source_9f58728f0f38e81180d2d91123acd40c>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Source_b6fac3703879e81180d3dbe78f6b8753>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Source_b6fac3703879e81180d3dbe78f6b8753>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Source_bacebbde18e243a7b3fb4bbdf2b2c0e5>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Source_bacebbde18e243a7b3fb4bbdf2b2c0e5>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Source_d2c321243c79e81180d3dbe78f6b8753>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Source_d2c321243c79e81180d3dbe78f6b8753>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Source_e10cdd445c7f4ac8a5d1b2118926f2bd>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Source_e10cdd445c7f4ac8a5d1b2118926f2bd>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Source_f9e939a60f38e81180d2d91123acd40c>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Source_f9e939a60f38e81180d2d91123acd40c>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Target_1f7005efada6e81180d3dbe78f6b8753>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Target_2721056d22ade81180d3dbe78f6b8753>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Target_306845ef446a42e58df811c31bafaded>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Target_4349ff878d36e81180d2d91123acd40c>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Target_94030e73a23ce81180d3dbe78f6b8753>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Target_9f58728f0f38e81180d2d91123acd40c>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Target_b6fac3703879e81180d3dbe78f6b8753>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Target_bacebbde18e243a7b3fb4bbdf2b2c0e5>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Target_d2c321243c79e81180d3dbe78f6b8753>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Target_e10cdd445c7f4ac8a5d1b2118926f2bd>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<Rollup_Bootstrap_Target_f9e939a60f38e81180d2d91123acd40c>()
                .Property(e => e.OutputValue)
                .HasPrecision(38, 10);

            modelBuilder.Entity<RollupFieldBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<RollupPropertiesBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<RoutingRuleBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<RoutingRuleBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<RoutingRuleItemBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<RoutingRuleItemBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SalesLiteratureBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SalesLiteratureBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<SalesLiteratureBase>()
                .HasMany(e => e.CompetitorSalesLiterature)
                .WithRequired(e => e.SalesLiteratureBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesLiteratureBase>()
                .HasMany(e => e.ProductSalesLiterature)
                .WithRequired(e => e.SalesLiteratureBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesLiteratureBase>()
                .HasMany(e => e.SalesLiteratureItemBase)
                .WithRequired(e => e.SalesLiteratureBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesLiteratureItemBase>()
                .Property(e => e.DocumentBody)
                .IsUnicode(false);

            modelBuilder.Entity<SalesLiteratureItemBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SalesOrderBase>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderBase>()
                .Property(e => e.FreightAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderBase>()
                .Property(e => e.TotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderBase>()
                .Property(e => e.TotalLineItemAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderBase>()
                .Property(e => e.TotalLineItemDiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderBase>()
                .Property(e => e.TotalAmountLessFreight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderBase>()
                .Property(e => e.TotalDiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderBase>()
                .Property(e => e.TotalTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SalesOrderBase>()
                .Property(e => e.DiscountPercentage)
                .HasPrecision(23, 10);

            modelBuilder.Entity<SalesOrderBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<SalesOrderBase>()
                .Property(e => e.TotalLineItemAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderBase>()
                .Property(e => e.TotalDiscountAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderBase>()
                .Property(e => e.TotalAmountLessFreight_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderBase>()
                .Property(e => e.TotalAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderBase>()
                .Property(e => e.DiscountAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderBase>()
                .Property(e => e.FreightAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderBase>()
                .Property(e => e.TotalLineItemDiscountAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderBase>()
                .Property(e => e.TotalTax_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderBase>()
                .HasMany(e => e.ContactOrders)
                .WithRequired(e => e.SalesOrderBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesOrderBase>()
                .HasMany(e => e.SalesOrderDetailBase)
                .WithRequired(e => e.SalesOrderBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesOrderDetailBase>()
                .Property(e => e.QuantityShipped)
                .HasPrecision(23, 10);

            modelBuilder.Entity<SalesOrderDetailBase>()
                .Property(e => e.QuantityBackordered)
                .HasPrecision(23, 10);

            modelBuilder.Entity<SalesOrderDetailBase>()
                .Property(e => e.QuantityCancelled)
                .HasPrecision(23, 10);

            modelBuilder.Entity<SalesOrderDetailBase>()
                .Property(e => e.Quantity)
                .HasPrecision(23, 10);

            modelBuilder.Entity<SalesOrderDetailBase>()
                .Property(e => e.ManualDiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderDetailBase>()
                .Property(e => e.VolumeDiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderDetailBase>()
                .Property(e => e.PricePerUnit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderDetailBase>()
                .Property(e => e.BaseAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderDetailBase>()
                .Property(e => e.ExtendedAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderDetailBase>()
                .Property(e => e.Tax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderDetailBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SalesOrderDetailBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<SalesOrderDetailBase>()
                .Property(e => e.BaseAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderDetailBase>()
                .Property(e => e.PricePerUnit_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderDetailBase>()
                .Property(e => e.VolumeDiscountAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderDetailBase>()
                .Property(e => e.ExtendedAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderDetailBase>()
                .Property(e => e.Tax_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderDetailBase>()
                .Property(e => e.ManualDiscountAmount_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderDetailBase>()
                .HasMany(e => e.SalesOrderDetailBase1)
                .WithOptional(e => e.SalesOrderDetailBase2)
                .HasForeignKey(e => e.ParentBundleId);

            modelBuilder.Entity<SavedQueryBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SavedQueryVisualizationBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SdkMessageBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SdkMessageBaseIds>()
                .HasMany(e => e.SdkMessageFilterBase)
                .WithRequired(e => e.SdkMessageBaseIds)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SdkMessageFilterBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SdkMessagePairBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SdkMessageProcessingStepBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SdkMessageProcessingStepImageBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SdkMessageRequestBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SdkMessageRequestFieldBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SdkMessageResponseBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SdkMessageResponseFieldBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ServiceBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ServiceBase>()
                .HasMany(e => e.AccountBase)
                .WithOptional(e => e.ServiceBase)
                .HasForeignKey(e => e.PreferredServiceId);

            modelBuilder.Entity<ServiceBase>()
                .HasMany(e => e.ContactBase)
                .WithOptional(e => e.ServiceBase)
                .HasForeignKey(e => e.PreferredServiceId);

            modelBuilder.Entity<ServiceContractContacts>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SharePointDocumentBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<SharePointDocumentLocationBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SharePointDocumentLocationBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<SharePointSiteBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<SharePointSiteBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SimilarityRuleBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SimilarityRuleBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<SiteBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SiteMapBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SLABase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<SLABase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SLABaseIds>()
                .HasMany(e => e.ActivityPointerBase)
                .WithOptional(e => e.SLABaseIds)
                .HasForeignKey(e => e.SLAId);

            modelBuilder.Entity<SLABaseIds>()
                .HasMany(e => e.ActivityPointerBase1)
                .WithOptional(e => e.SLABaseIds1)
                .HasForeignKey(e => e.SLAId);

            modelBuilder.Entity<SLABaseIds>()
                .HasMany(e => e.ActivityPointerBase2)
                .WithOptional(e => e.SLABaseIds2)
                .HasForeignKey(e => e.SLAId);

            modelBuilder.Entity<SLABaseIds>()
                .HasMany(e => e.ActivityPointerBase3)
                .WithOptional(e => e.SLABaseIds3)
                .HasForeignKey(e => e.SLAId);

            modelBuilder.Entity<SLABaseIds>()
                .HasMany(e => e.ActivityPointerBase4)
                .WithOptional(e => e.SLABaseIds4)
                .HasForeignKey(e => e.SLAId);

            modelBuilder.Entity<SLABaseIds>()
                .HasMany(e => e.ActivityPointerBase5)
                .WithOptional(e => e.SLABaseIds5)
                .HasForeignKey(e => e.SLAId);

            modelBuilder.Entity<SLABaseIds>()
                .HasMany(e => e.ActivityPointerBase6)
                .WithOptional(e => e.SLABaseIds6)
                .HasForeignKey(e => e.SLAId);

            modelBuilder.Entity<SLABaseIds>()
                .HasMany(e => e.ActivityPointerBase7)
                .WithOptional(e => e.SLABaseIds7)
                .HasForeignKey(e => e.SLAId);

            modelBuilder.Entity<SLABaseIds>()
                .HasMany(e => e.ActivityPointerBase8)
                .WithOptional(e => e.SLABaseIds8)
                .HasForeignKey(e => e.SLAId);

            modelBuilder.Entity<SLAItemBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<SLAItemBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SLAKPIInstanceBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<SLAKPIInstanceBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SLAKPIInstanceBase>()
                .HasMany(e => e.IncidentBase)
                .WithOptional(e => e.SLAKPIInstanceBase)
                .HasForeignKey(e => e.FirstResponseByKPIId);

            modelBuilder.Entity<SLAKPIInstanceBase>()
                .HasMany(e => e.IncidentBase1)
                .WithOptional(e => e.SLAKPIInstanceBase1)
                .HasForeignKey(e => e.ResolveByKPIId);

            modelBuilder.Entity<SocialProfileBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SocialProfileBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<SocialProfileBase>()
                .HasMany(e => e.ActivityPointerBase)
                .WithOptional(e => e.SocialProfileBase)
                .HasForeignKey(e => e.PostFromProfileId);

            modelBuilder.Entity<SolutionBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SolutionBase>()
                .HasMany(e => e.DependencyNodeBase)
                .WithOptional(e => e.SolutionBase)
                .HasForeignKey(e => e.BaseSolutionId);

            modelBuilder.Entity<SolutionBase>()
                .HasMany(e => e.DependencyNodeBase1)
                .WithOptional(e => e.SolutionBase1)
                .HasForeignKey(e => e.TopSolutionId);

            modelBuilder.Entity<SolutionBase>()
                .HasMany(e => e.SolutionBase1)
                .WithOptional(e => e.SolutionBase2)
                .HasForeignKey(e => e.ParentSolutionId);

            modelBuilder.Entity<SolutionComponentBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SolutionComponentBase>()
                .HasMany(e => e.SolutionComponentBase1)
                .WithOptional(e => e.SolutionComponentBase2)
                .HasForeignKey(e => e.RootSolutionComponentId);

            modelBuilder.Entity<StatusMapBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<StringMapBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SubjectBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SubjectBase>()
                .HasMany(e => e.DocumentIndex)
                .WithRequired(e => e.SubjectBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SubjectBase>()
                .HasMany(e => e.KbArticleBase)
                .WithRequired(e => e.SubjectBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SubjectBase>()
                .HasMany(e => e.SubjectBase1)
                .WithOptional(e => e.SubjectBase2)
                .HasForeignKey(e => e.ParentSubject);

            modelBuilder.Entity<Subscription>()
                .HasMany(e => e.SubscriptionManuallyTrackedObject)
                .WithRequired(e => e.Subscription)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subscription>()
                .HasMany(e => e.SubscriptionClients)
                .WithRequired(e => e.Subscription)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SubscriptionManuallyTrackedObject>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SubscriptionTrackingDeletedObject>()
                .Property(e => e.TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<SyncErrorBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SystemFormBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SystemUserBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SystemUserBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.AccountBase)
                .WithOptional(e => e.SystemUserBase)
                .HasForeignKey(e => e.PreferredSystemUserId);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.BookableResourceBase)
                .WithOptional(e => e.SystemUserBase)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.ContactBase)
                .WithOptional(e => e.SystemUserBase)
                .HasForeignKey(e => e.PreferredSystemUserId);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.InvoiceDetailBase)
                .WithOptional(e => e.SystemUserBase)
                .HasForeignKey(e => e.SalesRepId);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.KnowledgeArticleBase)
                .WithOptional(e => e.SystemUserBase)
                .HasForeignKey(e => e.primaryauthorid);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.msdyn_wallsavedqueryusersettingsBase)
                .WithOptional(e => e.SystemUserBase)
                .HasForeignKey(e => e.msdyn_userid);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.new_businessunit_roleBase)
                .WithOptional(e => e.SystemUserBase)
                .HasForeignKey(e => e.new_systemuser_Id);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.new_new_project_initiative_valuation_systemBase)
                .WithRequired(e => e.SystemUserBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.new_project_initiative_valuationBase)
                .WithOptional(e => e.SystemUserBase)
                .HasForeignKey(e => e.new_prjct_initv_valuation_agreeder);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.new_project_initiative_valuationBase1)
                .WithOptional(e => e.SystemUserBase1)
                .HasForeignKey(e => e.new_prjct_initv_valuation_approver);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.new_t_projectBase)
                .WithOptional(e => e.SystemUserBase)
                .HasForeignKey(e => e.new_link_curator_Id);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.OwnerMappingBase)
                .WithOptional(e => e.SystemUserBase)
                .HasForeignKey(e => e.TargetSystemUserId);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.PluginTypeStatisticBase)
                .WithOptional(e => e.SystemUserBase)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.PluginTypeStatisticBase1)
                .WithOptional(e => e.SystemUserBase1)
                .HasForeignKey(e => e.ModifiedBy);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.QueueBase)
                .WithOptional(e => e.SystemUserBase)
                .HasForeignKey(e => e.PrimaryUserId);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.QueueMembership)
                .WithRequired(e => e.SystemUserBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.QuoteDetailBase)
                .WithOptional(e => e.SystemUserBase)
                .HasForeignKey(e => e.SalesRepId);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SalesLiteratureBase)
                .WithOptional(e => e.SystemUserBase)
                .HasForeignKey(e => e.EmployeeContactId);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SalesOrderDetailBase)
                .WithOptional(e => e.SystemUserBase)
                .HasForeignKey(e => e.SalesRepId);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SdkMessageBase)
                .WithOptional(e => e.SystemUserBase)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SdkMessageBase1)
                .WithOptional(e => e.SystemUserBase1)
                .HasForeignKey(e => e.CreatedOnBehalfBy);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SdkMessageBase2)
                .WithOptional(e => e.SystemUserBase2)
                .HasForeignKey(e => e.ModifiedBy);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SdkMessageBase3)
                .WithOptional(e => e.SystemUserBase3)
                .HasForeignKey(e => e.ModifiedOnBehalfBy);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SdkMessageFilterBase)
                .WithOptional(e => e.SystemUserBase)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SdkMessageFilterBase1)
                .WithOptional(e => e.SystemUserBase1)
                .HasForeignKey(e => e.CreatedOnBehalfBy);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SdkMessageFilterBase2)
                .WithOptional(e => e.SystemUserBase2)
                .HasForeignKey(e => e.ModifiedBy);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SdkMessageFilterBase3)
                .WithOptional(e => e.SystemUserBase3)
                .HasForeignKey(e => e.ModifiedOnBehalfBy);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SdkMessagePairBase)
                .WithOptional(e => e.SystemUserBase)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SdkMessagePairBase1)
                .WithOptional(e => e.SystemUserBase1)
                .HasForeignKey(e => e.CreatedOnBehalfBy);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SdkMessagePairBase2)
                .WithOptional(e => e.SystemUserBase2)
                .HasForeignKey(e => e.ModifiedBy);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SdkMessagePairBase3)
                .WithOptional(e => e.SystemUserBase3)
                .HasForeignKey(e => e.ModifiedOnBehalfBy);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SdkMessageRequestBase)
                .WithOptional(e => e.SystemUserBase)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SdkMessageRequestBase1)
                .WithOptional(e => e.SystemUserBase1)
                .HasForeignKey(e => e.CreatedOnBehalfBy);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SdkMessageRequestBase2)
                .WithOptional(e => e.SystemUserBase2)
                .HasForeignKey(e => e.ModifiedBy);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SdkMessageRequestBase3)
                .WithOptional(e => e.SystemUserBase3)
                .HasForeignKey(e => e.ModifiedOnBehalfBy);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SdkMessageRequestFieldBase)
                .WithOptional(e => e.SystemUserBase)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SdkMessageRequestFieldBase1)
                .WithOptional(e => e.SystemUserBase1)
                .HasForeignKey(e => e.CreatedOnBehalfBy);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SdkMessageRequestFieldBase2)
                .WithOptional(e => e.SystemUserBase2)
                .HasForeignKey(e => e.ModifiedBy);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SdkMessageRequestFieldBase3)
                .WithOptional(e => e.SystemUserBase3)
                .HasForeignKey(e => e.ModifiedOnBehalfBy);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SdkMessageResponseBase)
                .WithOptional(e => e.SystemUserBase)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SdkMessageResponseBase1)
                .WithOptional(e => e.SystemUserBase1)
                .HasForeignKey(e => e.CreatedOnBehalfBy);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SdkMessageResponseBase2)
                .WithOptional(e => e.SystemUserBase2)
                .HasForeignKey(e => e.ModifiedBy);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SdkMessageResponseBase3)
                .WithOptional(e => e.SystemUserBase3)
                .HasForeignKey(e => e.ModifiedOnBehalfBy);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SdkMessageResponseFieldBase)
                .WithOptional(e => e.SystemUserBase)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SdkMessageResponseFieldBase1)
                .WithOptional(e => e.SystemUserBase1)
                .HasForeignKey(e => e.CreatedOnBehalfBy);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SdkMessageResponseFieldBase2)
                .WithOptional(e => e.SystemUserBase2)
                .HasForeignKey(e => e.ModifiedBy);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SdkMessageResponseFieldBase3)
                .WithOptional(e => e.SystemUserBase3)
                .HasForeignKey(e => e.ModifiedOnBehalfBy);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.TaskBase)
                .WithOptional(e => e.SystemUserBase)
                .HasForeignKey(e => e.new_task_manager);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SystemUserPrincipals)
                .WithRequired(e => e.SystemUserBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.UserFiscalCalendarBase)
                .WithOptional(e => e.SystemUserBase)
                .HasForeignKey(e => e.SalesPersonId);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SystemUserRoles)
                .WithRequired(e => e.SystemUserBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.TeamMembership)
                .WithRequired(e => e.SystemUserBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.TerritoryBase)
                .WithOptional(e => e.SystemUserBase)
                .HasForeignKey(e => e.ManagerId);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SystemUserProfiles)
                .WithRequired(e => e.SystemUserBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SystemUserSyncMappingProfiles)
                .WithRequired(e => e.SystemUserBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SystemUserBusinessUnitEntityMap)
                .WithRequired(e => e.SystemUserBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SystemUserBase>()
                .HasMany(e => e.SystemUserBase1)
                .WithOptional(e => e.SystemUserBase2)
                .HasForeignKey(e => e.ParentSystemUserId);

            modelBuilder.Entity<SystemUserBase>()
                .HasOptional(e => e.UserSettingsBase)
                .WithRequired(e => e.SystemUserBase);

            modelBuilder.Entity<SystemUserBusinessUnitEntityMap>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SystemUserLicenses>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SystemUserPrincipals>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SystemUserProfiles>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SystemUserRoles>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<TeamBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<TeamBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<TeamBase>()
                .HasMany(e => e.TeamMembership)
                .WithRequired(e => e.TeamBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TeamBase>()
                .HasMany(e => e.TeamProfiles)
                .WithRequired(e => e.TeamBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TeamBase>()
                .HasMany(e => e.TeamRoles)
                .WithRequired(e => e.TeamBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TeamBase>()
                .HasMany(e => e.TeamSyncAttributeMappingProfiles)
                .WithRequired(e => e.TeamBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TeamMembership>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<TeamProfiles>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<TeamRoles>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<TemplateBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<TemplateBaseIds>()
                .HasMany(e => e.OrganizationBase)
                .WithOptional(e => e.TemplateBaseIds)
                .HasForeignKey(e => e.AcknowledgementTemplateId);

            modelBuilder.Entity<TerritoryBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<TerritoryBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<TerritoryBase>()
                .HasMany(e => e.SystemUserBase1)
                .WithOptional(e => e.TerritoryBase1)
                .HasForeignKey(e => e.TerritoryId);

            modelBuilder.Entity<ThemeBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ThemeBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<TimeZoneDefinitionBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<TimeZoneDefinitionBase>()
                .HasMany(e => e.TimeZoneLocalizedNameBase)
                .WithRequired(e => e.TimeZoneDefinitionBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TimeZoneDefinitionBase>()
                .HasMany(e => e.TimeZoneRuleBase)
                .WithRequired(e => e.TimeZoneDefinitionBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TimeZoneLocalizedNameBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<TimeZoneRuleBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<TopicModelConfigurationBase>()
                .Property(e => e.MinRelevanceScore)
                .HasPrecision(23, 10);

            modelBuilder.Entity<TopicModelConfigurationBaseIds>()
                .HasMany(e => e.TopicModelBase)
                .WithOptional(e => e.TopicModelConfigurationBaseIds)
                .HasForeignKey(e => e.ConfigurationUsed);

            modelBuilder.Entity<TraceLogBase>()
                .HasMany(e => e.TraceAssociationBase)
                .WithRequired(e => e.TraceLogBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TraceLogBase>()
                .HasMany(e => e.TraceLogBase1)
                .WithOptional(e => e.TraceLogBase2)
                .HasForeignKey(e => e.ParentTraceLogId);

            modelBuilder.Entity<TraceRegardingBase>()
                .HasMany(e => e.TraceLogBase)
                .WithRequired(e => e.TraceRegardingBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransactionCurrencyBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<TransactionCurrencyBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<TransactionCurrencyBase>()
                .HasMany(e => e.ActivityPointerBase)
                .WithOptional(e => e.TransactionCurrencyBase)
                .HasForeignKey(e => e.TransactionCurrencyId);

            modelBuilder.Entity<TransactionCurrencyBase>()
                .HasMany(e => e.ActivityPointerBase1)
                .WithOptional(e => e.TransactionCurrencyBase1)
                .HasForeignKey(e => e.TransactionCurrencyId);

            modelBuilder.Entity<TransactionCurrencyBase>()
                .HasMany(e => e.OrganizationBase)
                .WithOptional(e => e.TransactionCurrencyBase)
                .HasForeignKey(e => e.BaseCurrencyId);

            modelBuilder.Entity<TransactionCurrencyBase>()
                .HasMany(e => e.UserFiscalCalendarBase)
                .WithOptional(e => e.TransactionCurrencyBase)
                .HasForeignKey(e => e.TransactionCurrencyId);

            modelBuilder.Entity<TransactionCurrencyBase>()
                .HasMany(e => e.UserFiscalCalendarBase1)
                .WithOptional(e => e.TransactionCurrencyBase1)
                .HasForeignKey(e => e.TransactionCurrencyId);

            modelBuilder.Entity<TransactionCurrencyBase>()
                .HasMany(e => e.UserFiscalCalendarBase2)
                .WithOptional(e => e.TransactionCurrencyBase2)
                .HasForeignKey(e => e.TransactionCurrencyId);

            modelBuilder.Entity<TransactionCurrencyBase>()
                .HasMany(e => e.UserFiscalCalendarBase3)
                .WithOptional(e => e.TransactionCurrencyBase3)
                .HasForeignKey(e => e.TransactionCurrencyId);

            modelBuilder.Entity<TransactionCurrencyBase>()
                .HasMany(e => e.UserFiscalCalendarBase4)
                .WithOptional(e => e.TransactionCurrencyBase4)
                .HasForeignKey(e => e.TransactionCurrencyId);

            modelBuilder.Entity<TransactionCurrencyBase>()
                .HasMany(e => e.UserFiscalCalendarBase5)
                .WithOptional(e => e.TransactionCurrencyBase5)
                .HasForeignKey(e => e.TransactionCurrencyId);

            modelBuilder.Entity<TranslationProcessBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<TranslationProcessBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<UnresolvedAddressBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<UoMBase>()
                .Property(e => e.Quantity)
                .HasPrecision(23, 10);

            modelBuilder.Entity<UoMBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<UoMBase>()
                .HasMany(e => e.ProductBase)
                .WithOptional(e => e.UoMBase)
                .HasForeignKey(e => e.DefaultUoMId);

            modelBuilder.Entity<UoMBase>()
                .HasMany(e => e.UoMBase1)
                .WithOptional(e => e.UoMBase2)
                .HasForeignKey(e => e.BaseUoM);

            modelBuilder.Entity<UoMScheduleBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<UoMScheduleBase>()
                .HasMany(e => e.ProductBase)
                .WithOptional(e => e.UoMScheduleBase)
                .HasForeignKey(e => e.DefaultUoMScheduleId);

            modelBuilder.Entity<UoMScheduleBase>()
                .HasMany(e => e.UoMBase)
                .WithRequired(e => e.UoMScheduleBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserEntityInstanceDataBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<UserEntityUISettingsBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<UserFiscalCalendarBase>()
                .Property(e => e.Period1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserFiscalCalendarBase>()
                .Property(e => e.Period2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserFiscalCalendarBase>()
                .Property(e => e.Period3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserFiscalCalendarBase>()
                .Property(e => e.Period4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserFiscalCalendarBase>()
                .Property(e => e.Period5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserFiscalCalendarBase>()
                .Property(e => e.Period6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserFiscalCalendarBase>()
                .Property(e => e.Period7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserFiscalCalendarBase>()
                .Property(e => e.Period8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserFiscalCalendarBase>()
                .Property(e => e.Period9)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserFiscalCalendarBase>()
                .Property(e => e.Period10)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserFiscalCalendarBase>()
                .Property(e => e.Period11)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserFiscalCalendarBase>()
                .Property(e => e.Period12)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserFiscalCalendarBase>()
                .Property(e => e.Period13)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserFiscalCalendarBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<UserFiscalCalendarBase>()
                .Property(e => e.Period4_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserFiscalCalendarBase>()
                .Property(e => e.Period11_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserFiscalCalendarBase>()
                .Property(e => e.Period3_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserFiscalCalendarBase>()
                .Property(e => e.Period1_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserFiscalCalendarBase>()
                .Property(e => e.Period6_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserFiscalCalendarBase>()
                .Property(e => e.Period8_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserFiscalCalendarBase>()
                .Property(e => e.Period9_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserFiscalCalendarBase>()
                .Property(e => e.Period7_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserFiscalCalendarBase>()
                .Property(e => e.Period5_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserFiscalCalendarBase>()
                .Property(e => e.Period13_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserFiscalCalendarBase>()
                .Property(e => e.Period10_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserFiscalCalendarBase>()
                .Property(e => e.Period12_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserFiscalCalendarBase>()
                .Property(e => e.Period2_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserFormBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<UserMappingBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<UserMappingBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<UserQueryBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<UserQueryVisualizationBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<UserSettingsBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<WebResourceBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<WebResourceBase>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<WebResourceBaseIds>()
                .HasMany(e => e.SolutionBase)
                .WithOptional(e => e.WebResourceBaseIds)
                .HasForeignKey(e => e.ConfigurationPageId);

            modelBuilder.Entity<WebWizardBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<WebWizardBase>()
                .HasMany(e => e.WizardAccessPrivilegeBase)
                .WithRequired(e => e.WebWizardBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WebWizardBase>()
                .HasMany(e => e.WizardPageBase)
                .WithRequired(e => e.WebWizardBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WizardAccessPrivilegeBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<WizardPageBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<WorkflowBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<WorkflowBaseIds>()
                .HasMany(e => e.bng_SchedulerSessionBase)
                .WithOptional(e => e.WorkflowBaseIds)
                .HasForeignKey(e => e.bng_WorkflowId);

            modelBuilder.Entity<WorkflowBaseIds>()
                .HasMany(e => e.bng_ShedulerTaskBase)
                .WithOptional(e => e.WorkflowBaseIds)
                .HasForeignKey(e => e.bng_WorkflowId);

            modelBuilder.Entity<WorkflowBaseIds>()
                .HasMany(e => e.new_RouteBase)
                .WithOptional(e => e.WorkflowBaseIds)
                .HasForeignKey(e => e.new_WorkflowId);

            modelBuilder.Entity<WorkflowBaseIds>()
                .HasMany(e => e.new_TransferBase)
                .WithOptional(e => e.WorkflowBaseIds)
                .HasForeignKey(e => e.new_WorkflowId);

            modelBuilder.Entity<WorkflowBaseIds>()
                .HasMany(e => e.ProcessSessionBase)
                .WithOptional(e => e.WorkflowBaseIds)
                .HasForeignKey(e => e.ProcessId);

            modelBuilder.Entity<WorkflowBaseIds>()
                .HasMany(e => e.WorkflowDependencyBase)
                .WithRequired(e => e.WorkflowBaseIds)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WorkflowDependencyBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<xd_activity_presaleBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<ActionCardUserStateBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<ActionCardUserStateBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<CustomControlDefaultConfigBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<DelveActionHubBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<DelveActionHubBase>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<OrganizationUIBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<PrincipalSyncAttributeMapBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SyncAttributeMappingProfileBase>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SystemUserManagerMap>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<SystemUserSyncMappingProfiles>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<TeamSyncAttributeMappingProfiles>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();
        }
    }
}
