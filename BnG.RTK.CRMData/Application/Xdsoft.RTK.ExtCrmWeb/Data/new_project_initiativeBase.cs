namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_project_initiativeBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public new_project_initiativeBase()
        {
            new_potential_accountBase = new HashSet<new_potential_accountBase>();
            new_project_initiative_valuationBase = new HashSet<new_project_initiative_valuationBase>();
            new_revenue_by_yearBase = new HashSet<new_revenue_by_yearBase>();
            new_t_activityBase = new HashSet<new_t_activityBase>();
            new_t_projectBase = new HashSet<new_t_projectBase>();
            new_t_project_riskBase = new HashSet<new_t_project_riskBase>();
        }

        [Key]
        public Guid new_project_initiativeId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid OwnerId { get; set; }

        public int OwnerIdType { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public int statecode { get; set; }

        public int? statuscode { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        [StringLength(100)]
        public string new_name { get; set; }

        public Guid? new_link_department_project_initiativ { get; set; }

        public Guid? new_d_forms_of_possible_income_id { get; set; }

        public Guid? new_d_possible_legal_form_id { get; set; }

        public Guid? new_d_product_catalog_id { get; set; }

        public Guid? new_t_account_id { get; set; }

        [StringLength(100)]
        public string new_possible_content_of_works { get; set; }

        public Guid? processid { get; set; }

        public Guid? stageid { get; set; }

        [StringLength(1250)]
        public string traversedpath { get; set; }

        public Guid? new_link_t_activity_t_project_initiat { get; set; }

        public Guid? new_link_project_type { get; set; }

        public decimal? new_possible_amount_of_investments { get; set; }

        [StringLength(1000)]
        public string new_tender_link { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? new_possible_marginality { get; set; }

        public decimal? new_possible_revenue_msfo { get; set; }

        public bool? new_RSBU_MSFO_sign { get; set; }

        public decimal? new_possible_revenue_rsbu { get; set; }

        [StringLength(100)]
        public string new_TEO_number { get; set; }

        public int? new_Is_tender { get; set; }

        public decimal? new_sum_to_close_overall_rsbu { get; set; }

        public DateTime? new_sum_to_close_overall_rsbu_Date { get; set; }

        public int? new_sum_to_close_overall_rsbu_State { get; set; }

        public decimal? new_sum_VAT_to_close_overall_msfo { get; set; }

        public DateTime? new_sum_VAT_to_close_overall_msfo_Date { get; set; }

        public int? new_sum_VAT_to_close_overall_msfo_State { get; set; }

        public int? new_RSBU_MSFO_mark { get; set; }

        public bool? new_Is_Stage_Ended { get; set; }

        public Guid? new_purchase_Id { get; set; }

        public Guid? new_new_d_sphere_of_activity_id { get; set; }

        public int? new_msg_type { get; set; }

        [StringLength(1000)]
        public string new_msg_text { get; set; }

        public Guid? new_link_initiative_probability_id { get; set; }

        public int? new_service_type { get; set; }

        [StringLength(1000)]
        public string new_initiative_status_comment { get; set; }

        public Guid? new_link_product_developer_id { get; set; }

        public int? new_subsidiary_company_add_type { get; set; }

        [StringLength(1000)]
        public string new_subsidiary_company { get; set; }

        public int? new_type_of_financing { get; set; }

        public Guid? new_link_subsidiary_company_id { get; set; }

        public int? new_requirement_valuation_credit_potential { get; set; }

        public int? new_valuation_optimal_cost_requirement { get; set; }

        public int? new_valuation_juristic_conclusion_requirement { get; set; }

        public int? new_valuation_economic_efficiency_requirement { get; set; }

        public int? new_valuation_risk_requirement { get; set; }

        public decimal? new_forecast_margin { get; set; }

        public Guid? new_link_territory_id { get; set; }

        public Guid? new_link_product_group_id { get; set; }

        [StringLength(100)]
        public string new_ID { get; set; }

        public Guid? new_stepID { get; set; }

        public DateTime? new_StepDateStart { get; set; }

        public decimal? new_forecast_margin_RSBU { get; set; }

        public decimal? new_forecast_margin_MSFO { get; set; }

        public Guid? new_keytask_taskid { get; set; }

        public Guid? new_link_businessunit_MRF_id { get; set; }

        public Guid? new_link_project_initiative_valuation { get; set; }

        public virtual AccountBase AccountBase { get; set; }

        public virtual AccountBase AccountBase1 { get; set; }

        public virtual AccountBase AccountBase2 { get; set; }

        public virtual ActivityPointerBase ActivityPointerBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase1 { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase2 { get; set; }

        public virtual new_d_forms_of_possible_incomeBase new_d_forms_of_possible_incomeBase { get; set; }

        public virtual new_d_possible_legal_formBase new_d_possible_legal_formBase { get; set; }

        public virtual new_d_product_catalogBase new_d_product_catalogBase { get; set; }

        public virtual new_d_product_groupsBase new_d_product_groupsBase { get; set; }

        public virtual new_d_product_typesBase new_d_product_typesBase { get; set; }

        public virtual new_d_sphere_of_activityBase new_d_sphere_of_activityBase { get; set; }

        public virtual new_initiative_probabilityBase new_initiative_probabilityBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_potential_accountBase> new_potential_accountBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_initiative_valuationBase> new_project_initiative_valuationBase { get; set; }

        public virtual new_project_initiative_valuationBase new_project_initiative_valuationBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_revenue_by_yearBase> new_revenue_by_yearBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_activityBase> new_t_activityBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_projectBase> new_t_projectBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_project_riskBase> new_t_project_riskBase { get; set; }

        public virtual new_purchaseBase new_purchaseBase { get; set; }

        public virtual new_StepBase new_StepBase { get; set; }

        public virtual new_t_activityBase new_t_activityBase1 { get; set; }

        public virtual new_territoryBase new_territoryBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
