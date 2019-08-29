namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RatingValueBase")]
    public partial class RatingValueBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RatingValueBase()
        {
            BookableResourceCharacteristicBase = new HashSet<BookableResourceCharacteristicBase>();
        }

        public Guid OwnerId { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int? StatusCode { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int? Value { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public decimal? ExchangeRate { get; set; }

        [Key]
        public Guid RatingValueId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public Guid? RatingModel { get; set; }

        public Guid? CreatedBy { get; set; }

        public int StateCode { get; set; }

        public int OwnerIdType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookableResourceCharacteristicBase> BookableResourceCharacteristicBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        public virtual RatingModelBase RatingModelBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
