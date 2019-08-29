namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SharePointDocumentLocationBase")]
    public partial class SharePointDocumentLocationBase
    {
        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int StateCode { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public string Description { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        [StringLength(255)]
        public string RelativeUrl { get; set; }

        [StringLength(2000)]
        public string AbsoluteURL { get; set; }

        [Required]
        [StringLength(160)]
        public string Name { get; set; }

        public Guid? CreatedBy { get; set; }

        public int? StatusCode { get; set; }

        public Guid OwnerId { get; set; }

        public Guid? RegardingObjectId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? SiteCollectionId { get; set; }

        [Key]
        public Guid SharePointDocumentLocationId { get; set; }

        public Guid? ParentSiteOrLocation { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public decimal? ExchangeRate { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        [StringLength(4000)]
        public string ParentSiteOrLocationName { get; set; }

        public int? ParentSiteOrLocationTypeCode { get; set; }

        public int OwnerIdType { get; set; }

        public int? RegardingObjectTypeCode { get; set; }

        [StringLength(4000)]
        public string RegardingObjectIdName { get; set; }

        [StringLength(4000)]
        public string RegardingObjectIdYomiName { get; set; }

        public int ServiceType { get; set; }

        public Guid? UserId { get; set; }

        public int? LocationType { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
