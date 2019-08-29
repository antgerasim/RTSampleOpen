namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MetricBase")]
    public partial class MetricBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MetricBase()
        {
            GoalBase = new HashSet<GoalBase>();
            RollupFieldBase = new HashSet<RollupFieldBase>();
        }

        public int? UTCConversionTimeZoneCode { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public DateTime? CreatedOn { get; set; }

        public bool? IsAmount { get; set; }

        public Guid? ModifiedBy { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Key]
        public Guid MetricId { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? AmountDataType { get; set; }

        public bool? IsStretchTracked { get; set; }

        public int StateCode { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public Guid? OrganizationId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int? StatusCode { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoalBase> GoalBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RollupFieldBase> RollupFieldBase { get; set; }
    }
}
