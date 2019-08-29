namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SyncAttributeMappingProfileBase")]
    public partial class SyncAttributeMappingProfileBase
    {
        [Key]
        [Column(Order = 0)]
        public Guid SolutionId { get; set; }

        public string Description { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime OverwriteTime { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool IsManaged { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid OrganizationId { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [Key]
        [Column(Order = 5)]
        public Guid SyncAttributeMappingProfileId { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(100)]
        public string Name { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [Key]
        [Column(Order = 7)]
        public Guid SyncAttributeMappingProfileIdUnique { get; set; }
    }
}
