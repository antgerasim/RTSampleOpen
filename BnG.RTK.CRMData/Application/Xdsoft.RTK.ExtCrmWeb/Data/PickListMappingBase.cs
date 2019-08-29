namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PickListMappingBase")]
    public partial class PickListMappingBase
    {
        public int StatusCode { get; set; }

        [Key]
        public Guid PickListMappingId { get; set; }

        public DateTime ModifiedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int? TargetValue { get; set; }

        public int ProcessCode { get; set; }

        public Guid? ColumnMappingId { get; set; }

        public string SourceValue { get; set; }

        public DateTime CreatedOn { get; set; }

        public int StateCode { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public virtual ColumnMappingBase ColumnMappingBase { get; set; }
    }
}
