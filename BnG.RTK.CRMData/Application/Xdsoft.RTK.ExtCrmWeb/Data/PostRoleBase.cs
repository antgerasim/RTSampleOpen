namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PostRoleBase")]
    public partial class PostRoleBase
    {
        public Guid OrganizationId { get; set; }

        public Guid RegardingObjectId { get; set; }

        [Key]
        public Guid PostRoleId { get; set; }

        public int? Type { get; set; }

        public Guid PostId { get; set; }

        public int? RegardingObjectTypeCode { get; set; }

        public virtual PostBase PostBase { get; set; }
    }
}
