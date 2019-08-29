namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_parameter_project_initiative_evaluationBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public new_parameter_project_initiative_evaluationBase()
        {
            new_project_initiative_valuationBase = new HashSet<new_project_initiative_valuationBase>();
            new_project_calculation_parametrBase = new HashSet<new_project_calculation_parametrBase>();
        }

        [Key]
        public Guid new_parameter_project_initiative_evaluationId { get; set; }

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

        public string new_m0106_OptimalCostDescription { get; set; }

        public string new_m0106_RealizationRisksDescription { get; set; }

        public string new_m0107_ConclusionDescription { get; set; }

        public string new_m0107_EvaluationBDZPDZDescription { get; set; }

        public string new_m0108_EBTDescription { get; set; }

        public string new_m0108_GMDescription { get; set; }

        public string new_m0108_ProfitDescription { get; set; }

        public string new_m0108_PaybackPeriodDescription { get; set; }

        public string new_m0108_AgreementPeriodDescription { get; set; }

        public string new_m0105_EvaluationSourceDescription { get; set; }

        public string new_m0105_BudgetCustomerRiskFixDescription { get; set; }

        public Guid? new_RegRate_RatungId { get; set; }

        public Guid? new_CustomerRate_RatingId { get; set; }

        public Guid? new_CostRate_RatingId { get; set; }

        public Guid? new_RiskRate_RatingId { get; set; }

        public Guid? new_BDZPTZRate_RatingId { get; set; }

        public int? new_RatingType { get; set; }

        public Guid? new_project_initiative_valuationId { get; set; }

        public string new_Description { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? new_AccumulateRating { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_initiative_valuationBase> new_project_initiative_valuationBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_calculation_parametrBase> new_project_calculation_parametrBase { get; set; }

        public virtual new_project_initiative_valuationBase new_project_initiative_valuationBase1 { get; set; }

        public virtual new_RatingBase new_RatingBase { get; set; }

        public virtual new_RatingBase new_RatingBase1 { get; set; }

        public virtual new_RatingBase new_RatingBase2 { get; set; }

        public virtual new_RatingBase new_RatingBase3 { get; set; }

        public virtual new_RatingBase new_RatingBase4 { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
