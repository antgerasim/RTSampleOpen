namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_RatingBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public new_RatingBase()
        {
            new_parameter_project_initiative_evaluationBase = new HashSet<new_parameter_project_initiative_evaluationBase>();
            new_parameter_project_initiative_evaluationBase1 = new HashSet<new_parameter_project_initiative_evaluationBase>();
            new_parameter_project_initiative_evaluationBase2 = new HashSet<new_parameter_project_initiative_evaluationBase>();
            new_parameter_project_initiative_evaluationBase3 = new HashSet<new_parameter_project_initiative_evaluationBase>();
            new_parameter_project_initiative_evaluationBase4 = new HashSet<new_parameter_project_initiative_evaluationBase>();
        }

        [Key]
        public Guid new_RatingId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? OrganizationId { get; set; }

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

        public int? new_RatingType { get; set; }

        public int? new_RatingValue { get; set; }

        [StringLength(4000)]
        public string new_Rule { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_parameter_project_initiative_evaluationBase> new_parameter_project_initiative_evaluationBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_parameter_project_initiative_evaluationBase> new_parameter_project_initiative_evaluationBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_parameter_project_initiative_evaluationBase> new_parameter_project_initiative_evaluationBase2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_parameter_project_initiative_evaluationBase> new_parameter_project_initiative_evaluationBase3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_parameter_project_initiative_evaluationBase> new_parameter_project_initiative_evaluationBase4 { get; set; }
    }
}
