namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MailMergeTemplateBase")]
    public partial class MailMergeTemplateBase
    {
        public Guid? ModifiedBy { get; set; }

        public string Body { get; set; }

        public int TemplateTypeCode { get; set; }

        public Guid? CreatedBy { get; set; }

        [StringLength(256)]
        public string Description { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public int? FileSize { get; set; }

        public string ParameterXml { get; set; }

        public int? MailMergeType { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string DefaultFilter { get; set; }

        [StringLength(256)]
        public string MimeType { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int StateCode { get; set; }

        [StringLength(255)]
        public string FileName { get; set; }

        public int? LanguageCode { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int? DocumentFormat { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Required]
        [StringLength(425)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid MailMergeTemplateId { get; set; }

        public bool IsPersonal { get; set; }

        public int? StatusCode { get; set; }

        public bool IsCustomizable { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public decimal? ExchangeRate { get; set; }

        public Guid OwnerId { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public Guid MailMergeTemplateIdUnique { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime OverwriteTime { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid SolutionId { get; set; }

        public bool IsManaged { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int OwnerIdType { get; set; }

        [StringLength(48)]
        public string IntroducedVersion { get; set; }
    }
}
