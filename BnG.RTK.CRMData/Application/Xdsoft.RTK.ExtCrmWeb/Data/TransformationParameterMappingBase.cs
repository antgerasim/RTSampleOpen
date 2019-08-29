namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransformationParameterMappingBase")]
    public partial class TransformationParameterMappingBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransformationParameterMappingBase()
        {
            LookUpMappingBase = new HashSet<LookUpMappingBase>();
        }

        public int? ParameterArrayIndex { get; set; }

        public int? ParameterTypeCode { get; set; }

        [Key]
        public Guid TransformationParameterMappingId { get; set; }

        public Guid? TransformationMappingId { get; set; }

        public DateTime CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public int? DataTypeCode { get; set; }

        [StringLength(500)]
        public string Data { get; set; }

        public DateTime ModifiedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int? ParameterSequence { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LookUpMappingBase> LookUpMappingBase { get; set; }

        public virtual TransformationMappingBase TransformationMappingBase { get; set; }
    }
}
