namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MailboxTrackingFolderBase")]
    public partial class MailboxTrackingFolderBase
    {
        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [StringLength(160)]
        public string ExchangeFolderId { get; set; }

        [StringLength(256)]
        public string ExchangeFolderName { get; set; }

        public Guid MailboxId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public Guid OwnerId { get; set; }

        public Guid OrganizationId { get; set; }

        public int FolderOnboardingStatus { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Key]
        public Guid MailboxTrackingFolderId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? RegardingObjectId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int OwnerIdType { get; set; }

        public int? RegardingObjectTypeCode { get; set; }

        [StringLength(4000)]
        public string RegardingObjectIdName { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
