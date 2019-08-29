namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImportMapBase")]
    public partial class ImportMapBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ImportMapBase()
        {
            ColumnMappingBase = new HashSet<ColumnMappingBase>();
            ImportEntityMappingBase = new HashSet<ImportEntityMappingBase>();
            ImportFileBase = new HashSet<ImportFileBase>();
            OwnerMappingBase = new HashSet<OwnerMappingBase>();
            TransformationMappingBase = new HashSet<TransformationMappingBase>();
        }

        public int StatusCode { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime ModifiedOn { get; set; }

        public int? TargetEntity { get; set; }

        public int? ImportMapType { get; set; }

        [StringLength(160)]
        public string TargetUserIdentifierForSourceCRMUserLink { get; set; }

        public bool? IsWizardCreated { get; set; }

        public DateTime CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        [Key]
        public Guid ImportMapId { get; set; }

        public string Description { get; set; }

        [StringLength(320)]
        public string Name { get; set; }

        [StringLength(160)]
        public string SourceUserIdentifierForSourceDataSourceUserLink { get; set; }

        [StringLength(160)]
        public string SourceUserIdentifierForSourceCRMUserLink { get; set; }

        public int StateCode { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        [StringLength(160)]
        public string Source { get; set; }

        public bool? IsValidForImport { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid OwnerId { get; set; }

        public int? SourceType { get; set; }

        public string MapCustomizations { get; set; }

        public int EntitiesPerFile { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int OwnerIdType { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ColumnMappingBase> ColumnMappingBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportEntityMappingBase> ImportEntityMappingBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportFileBase> ImportFileBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OwnerMappingBase> OwnerMappingBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransformationMappingBase> TransformationMappingBase { get; set; }
    }
}
