namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ListMemberBase")]
    public partial class ListMemberBase
    {
        public int EntityType { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid EntityId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid ListId { get; set; }

        [Key]
        public Guid ListMemberId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int? EntityIdTypeCode { get; set; }

        public virtual ListBase ListBase { get; set; }
    }
}
