namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SocialInsightsConfigurationBase")]
    public partial class SocialInsightsConfigurationBase
    {
        public Guid? ModifiedBy { get; set; }

        public Guid OrganizationId { get; set; }

        public string SocialDataParameters { get; set; }

        [StringLength(100)]
        public string ControlId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid FormId { get; set; }

        [StringLength(100)]
        public string SocialDataItemId { get; set; }

        [Key]
        public Guid SocialInsightsConfigurationId { get; set; }

        public Guid? RegardingObjectId { get; set; }

        public Guid? CreatedBy { get; set; }

        public int? SocialDataItemType { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(4000)]
        public string FormIdName { get; set; }

        [StringLength(256)]
        public string RegardingObjectIdName { get; set; }

        public int? RegardingObjectTypeCode { get; set; }

        public int? FormTypeCode { get; set; }

        [StringLength(160)]
        public string RegardingObjectIdYomiName { get; set; }
    }
}
