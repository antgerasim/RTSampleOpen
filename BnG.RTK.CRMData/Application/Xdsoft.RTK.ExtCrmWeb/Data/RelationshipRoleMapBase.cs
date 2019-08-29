namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RelationshipRoleMapBase")]
    public partial class RelationshipRoleMapBase
    {
        public DateTime? ModifiedOn { get; set; }

        public DateTime? CreatedOn { get; set; }

        [Key]
        public Guid RelationshipRoleMapId { get; set; }

        public Guid? CreatedBy { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int AssociateObjectTypeCode { get; set; }

        public Guid RelationshipRoleId { get; set; }

        public int PrimaryObjectTypeCode { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public virtual RelationshipRoleBase RelationshipRoleBase { get; set; }
    }
}
