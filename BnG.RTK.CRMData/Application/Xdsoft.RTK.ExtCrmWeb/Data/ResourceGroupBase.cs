namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ResourceGroupBase")]
    public partial class ResourceGroupBase
    {
        [StringLength(160)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ObjectTypeCode { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ResourceGroupId { get; set; }

        public int? GroupTypeCode { get; set; }

        public Guid? BusinessUnitId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid OrganizationId { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }
    }
}
