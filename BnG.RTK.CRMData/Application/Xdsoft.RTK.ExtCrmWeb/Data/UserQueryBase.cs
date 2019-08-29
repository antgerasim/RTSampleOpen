namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserQueryBase")]
    public partial class UserQueryBase
    {
        public int QueryType { get; set; }

        public DateTime ModifiedOn { get; set; }

        public Guid ModifiedBy { get; set; }

        public int? StatusCode { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public string FetchXml { get; set; }

        public string Description { get; set; }

        public string ColumnSetXml { get; set; }

        public int StateCode { get; set; }

        [Key]
        public Guid UserQueryId { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public Guid CreatedBy { get; set; }

        public int ReturnedTypeCode { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public string LayoutXml { get; set; }

        public DateTime CreatedOn { get; set; }

        [StringLength(160)]
        public string AdvancedGroupBy { get; set; }

        public string ConditionalFormatting { get; set; }

        public Guid OwnerId { get; set; }

        public Guid? ParentQueryId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int OwnerIdType { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
