namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReportEntityBase")]
    public partial class ReportEntityBase
    {
        public DateTime? CreatedOn { get; set; }

        public bool IsFilterable { get; set; }

        public int? ImportSequenceNumber { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid ReportId { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid ReportEntityId { get; set; }

        public int ObjectTypeCode { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime OverwriteTime { get; set; }

        public Guid ReportEntityIdUnique { get; set; }

        public bool IsCustomizable { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public bool IsManaged { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid SolutionId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }
    }
}
