namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BulkDeleteFailureBase")]
    public partial class BulkDeleteFailureBase
    {
        [StringLength(512)]
        public string ErrorDescription { get; set; }

        public Guid? AsyncOperationId { get; set; }

        [Key]
        public Guid BulkDeleteFailureId { get; set; }

        public Guid? RegardingObjectId { get; set; }

        public int? ErrorNumber { get; set; }

        public int? OrderedQueryIndex { get; set; }

        public Guid? BulkDeleteOperationId { get; set; }

        [StringLength(4000)]
        public string RegardingObjectIdYomiName { get; set; }

        public int? RegardingObjectTypeCode { get; set; }

        [StringLength(4000)]
        public string RegardingObjectIdName { get; set; }

        public virtual BulkDeleteOperationBase BulkDeleteOperationBase { get; set; }
    }
}
