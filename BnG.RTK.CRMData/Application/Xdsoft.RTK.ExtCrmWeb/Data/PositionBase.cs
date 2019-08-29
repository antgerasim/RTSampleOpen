namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PositionBase")]
    public partial class PositionBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PositionBase()
        {
            PositionBase1 = new HashSet<PositionBase>();
            SystemUserBase = new HashSet<SystemUserBase>();
        }

        public Guid? CreatedBy { get; set; }

        public Guid? ParentPositionId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public int statecode { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int? StatusCode { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public decimal? ExchangeRate { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public Guid? OrganizationId { get; set; }

        public Guid? ModifiedBy { get; set; }

        [Key]
        public Guid PositionId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PositionBase> PositionBase1 { get; set; }

        public virtual PositionBase PositionBase2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SystemUserBase> SystemUserBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
