namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MobileOfflineProfileBase")]
    public partial class MobileOfflineProfileBase
    {
        public DateTime? PublishedOn { get; set; }

        [StringLength(48)]
        public string IntroducedVersion { get; set; }

        public bool IsManaged { get; set; }

        [StringLength(1250)]
        public string TraversedPath { get; set; }

        public string Description { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid SolutionId { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime OverwriteTime { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? StageId { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid MobileOfflineProfileId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public Guid MobileOfflineProfileIdUnique { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? ProcessId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public bool IsValidated { get; set; }

        public string SelectedEntityMetadata { get; set; }
    }
}
