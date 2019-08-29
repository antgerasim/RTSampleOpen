namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookableResourceGroupBase")]
    public partial class BookableResourceGroupBase
    {
        public int? TimeZoneRuleVersionNumber { get; set; }

        public Guid? ParentResource { get; set; }

        public DateTime? ToDate { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        [Key]
        public Guid BookableResourceGroupId { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public decimal? ExchangeRate { get; set; }

        public int StateCode { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int? StatusCode { get; set; }

        public Guid? ChildResource { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public DateTime? FromDate { get; set; }

        public Guid OwnerId { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public int OwnerIdType { get; set; }

        public virtual BookableResourceBase BookableResourceBase { get; set; }

        public virtual BookableResourceBase BookableResourceBase1 { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
