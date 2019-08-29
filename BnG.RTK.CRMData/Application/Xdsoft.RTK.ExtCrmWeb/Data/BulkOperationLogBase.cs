namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BulkOperationLogBase")]
    public partial class BulkOperationLogBase
    {
        public Guid? RegardingObjectId { get; set; }

        public int? ErrorNumber { get; set; }

        public Guid? CreatedObjectId { get; set; }

        [Key]
        public Guid BulkOperationLogId { get; set; }

        public Guid BulkOperationId { get; set; }

        public string AdditionalInfo { get; set; }

        public int? RegardingObjectIdTypeCode { get; set; }

        public int? CreatedObjectIdTypeCode { get; set; }

        public virtual ActivityPointerBase ActivityPointerBase { get; set; }
    }
}
