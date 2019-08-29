namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DynamicPropertyInstanceBase")]
    public partial class DynamicPropertyInstanceBase
    {
        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? RegardingObjectId { get; set; }

        public int? ValueInteger { get; set; }

        [StringLength(1024)]
        public string ValueString { get; set; }

        public decimal? ValueDecimal { get; set; }

        public decimal? ExchangeRate { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid OwnerId { get; set; }

        public bool? validationstatus { get; set; }

        public DateTime? CreatedOn { get; set; }

        public double? ValueDouble { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [Key]
        public Guid DynamicPropertyInstanceid { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public Guid DynamicPropertyId { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        [StringLength(4000)]
        public string RegardingObjectIdName { get; set; }

        public int? RegardingObjectIdType { get; set; }

        public int OwnerIdType { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
