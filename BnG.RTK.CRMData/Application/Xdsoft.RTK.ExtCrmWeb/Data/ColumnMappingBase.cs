namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ColumnMappingBase")]
    public partial class ColumnMappingBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ColumnMappingBase()
        {
            LookUpMappingBase = new HashSet<LookUpMappingBase>();
            PickListMappingBase = new HashSet<PickListMappingBase>();
        }

        [Key]
        public Guid ColumnMappingId { get; set; }

        public Guid? CreatedBy { get; set; }

        [StringLength(160)]
        public string TargetEntityName { get; set; }

        public int StatusCode { get; set; }

        public int ProcessCode { get; set; }

        public DateTime ModifiedOn { get; set; }

        [StringLength(160)]
        public string TargetAttributeName { get; set; }

        public DateTime CreatedOn { get; set; }

        public Guid? ImportMapId { get; set; }

        [StringLength(160)]
        public string SourceAttributeName { get; set; }

        [StringLength(160)]
        public string SourceEntityName { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int StateCode { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public virtual ImportMapBase ImportMapBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LookUpMappingBase> LookUpMappingBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PickListMappingBase> PickListMappingBase { get; set; }
    }
}
