namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_successful_project_historyBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public new_successful_project_historyBase()
        {
            new_successful_project_history_productBase = new HashSet<new_successful_project_history_productBase>();
        }

        [Key]
        public Guid new_successful_project_historyId { get; set; }

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

        [StringLength(500)]
        public string new_name { get; set; }

        public string new_problem { get; set; }

        public string new_result { get; set; }

        public string new_project_description { get; set; }

        public Guid? new_link_project_id { get; set; }

        public Guid? new_link_territory_id { get; set; }

        public Guid? new_link_sphere_of_activity_id { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual new_d_sphere_of_activityBase new_d_sphere_of_activityBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_successful_project_history_productBase> new_successful_project_history_productBase { get; set; }

        public virtual new_t_projectBase new_t_projectBase { get; set; }

        public virtual new_territoryBase new_territoryBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
