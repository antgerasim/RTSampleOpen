namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MobileOfflineProfileItemAssociationBase")]
    public partial class MobileOfflineProfileItemAssociationBase
    {
        [StringLength(200)]
        public string Name { get; set; }

        public Guid? CreatedBy { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? StageId { get; set; }

        [Key]
        [Column(Order = 0)]
        public DateTime OverwriteTime { get; set; }

        public bool IsManaged { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        [StringLength(1250)]
        public string TraversedPath { get; set; }

        public Guid MobileOfflineProfileItemAssociationIdUnique { get; set; }

        public Guid? MobileOfflineProfileItemId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public bool IsValidated { get; set; }

        public string RelationshipData { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid SolutionId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [StringLength(48)]
        public string IntroducedVersion { get; set; }

        public Guid? ModifiedBy { get; set; }

        [StringLength(200)]
        public string RelationshipDisplayName { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid RelationshipId { get; set; }

        public DateTime? PublishedOn { get; set; }

        public Guid? ProcessId { get; set; }

        public int? SelectedRelationShipsSchema { get; set; }

        public Guid OrganizationId { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid MobileOfflineProfileItemAssociationId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public string ProfileItemAssociationEntityFilter { get; set; }

        [StringLength(200)]
        public string RelationshipName { get; set; }
    }
}
