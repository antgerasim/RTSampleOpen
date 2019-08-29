namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImportBase")]
    public partial class ImportBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ImportBase()
        {
            ImportFileBase = new HashSet<ImportFileBase>();
        }

        public bool SendNotification { get; set; }

        public bool IsImport { get; set; }

        public int ModeCode { get; set; }

        public int StateCode { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        [Key]
        public Guid ImportId { get; set; }

        [StringLength(100)]
        public string EMailAddress { get; set; }

        public Guid? CreatedBy { get; set; }

        [StringLength(256)]
        public string Name { get; set; }

        public DateTime CreatedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int Sequence { get; set; }

        public DateTime ModifiedOn { get; set; }

        public int StatusCode { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid OwnerId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int OwnerIdType { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportFileBase> ImportFileBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
