namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DuplicateRuleConditionBase")]
    public partial class DuplicateRuleConditionBase
    {
        public Guid? CreatedBy { get; set; }

        public int? OperatorParam { get; set; }

        public int? OperatorCode { get; set; }

        public DateTime ModifiedOn { get; set; }

        [Required]
        [StringLength(50)]
        public string BaseAttributeName { get; set; }

        public Guid? RegardingObjectId { get; set; }

        [Key]
        public Guid DuplicateRuleConditionId { get; set; }

        [StringLength(50)]
        public string MatchingAttributeName { get; set; }

        public DateTime CreatedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public bool? IgnoreBlankValues { get; set; }
    }
}
