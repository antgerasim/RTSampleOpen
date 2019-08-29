namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DependencyFeatureBase")]
    public partial class DependencyFeatureBase
    {
        [StringLength(48)]
        public string IntroducedVersion { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool IsManaged { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid SolutionId { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid DependencyFeatureIdUnique { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid DependencyFeatureId { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime OverwriteTime { get; set; }
    }
}
