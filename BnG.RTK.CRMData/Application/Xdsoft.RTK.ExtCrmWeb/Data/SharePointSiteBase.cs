namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SharePointSiteBase")]
    public partial class SharePointSiteBase
    {
        public bool? IsGridPresent { get; set; }

        public Guid? CreatedBy { get; set; }

        [StringLength(2000)]
        public string AbsoluteURL { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public string Description { get; set; }

        public int? FolderStructureEntity { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int? StatusCode { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int? ValidationStatus { get; set; }

        [StringLength(160)]
        public string RelativeUrl { get; set; }

        [Key]
        public Guid SharePointSiteId { get; set; }

        public Guid OwnerId { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public Guid? SiteCollectionId { get; set; }

        public decimal? ExchangeRate { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public bool? IsDefault { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public int StateCode { get; set; }

        public int? ValidationStatusErrorCode { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        [Required]
        [StringLength(160)]
        public string Name { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public DateTime? LastValidated { get; set; }

        public Guid? ParentSite { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int OwnerIdType { get; set; }

        public int? ParentSiteObjectTypeCode { get; set; }

        [StringLength(4000)]
        public string ParentSiteName { get; set; }

        public bool IsPowerBISite { get; set; }

        public int ServiceType { get; set; }

        public Guid? UserId { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
