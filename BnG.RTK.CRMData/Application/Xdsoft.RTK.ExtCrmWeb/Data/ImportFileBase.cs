namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImportFileBase")]
    public partial class ImportFileBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ImportFileBase()
        {
            ImportDataBase = new HashSet<ImportDataBase>();
            ImportLogBase = new HashSet<ImportLogBase>();
        }

        [StringLength(256)]
        public string Name { get; set; }

        public bool? IsFirstRowHeader { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int? SuccessCount { get; set; }

        public int? StatusCode { get; set; }

        public string AdditionalHeaderRow { get; set; }

        public int ProcessCode { get; set; }

        public int? ParsedTableColumnsNumber { get; set; }

        [Required]
        public string Content { get; set; }

        public Guid? RecordsOwnerId { get; set; }

        [StringLength(256)]
        public string Source { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        [StringLength(160)]
        public string SourceEntityName { get; set; }

        public int StateCode { get; set; }

        [StringLength(160)]
        public string ParsedTableColumnPrefix { get; set; }

        [StringLength(160)]
        public string ParsedTableName { get; set; }

        public int? ProgressCounter { get; set; }

        public bool? EnableDuplicateDetection { get; set; }

        public Guid ImportId { get; set; }

        public int? FailureCount { get; set; }

        public int? FieldDelimiterCode { get; set; }

        [StringLength(160)]
        public string TargetEntityName { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public string HeaderRow { get; set; }

        public DateTime? CompletedOn { get; set; }

        public int? DataDelimiterCode { get; set; }

        public int? TotalCount { get; set; }

        public int ProcessingStatus { get; set; }

        [Key]
        public Guid ImportFileId { get; set; }

        [StringLength(160)]
        public string Size { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? ImportMapId { get; set; }

        public bool? UseSystemMap { get; set; }

        public DateTime ModifiedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid OwnerId { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int FileTypeCode { get; set; }

        public string RelatedEntityColumns { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int? PartialFailureCount { get; set; }

        [StringLength(4000)]
        public string RecordsOwnerIdName { get; set; }

        public int OwnerIdType { get; set; }

        public int RecordsOwnerIdType { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual ImportBase ImportBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportDataBase> ImportDataBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportLogBase> ImportLogBase { get; set; }

        public virtual ImportMapBase ImportMapBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
