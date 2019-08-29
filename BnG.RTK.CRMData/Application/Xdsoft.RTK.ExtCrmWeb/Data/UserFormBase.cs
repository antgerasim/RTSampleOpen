namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserFormBase")]
    public partial class UserFormBase
    {
        public DateTime? ModifiedOn { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public Guid OwnerId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int? Type { get; set; }

        public string FormXml { get; set; }

        [Key]
        public Guid UserFormId { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public string Description { get; set; }

        public int? ObjectTypeCode { get; set; }

        public int OwnerIdType { get; set; }

        public bool IsTabletEnabled { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
