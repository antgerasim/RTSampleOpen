namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_project_project_reporting_indexBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public new_project_project_reporting_indexBase()
        {
            new_project_reporting_index_plan_factBase = new HashSet<new_project_reporting_index_plan_factBase>();
        }

        [Key]
        public Guid new_project_project_reporting_indexId { get; set; }

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

        public Guid? new_link_project_reporting_index_id { get; set; }

        public Guid? new_link_project_id { get; set; }

        public string new_comment { get; set; }

        public int? new_significance_sign { get; set; }

        public decimal? new_fact_value { get; set; }

        public decimal? new_plan_value { get; set; }

        [StringLength(100)]
        public string new_project_object { get; set; }

        public DateTime? new_reporting_period { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? new_complete_sign { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? new_project_index_success_sign { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_reporting_index_plan_factBase> new_project_reporting_index_plan_factBase { get; set; }

        public virtual new_project_reporting_indexBase new_project_reporting_indexBase { get; set; }

        public virtual new_t_projectBase new_t_projectBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
