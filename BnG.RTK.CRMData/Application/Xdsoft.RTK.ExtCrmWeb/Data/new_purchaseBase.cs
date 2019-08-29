namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_purchaseBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public new_purchaseBase()
        {
            new_project_initiativeBase = new HashSet<new_project_initiativeBase>();
        }

        [Key]
        public Guid new_purchaseId { get; set; }

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
        public string new_subject { get; set; }

        [StringLength(100)]
        public string new_notificationNumber { get; set; }

        [StringLength(100)]
        public string new_tradePlatformName { get; set; }

        [StringLength(500)]
        public string new_tradePlatformLink { get; set; }

        [StringLength(100)]
        public string new_status { get; set; }

        [StringLength(100)]
        public string new_account_name { get; set; }

        [StringLength(100)]
        public string new_vendor_definition_method { get; set; }

        public decimal? new_max_contract_price { get; set; }

        public DateTime? new_dt_st_submission_of_application { get; set; }

        public DateTime? new_dt_end_submission_of_application { get; set; }

        [StringLength(100)]
        public string new_AISTenderPurchaseID { get; set; }

        public Guid? new_link_activity_id { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_initiativeBase> new_project_initiativeBase { get; set; }

        public virtual new_t_activityBase new_t_activityBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
