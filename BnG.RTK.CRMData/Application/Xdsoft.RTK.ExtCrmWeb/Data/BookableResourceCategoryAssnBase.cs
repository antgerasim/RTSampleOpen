namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookableResourceCategoryAssnBase")]
    public partial class BookableResourceCategoryAssnBase
    {
        public int? ImportSequenceNumber { get; set; }

        public Guid? ResourceCategory { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? Resource { get; set; }

        [Key]
        public Guid BookableResourceCategoryAssnId { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public int StateCode { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public decimal? ExchangeRate { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid OwnerId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int? StatusCode { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int OwnerIdType { get; set; }

        public virtual BookableResourceBase BookableResourceBase { get; set; }

        public virtual BookableResourceCategoryBase BookableResourceCategoryBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
