namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChannelPropertyGroupBase")]
    public partial class ChannelPropertyGroupBase
    {
        public bool IsManaged { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid OrganizationId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid ChannelPropertyGroupId { get; set; }

        public string Description { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime OverwriteTime { get; set; }

        public int? statecode { get; set; }

        public int? RegardingTypeCode { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid ChannelPropertyGroupIdUnique { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid SolutionId { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int? statuscode { get; set; }

        public DateTime? CreatedOn { get; set; }
    }
}
