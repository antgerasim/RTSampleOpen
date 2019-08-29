namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DuplicateRuleBase")]
    public partial class DuplicateRuleBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DuplicateRuleBase()
        {
            DuplicateRecordBase = new HashSet<DuplicateRecordBase>();
        }

        public string Description { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public bool? IsCaseSensitive { get; set; }

        public int StateCode { get; set; }

        public int StatusCode { get; set; }

        [Required]
        [StringLength(160)]
        public string Name { get; set; }

        [StringLength(50)]
        public string MatchingEntityMatchCodeTable { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int BaseEntityTypeCode { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        [Key]
        public Guid DuplicateRuleId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int MatchingEntityTypeCode { get; set; }

        [StringLength(50)]
        public string BaseEntityMatchCodeTable { get; set; }

        [StringLength(160)]
        public string BaseEntityName { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(160)]
        public string MatchingEntityName { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid OwnerId { get; set; }

        public int OwnerIdType { get; set; }

        public bool? ExcludeInactiveRecords { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DuplicateRecordBase> DuplicateRecordBase { get; set; }
    }
}
