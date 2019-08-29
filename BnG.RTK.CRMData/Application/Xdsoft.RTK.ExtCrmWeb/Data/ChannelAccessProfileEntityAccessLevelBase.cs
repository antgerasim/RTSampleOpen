namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChannelAccessProfileEntityAccessLevelBase")]
    public partial class ChannelAccessProfileEntityAccessLevelBase
    {
        public Guid ChannelAccessProfileEntityAccessLevelIdUnique { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid ChannelAccessProfileEntityAccessLevelId { get; set; }

        public Guid EntityAccessLevelId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public bool IsManaged { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime OverwriteTime { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid SolutionId { get; set; }

        public int EntityAccessLevelDepthMask { get; set; }

        public Guid ChannelAccessProfileId { get; set; }
    }
}
