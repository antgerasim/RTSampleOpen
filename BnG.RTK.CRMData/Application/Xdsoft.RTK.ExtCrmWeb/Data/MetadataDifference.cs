namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MetadataDifference")]
    public partial class MetadataDifference
    {
        public DateTime? CreatedOn { get; set; }

        [StringLength(48)]
        public string IntroducedVersionString { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid MetadataDifferenceId { get; set; }

        [Required]
        public string DifferenceXml { get; set; }

        public Guid SolutionId { get; set; }

        public double IntroducedVersion { get; set; }
    }
}
