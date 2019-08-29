namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OfficeGraphDocumentBase")]
    public partial class OfficeGraphDocumentBase
    {
        [StringLength(100)]
        public string ReadUrl { get; set; }

        public Guid? OrganizationId { get; set; }

        public decimal? ExchangeRate { get; set; }

        public int? ViewCount { get; set; }

        [StringLength(2000)]
        public string FileType { get; set; }

        public int? Rank { get; set; }

        [StringLength(2000)]
        public string CreatedBy { get; set; }

        [StringLength(2000)]
        public string FileExtension { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        [StringLength(2000)]
        public string AuthorNames { get; set; }

        [StringLength(200)]
        public string DocumentPreviewMetadata { get; set; }

        [StringLength(2000)]
        public string ModifiedBy { get; set; }

        public DateTime? CreatedTime { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int? QueryType { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public DateTime? DocumentLastModifiedOn { get; set; }

        [StringLength(100)]
        public string DocumentId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [StringLength(2000)]
        public string PreviewImageUrl { get; set; }

        [StringLength(2000)]
        public string WebLocationUrl { get; set; }

        [StringLength(2000)]
        public string SecondaryFileExtension { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Key]
        public Guid OfficeGraphDocumentId { get; set; }

        [StringLength(100)]
        public string DocumentLastModifiedBy { get; set; }

        [StringLength(100)]
        public string SiteUrl { get; set; }

        [StringLength(100)]
        public string SiteTitle { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        public DateTime? ModifiedTime { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
