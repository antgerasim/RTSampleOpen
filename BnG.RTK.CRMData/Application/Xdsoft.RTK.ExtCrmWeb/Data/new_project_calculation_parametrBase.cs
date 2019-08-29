namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_project_calculation_parametrBase
    {
        [Key]
        public Guid new_project_calculation_parametrId { get; set; }

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

        public decimal? new_amortization { get; set; }

        public decimal? new_DS_income_of_operating_activity { get; set; }

        public decimal? new_DS_outcome_of_operating_activity { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? new_result_of_operating_activity { get; set; }

        public decimal? new_DS_outcome_investment_activity { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? new_CF { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? new_accumulative_CF { get; set; }

        public decimal? new_nominal_income_RSBU { get; set; }

        public decimal? new_discounting_effect_installment_12_months { get; set; }

        public decimal? new_Transformational_adjustment { get; set; }

        public decimal? new_income_of_non_initializing_CFO { get; set; }

        public decimal? new_outcome_on_contracting_organization { get; set; }

        public decimal? new_outcome_on_contracting_organization_DZO { get; set; }

        public decimal? new_PL_diroutcome_transformational_adjustment { get; set; }

        public decimal? new_PL_direct_outcome_outcome_1 { get; set; }

        public decimal? new_PL_direct_outcome_outcome_2 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? new_other_direct_outcome { get; set; }

        public decimal? new_Contribution_to_RUO { get; set; }

        public decimal? new_PL_other_direct_outcome_outcome_1 { get; set; }

        public decimal? new_PL_other_direct_outcome_outcome_2 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? new_Other_directoutcome_CFO_realisationmember { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? new_Other_direct_outcome_with_TK { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? new_PL_direct_outcome_initiating_CFO { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? new_PL_direct_outcome_sum { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? new_PL_income_MSFO { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? new_Gross_Margin { get; set; }

        public decimal? new_CAPEX_OKB_RSBU_external { get; set; }

        public decimal? new_CAPEX_OKB_RSBU_DZO { get; set; }

        public decimal? new_CAPEX_OKB_Transformational_adjustment { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? new_CAPEX_OKB { get; set; }

        public decimal? new_GM_outcome_on_stuff_KB { get; set; }

        public decimal? new_GM_GPH_COMM { get; set; }

        public decimal? new_GM_advertising_and_marketing { get; set; }

        public decimal? new_GM_other { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? new_Contribution_Margin { get; set; }

        public decimal? new_CM_outcome_on_AUP { get; set; }

        public decimal? new_CM_GPH_other { get; set; }

        public decimal? new_CM_Taxes_and_fees { get; set; }

        public decimal? new_CM_materials { get; set; }

        public decimal? new_CM_other { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? new_Gross_Margin_CFO_percent { get; set; }

        public decimal? new_EBIT_percent_for_issuing_bank_guarantee { get; set; }

        public decimal? new_percent_on_credit { get; set; }

        public decimal? new_EBIT_finance_income { get; set; }

        public decimal? new_Gross_Margin_percent { get; set; }

        public decimal? new_Contribution_Margin_percent { get; set; }

        public decimal? new_OIBDA { get; set; }

        public decimal? new_OIBDA_Margin_percent { get; set; }

        public decimal? new_EBIT { get; set; }

        public decimal? new_EBIT_Margin_percent { get; set; }

        public decimal? new_EBT { get; set; }

        public decimal? new_EBT_Margin_percent { get; set; }

        [StringLength(100)]
        public string new_reason_of_project_calculate { get; set; }

        [StringLength(100)]
        public string new_period { get; set; }

        [StringLength(100)]
        public string new_project_initiative_description { get; set; }

        public Guid? new_project_initiative_valuation_id { get; set; }

        public Guid? new_link_project_id { get; set; }

        public Guid? new_project_calculation_parametr_id { get; set; }

        public Guid? new_parameter_PI_evaluationId { get; set; }

        public virtual AccountBase AccountBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual new_parameter_project_initiative_evaluationBase new_parameter_project_initiative_evaluationBase { get; set; }

        public virtual new_project_initiative_valuationBase new_project_initiative_valuationBase { get; set; }

        public virtual new_t_projectBase new_t_projectBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
