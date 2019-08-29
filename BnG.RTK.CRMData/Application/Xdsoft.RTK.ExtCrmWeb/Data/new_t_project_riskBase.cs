namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_t_project_riskBase
    {
        [Key]
        public Guid new_t_project_riskId { get; set; }

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

        [StringLength(400)]
        public string new_name { get; set; }

        public int? new_decision_lvl { get; set; }

        public DateTime? new_dt_detection { get; set; }

        public string new_comment { get; set; }

        public Guid? new_link_project_risk { get; set; }

        public int? new_risk_status { get; set; }

        public int? new_assessment_probability_risk { get; set; }

        public int? new_assessment_influence_risk { get; set; }

        public int? new_response_measure { get; set; }

        public Guid? new_link_project_initiative_Id { get; set; }

        public Guid? new_activity_Id { get; set; }

        public decimal? new_cost_object_of_influence { get; set; }

        public decimal? new_expected_cost_of_loss { get; set; }

        public Guid? new_link_project_initiative_valuat_id { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual new_project_initiative_valuationBase new_project_initiative_valuationBase { get; set; }

        public virtual new_project_initiativeBase new_project_initiativeBase { get; set; }

        public virtual new_t_activityBase new_t_activityBase { get; set; }

        public virtual new_t_projectBase new_t_projectBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
