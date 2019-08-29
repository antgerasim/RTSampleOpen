namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MobileOfflineProfileItemBase")]
    public partial class MobileOfflineProfileItemBase
    {
        [StringLength(48)]
        public string IntroducedVersion { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public DateTime? CreatedOn { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid MobileOfflineProfileItemId { get; set; }

        public Guid? CreatedBy { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public bool? GetRelatedEntityRecords { get; set; }

        [StringLength(1250)]
        public string TraversedPath { get; set; }

        public Guid? ProcessId { get; set; }

        public bool IsManaged { get; set; }

        public Guid? RegardingObjectId { get; set; }

        public DateTime? PublishedOn { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid SolutionId { get; set; }

        public Guid? StageId { get; set; }

        public int? SelectedEntityTypeCode { get; set; }

        public Guid? ModifiedBy { get; set; }

        public bool? CanBeFollowed { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsVisibleInGrid { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public Guid? ProfileItemRule { get; set; }

        public string ViewQuery { get; set; }

        public Guid MobileOfflineProfileItemIdUnique { get; set; }

        public Guid OrganizationId { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime OverwriteTime { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public bool IsValidated { get; set; }

        public bool? RecordsOwnedByMe { get; set; }

        public bool? RecordsOwnedByMyTeam { get; set; }

        public int? RecordDistributionCriteria { get; set; }

        public string RelationshipData { get; set; }

        public bool? RecordsOwnedByMyBusinessUnit { get; set; }

        public string SelectedEntityMetadata { get; set; }

        public int? EntityObjectTypeCode { get; set; }

        public string ProfileItemEntityFilter { get; set; }
    }
}
