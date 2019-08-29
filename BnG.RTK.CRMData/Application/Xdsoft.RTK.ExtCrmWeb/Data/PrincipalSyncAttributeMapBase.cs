namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrincipalSyncAttributeMapBase")]
    public partial class PrincipalSyncAttributeMapBase
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string MappingName { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte AllowedSyncDirection { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid PrincipalId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SyncDirection { get; set; }

        [StringLength(100)]
        public string AttributeCRMName { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EntityTypeCode { get; set; }

        [Key]
        [Column(Order = 5)]
        public Guid OrganizationId { get; set; }

        [StringLength(100)]
        public string AttributeExchangeName { get; set; }

        public Guid? ParentPrincipalSyncAttributeMappingId { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DefaultSyncDirection { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool IsComputed { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Key]
        [Column(Order = 8)]
        public Guid PrincipalSyncAttributeMapId { get; set; }

        [StringLength(500)]
        public string ComputedProperties { get; set; }

        [StringLength(100)]
        public string AttributeCRMDisplayName { get; set; }

        [StringLength(100)]
        public string AttributeExchangeDisplayName { get; set; }
    }
}
