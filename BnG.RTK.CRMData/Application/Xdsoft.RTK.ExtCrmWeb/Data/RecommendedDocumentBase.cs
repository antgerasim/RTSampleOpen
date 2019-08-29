namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecommendedDocumentBase")]
    public partial class RecommendedDocumentBase
    {
        public int? UTCConversionTimeZoneCode { get; set; }

        [StringLength(200)]
        public string FileType { get; set; }

        public Guid? ModifiedBy { get; set; }

        [StringLength(200)]
        public string Location { get; set; }

        [Key]
        public Guid RecommendedDocumentId { get; set; }

        [StringLength(160)]
        public string FullName { get; set; }

        [StringLength(200)]
        public string ReadUrl { get; set; }

        [StringLength(200)]
        public string AbsoluteUrl { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? RegardingObjectId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(160)]
        public string AssociatedRecordName { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(160)]
        public string Title { get; set; }

        [StringLength(200)]
        public string ContentType { get; set; }

        [StringLength(200)]
        public string EditUrl { get; set; }

        [StringLength(256)]
        public string Author { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        [StringLength(160)]
        public string IconClassName { get; set; }

        public Guid? OrganizationId { get; set; }

        [StringLength(200)]
        public string Version { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int? FileSize { get; set; }

        [StringLength(100)]
        public string ExternalDocumentId { get; set; }

        [StringLength(256)]
        public string Source { get; set; }

        public decimal? ExchangeRate { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? CreatedBy { get; set; }

        [StringLength(256)]
        public string ExternalModifiedBy { get; set; }

        [StringLength(4000)]
        public string RegardingObjectIdName { get; set; }

        public int? RegardingObjectTypeCode { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
