namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProcessStageBase")]
    public partial class ProcessStageBase
    {
        public Guid ProcessId { get; set; }

        [Required]
        [StringLength(100)]
        public string StageName { get; set; }

        public int? StageCategory { get; set; }

        [Key]
        public Guid ProcessStageId { get; set; }

        public int PrimaryEntityTypeCode { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public string ClientData { get; set; }
    }
}
