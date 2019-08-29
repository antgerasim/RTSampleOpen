namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChannelPropertyBase")]
    public partial class ChannelPropertyBase
    {
        public int? statuscode { get; set; }

        public bool IsManaged { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? RegardingObjectId { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public int? DataType { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        [StringLength(100)]
        public string Applicationsource { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid ChannelPropertyIdUnique { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int? ImportSequenceNumber { get; set; }

        [StringLength(300)]
        public string Name { get; set; }

        public Guid OrganizationId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid ChannelPropertyId { get; set; }

        public int? statecode { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SolutionId { get; set; }

        public DateTime? CreatedOn { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime OverwriteTime { get; set; }

        public Guid? CreatedBy { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public int? RegardingObjectTypeCode { get; set; }
    }
}
