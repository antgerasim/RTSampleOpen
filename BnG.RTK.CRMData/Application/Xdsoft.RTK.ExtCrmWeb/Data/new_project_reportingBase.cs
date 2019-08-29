namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_project_reportingBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public new_project_reportingBase()
        {
            new_Project_deviation_corrective_measureBase = new HashSet<new_Project_deviation_corrective_measureBase>();
        }

        [Key]
        public Guid new_project_reportingId { get; set; }

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

        public int? new_year { get; set; }

        public int? new_month { get; set; }

        public Guid? new_link_businessunit_Id { get; set; }

        public decimal? new_plan_value { get; set; }

        [StringLength(100)]
        public string new_target_value { get; set; }

        public decimal? new_fact_value { get; set; }

        [StringLength(100)]
        public string new_deviation_value { get; set; }

        public Guid? new_link_project_Id { get; set; }

        public Guid? new_link_project_reporting_index_id { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_Project_deviation_corrective_measureBase> new_Project_deviation_corrective_measureBase { get; set; }

        public virtual new_project_reporting_indexBase new_project_reporting_indexBase { get; set; }

        public virtual new_t_projectBase new_t_projectBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
