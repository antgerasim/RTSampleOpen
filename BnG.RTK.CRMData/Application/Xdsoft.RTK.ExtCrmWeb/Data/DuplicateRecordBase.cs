namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DuplicateRecordBase")]
    public partial class DuplicateRecordBase
    {
        public Guid? DuplicateRuleId { get; set; }

        public Guid? BaseRecordId { get; set; }

        public DateTime CreatedOn { get; set; }

        [Key]
        public Guid DuplicateId { get; set; }

        public Guid? AsyncOperationId { get; set; }

        public Guid? DuplicateRecordId { get; set; }

        public int? BaseRecordIdTypeCode { get; set; }

        [StringLength(4000)]
        public string BaseRecordIdName { get; set; }

        [StringLength(4000)]
        public string DuplicateRecordIdName { get; set; }

        [StringLength(4000)]
        public string DuplicateRecordIdYomiName { get; set; }

        [StringLength(4000)]
        public string BaseRecordIdYomiName { get; set; }

        public int? DuplicateRecordIdTypeCode { get; set; }

        public virtual DuplicateRuleBase DuplicateRuleBase { get; set; }
    }
}
