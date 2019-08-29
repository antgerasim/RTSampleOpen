namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SharePointDocumentBase")]
    public partial class SharePointDocumentBase
    {
        [StringLength(200)]
        public string CopySource { get; set; }

        [StringLength(200)]
        public string AbsoluteUrl { get; set; }

        [StringLength(2000)]
        public string Author { get; set; }

        [StringLength(200)]
        public string Edit { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        [StringLength(200)]
        public string Version { get; set; }

        public Guid OwnerId { get; set; }

        public DateTime? SharePointCreatedOn { get; set; }

        [StringLength(200)]
        public string CheckInComment { get; set; }

        [StringLength(200)]
        public string EditUrl { get; set; }

        [StringLength(200)]
        public string ContentType { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        [StringLength(200)]
        public string AppCreatedBy { get; set; }

        public int? ContentTypeId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [StringLength(200)]
        public string CheckedOutTo { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public bool? IsCheckedOut { get; set; }

        public int? DocumentId { get; set; }

        public Guid OrganizationId { get; set; }

        public int? ChildFolderCount { get; set; }

        [StringLength(2000)]
        public string LocationId { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(200)]
        public string FileType { get; set; }

        [StringLength(200)]
        public string AppModifiedBy { get; set; }

        public decimal? ExchangeRate { get; set; }

        [StringLength(200)]
        public string ReadUrl { get; set; }

        public Guid? CreatedBy { get; set; }

        public int? ChildItemCount { get; set; }

        [Key]
        public Guid SharePointDocumentId { get; set; }

        public DateTime? Modified { get; set; }

        [StringLength(160)]
        public string FullName { get; set; }

        [StringLength(200)]
        public string SharePointModifiedBy { get; set; }

        public Guid? BusinessUnitId { get; set; }

        public bool? IsFolder { get; set; }

        [StringLength(2000)]
        public string Title { get; set; }

        public int? FileSize { get; set; }

        public Guid? RegardingObjectId { get; set; }

        [StringLength(200)]
        public string RelativeLocation { get; set; }

        [StringLength(4000)]
        public string RegardingObjectIdName { get; set; }

        public int OwnerIdType { get; set; }

        public int? RegardingObjectTypeCode { get; set; }

        [StringLength(4000)]
        public string RegardingObjectIdYomiName { get; set; }

        public int? ServiceType { get; set; }

        [StringLength(160)]
        public string IconClassName { get; set; }

        public int? DocumentLocationType { get; set; }

        public bool? IsRecursiveFetch { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase1 { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
