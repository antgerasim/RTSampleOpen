namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImportDataBase")]
    public partial class ImportDataBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ImportDataBase()
        {
            ImportLogBase = new HashSet<ImportLogBase>();
        }

        public DateTime CreatedOn { get; set; }

        public int? LineNumber { get; set; }

        public Guid? RecordId { get; set; }

        public string Data { get; set; }

        public DateTime ModifiedOn { get; set; }

        public Guid? ImportFileId { get; set; }

        public Guid? ModifiedBy { get; set; }

        [Key]
        public Guid ImportDataId { get; set; }

        public Guid? CreatedBy { get; set; }

        public int StateCode { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public bool? HasError { get; set; }

        public int StatusCode { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid OwnerId { get; set; }

        public int? ErrorType { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int OwnerIdType { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual ImportFileBase ImportFileBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportLogBase> ImportLogBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
