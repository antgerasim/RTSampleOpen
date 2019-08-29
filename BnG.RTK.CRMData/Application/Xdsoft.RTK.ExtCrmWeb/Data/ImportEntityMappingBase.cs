namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImportEntityMappingBase")]
    public partial class ImportEntityMappingBase
    {
        public Guid? ImportMapId { get; set; }

        public int StatusCode { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [Key]
        public Guid ImportEntityMappingId { get; set; }

        public int StateCode { get; set; }

        public DateTime ModifiedOn { get; set; }

        public DateTime CreatedOn { get; set; }

        public int DeDupe { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int ProcessCode { get; set; }

        [StringLength(160)]
        public string TargetEntityName { get; set; }

        public Guid? CreatedBy { get; set; }

        [StringLength(160)]
        public string SourceEntityName { get; set; }

        public virtual ImportMapBase ImportMapBase { get; set; }
    }
}
