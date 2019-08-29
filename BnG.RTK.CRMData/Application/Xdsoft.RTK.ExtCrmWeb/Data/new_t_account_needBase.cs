namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_t_account_needBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public new_t_account_needBase()
        {
            new_new_account_need_new_t_account_needBase = new HashSet<new_new_account_need_new_t_account_needBase>();
        }

        [Key]
        public Guid new_t_account_needId { get; set; }

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
        public string new_code { get; set; }

        public Guid? new_link_account_id { get; set; }

        [StringLength(100)]
        public string new_subject { get; set; }

        public DateTime? new_need_approval_date { get; set; }

        public Guid? new_link_activity_id { get; set; }

        public int? new_account_need_code { get; set; }

        public string new_description1 { get; set; }

        public string new_description2 { get; set; }

        public string new_description3 { get; set; }

        public virtual AccountBase AccountBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_new_account_need_new_t_account_needBase> new_new_account_need_new_t_account_needBase { get; set; }

        public virtual new_t_activityBase new_t_activityBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
