namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BusinessUnitNewsArticleBase")]
    public partial class BusinessUnitNewsArticleBase
    {
        public Guid OrganizationId { get; set; }

        [Key]
        public Guid BusinessUnitNewsArticleId { get; set; }

        public DateTime? ActiveOn { get; set; }

        public DateTime? ActiveUntil { get; set; }

        public string NewsArticle { get; set; }

        public int? ArticleTypeCode { get; set; }

        public bool? ShowOnHomepage { get; set; }

        [StringLength(300)]
        public string ArticleTitle { get; set; }

        [StringLength(200)]
        public string ArticleUrl { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }
    }
}
