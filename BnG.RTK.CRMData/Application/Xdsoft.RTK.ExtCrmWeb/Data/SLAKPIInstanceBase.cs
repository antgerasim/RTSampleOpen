namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SLAKPIInstanceBase")]
    public partial class SLAKPIInstanceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SLAKPIInstanceBase()
        {
            IncidentBase = new HashSet<IncidentBase>();
            IncidentBase1 = new HashSet<IncidentBase>();
        }

        public DateTime? ModifiedOn { get; set; }

        public decimal? ExchangeRate { get; set; }

        public Guid? CreatedBy { get; set; }

        public string Description { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public DateTime? WarningTime { get; set; }

        public DateTime? FailureTime { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public DateTime? ComputedWarningTime { get; set; }

        public DateTime? SucceededOn { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int? WarningTimeReached { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public Guid? Regarding { get; set; }

        public Guid OwnerId { get; set; }

        public Guid? ModifiedBy { get; set; }

        [Key]
        public Guid SLAKPIInstanceId { get; set; }

        [Required]
        [StringLength(160)]
        public string Name { get; set; }

        public DateTime? ComputedFailureTime { get; set; }

        public int? Status { get; set; }

        public int? RegardingObjectTypeCode { get; set; }

        public int OwnerIdType { get; set; }

        [StringLength(4000)]
        public string RegardingIdName { get; set; }

        [StringLength(4000)]
        public string RegardingYomiName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IncidentBase> IncidentBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IncidentBase> IncidentBase1 { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
