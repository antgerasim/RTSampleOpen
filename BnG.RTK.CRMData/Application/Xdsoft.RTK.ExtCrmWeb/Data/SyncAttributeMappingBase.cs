namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SyncAttributeMappingBase")]
    public partial class SyncAttributeMappingBase
    {
        [StringLength(100)]
        public string AttributeCRMName { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DefaultSyncDirection { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SolutionId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid SyncAttributeMappingIdUnique { get; set; }

        public Guid? ParentSyncAttributeMappingId { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid SyncAttributeMappingId { get; set; }

        [Key]
        [Column(Order = 5)]
        public Guid SyncAttributeMappingProfileId { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SyncDirection { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(100)]
        public string MappingName { get; set; }

        [Key]
        [Column(Order = 8)]
        public byte AllowedSyncDirection { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool IsManaged { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EntityTypeCode { get; set; }

        [StringLength(500)]
        public string ComputedProperties { get; set; }

        [StringLength(100)]
        public string AttributeExchangeName { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool IsComputed { get; set; }

        [Key]
        [Column(Order = 12)]
        public DateTime OverwriteTime { get; set; }
    }
}
