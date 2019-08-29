namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductSubstituteBase")]
    public partial class ProductSubstituteBase
    {
        public Guid ProductId { get; set; }

        public Guid SubstitutedProductId { get; set; }

        [Key]
        public Guid ProductSubstituteId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public decimal? ExchangeRate { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? statuscode { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int statecode { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int Direction { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public Guid? CreatedBy { get; set; }

        public int SalesRelationshipType { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public virtual ProductBase ProductBase { get; set; }

        public virtual ProductBase ProductBase1 { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
