namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReportBase")]
    public partial class ReportBase
    {
        public string DefaultFilter { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        [Required]
        [StringLength(425)]
        public string Name { get; set; }

        public bool IsCustomReport { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int? SignatureMajorVersion { get; set; }

        public Guid? CreatedBy { get; set; }

        public string BodyText { get; set; }

        public Guid? ModifiedBy { get; set; }

        public bool IsPersonal { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int? SignatureLcid { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? FileSize { get; set; }

        public string CustomReportXml { get; set; }

        [StringLength(256)]
        public string Description { get; set; }

        public string ScheduleXml { get; set; }

        public DateTime? SignatureDate { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        [StringLength(255)]
        public string FileName { get; set; }

        public Guid? ParentReportId { get; set; }

        public string BodyBinary { get; set; }

        public string QueryInfo { get; set; }

        public int? LanguageCode { get; set; }

        public Guid? SignatureId { get; set; }

        [StringLength(200)]
        public string BodyUrl { get; set; }

        [StringLength(256)]
        public string MimeType { get; set; }

        public int? SignatureMinorVersion { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid ReportId { get; set; }

        public bool IsScheduledReport { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int? ReportTypeCode { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime OverwriteTime { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public Guid ReportIdUnique { get; set; }

        public string OriginalBodyText { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        [StringLength(425)]
        public string ReportNameOnSRS { get; set; }

        public bool IsCustomizable { get; set; }

        public bool IsManaged { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid SolutionId { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid OwnerId { get; set; }

        public int OwnerIdType { get; set; }

        [StringLength(48)]
        public string IntroducedVersion { get; set; }

        public int? CreatedInMajorVersion { get; set; }
    }
}
