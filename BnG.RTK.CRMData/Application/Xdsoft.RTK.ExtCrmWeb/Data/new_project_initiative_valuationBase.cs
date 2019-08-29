namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_project_initiative_valuationBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public new_project_initiative_valuationBase()
        {
            new_new_project_initiative_valuation_systemBase = new HashSet<new_new_project_initiative_valuation_systemBase>();
            new_parameter_project_initiative_evaluationBase1 = new HashSet<new_parameter_project_initiative_evaluationBase>();
            new_project_calculation_parametrBase = new HashSet<new_project_calculation_parametrBase>();
            new_t_project_riskBase = new HashSet<new_t_project_riskBase>();
            new_project_initiativeBase1 = new HashSet<new_project_initiativeBase>();
        }

        [Key]
        public Guid new_project_initiative_valuationId { get; set; }

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

        public Guid? new_link_account_id { get; set; }

        public Guid? new_project_type_id { get; set; }

        public Guid? new_link_deal_type_id { get; set; }

        public Guid? new_link_decision_making_level_id { get; set; }

        public Guid? new_prjct_initv_valuation_approver { get; set; }

        public Guid? new_prjct_initv_valuation_agreeder { get; set; }

        public Guid? new_link_project_initiative_id { get; set; }

        public string new_essential_factors_description { get; set; }

        public string new_AgreederComment { get; set; }

        public string new_ApproverComment { get; set; }

        public bool? new_IsAgreed { get; set; }

        public bool? new_IsApproved { get; set; }

        public Guid? new_parameter_project_initiativeId { get; set; }

        public Guid? new_StageId { get; set; }

        public Guid? new_StepId { get; set; }

        public Guid? new_KeyTask_TaskId { get; set; }

        public DateTime? new_StepDateStart { get; set; }

        public Guid? new_RouteId { get; set; }

        public virtual AccountBase AccountBase { get; set; }

        public virtual ActivityPointerBase ActivityPointerBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual new_d_product_typesBase new_d_product_typesBase { get; set; }

        public virtual new_deal_typeBase new_deal_typeBase { get; set; }

        public virtual new_decision_making_levelBase new_decision_making_levelBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_new_project_initiative_valuation_systemBase> new_new_project_initiative_valuation_systemBase { get; set; }

        public virtual new_parameter_project_initiative_evaluationBase new_parameter_project_initiative_evaluationBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_parameter_project_initiative_evaluationBase> new_parameter_project_initiative_evaluationBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_calculation_parametrBase> new_project_calculation_parametrBase { get; set; }

        public virtual new_project_initiativeBase new_project_initiativeBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_project_riskBase> new_t_project_riskBase { get; set; }

        public virtual new_RouteBase new_RouteBase { get; set; }

        public virtual new_StageBase new_StageBase { get; set; }

        public virtual new_StepBase new_StepBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_initiativeBase> new_project_initiativeBase1 { get; set; }

        public virtual SystemUserBase SystemUserBase { get; set; }

        public virtual SystemUserBase SystemUserBase1 { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
