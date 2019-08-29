namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PostCommentBase")]
    public partial class PostCommentBase
    {
        public Guid? CreatedBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [StringLength(1000)]
        public string Text { get; set; }

        public Guid OrganizationId { get; set; }

        public DateTime CreatedOn { get; set; }

        [Key]
        public Guid PostCommentId { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public Guid PostId { get; set; }

        public virtual PostBase PostBase { get; set; }
    }
}
