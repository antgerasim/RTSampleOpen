namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LeadCompetitors
    {
        public Guid LeadId { get; set; }

        public Guid CompetitorId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Key]
        public Guid LeadCompetitorId { get; set; }

        public virtual CompetitorBase CompetitorBase { get; set; }

        public virtual LeadBase LeadBase { get; set; }
    }
}
