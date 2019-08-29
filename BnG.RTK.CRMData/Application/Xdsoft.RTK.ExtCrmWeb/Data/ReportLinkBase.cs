namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReportLinkBase")]
    public partial class ReportLinkBase
    {
        public DateTime? CreatedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? CreatedBy { get; set; }

        [Key]
        public Guid ReportLinkId { get; set; }

        public int LinkTypeCode { get; set; }

        [Required]
        [StringLength(255)]
        public string LinkedReportName { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid ReportId { get; set; }

        public Guid? LinkedReportId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid ReportLinkIdUnique { get; set; }
    }
}
