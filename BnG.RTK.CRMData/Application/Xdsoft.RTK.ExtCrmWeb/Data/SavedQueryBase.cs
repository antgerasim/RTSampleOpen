namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SavedQueryBase")]
    public partial class SavedQueryBase
    {
        [Key]
        [Column(Order = 0)]
        public Guid SavedQueryId { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public Guid OrganizationId { get; set; }

        public string Description { get; set; }

        public int QueryType { get; set; }

        public bool IsDefault { get; set; }

        public int ReturnedTypeCode { get; set; }

        public int? QueryAppUsage { get; set; }

        public bool? IsUserDefined { get; set; }

        public string FetchXml { get; set; }

        public bool IsCustomizable { get; set; }

        public bool IsQuickFindQuery { get; set; }

        public string ColumnSetXml { get; set; }

        public string LayoutXml { get; set; }

        [StringLength(100)]
        public string QueryAPI { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public bool IsPrivate { get; set; }

        public Guid SavedQueryIdUnique { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime OverwriteTime { get; set; }

        public bool IsManaged { get; set; }

        [StringLength(160)]
        public string AdvancedGroupBy { get; set; }

        public string ConditionalFormatting { get; set; }

        public bool CanBeDeleted { get; set; }

        public int? StatusCode { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public int? OrganizationTabOrder { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid SolutionId { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int StateCode { get; set; }

        [StringLength(48)]
        public string IntroducedVersion { get; set; }

        public bool IsCustom { get; set; }
    }
}
