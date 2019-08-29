namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LookUpMappingBase")]
    public partial class LookUpMappingBase
    {
        [StringLength(160)]
        public string LookUpEntityName { get; set; }

        public Guid? CreatedBy { get; set; }

        public int LookUpSourceCode { get; set; }

        public Guid? ColumnMappingId { get; set; }

        public DateTime ModifiedOn { get; set; }

        [Key]
        public Guid LookUpMappingId { get; set; }

        public Guid? TransformationParameterMappingId { get; set; }

        public int ProcessCode { get; set; }

        public int StatusCode { get; set; }

        public int StateCode { get; set; }

        public DateTime CreatedOn { get; set; }

        [StringLength(160)]
        public string LookUpAttributeName { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public virtual ColumnMappingBase ColumnMappingBase { get; set; }

        public virtual TransformationParameterMappingBase TransformationParameterMappingBase { get; set; }
    }
}
