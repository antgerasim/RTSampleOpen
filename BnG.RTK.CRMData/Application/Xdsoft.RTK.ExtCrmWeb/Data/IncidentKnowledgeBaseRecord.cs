namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IncidentKnowledgeBaseRecord")]
    public partial class IncidentKnowledgeBaseRecord
    {
        public Guid KnowledgeBaseRecordId { get; set; }

        public Guid IncidentId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid IncidentKnowledgeBaseRecordId { get; set; }

        public virtual IncidentBase IncidentBase { get; set; }

        public virtual KnowledgeBaseRecordBase KnowledgeBaseRecordBase { get; set; }
    }
}
