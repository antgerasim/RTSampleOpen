namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PostLikeBase")]
    public partial class PostLikeBase
    {
        public Guid OrganizationId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid PostId { get; set; }

        [Key]
        public Guid PostLikeId { get; set; }

        public virtual PostBase PostBase { get; set; }
    }
}
