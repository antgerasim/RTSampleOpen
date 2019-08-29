namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransformationMappingBase")]
    public partial class TransformationMappingBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransformationMappingBase()
        {
            TransformationParameterMappingBase = new HashSet<TransformationParameterMappingBase>();
        }

        public Guid? ImportMapId { get; set; }

        [StringLength(256)]
        public string TransformationTypeName { get; set; }

        public int ProcessCode { get; set; }

        [StringLength(160)]
        public string SourceEntityName { get; set; }

        public int StatusCode { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        [Key]
        public Guid TransformationMappingId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int StateCode { get; set; }

        [StringLength(160)]
        public string TargetEntityName { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public virtual ImportMapBase ImportMapBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransformationParameterMappingBase> TransformationParameterMappingBase { get; set; }
    }
}
