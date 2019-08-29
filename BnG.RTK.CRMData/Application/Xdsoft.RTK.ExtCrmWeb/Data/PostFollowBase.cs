namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PostFollowBase")]
    public partial class PostFollowBase
    {
        public Guid OwnerId { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public int? YammerRetryCount { get; set; }

        public bool? PostToYammer { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [Key]
        public Guid PostFollowId { get; set; }

        public Guid RegardingObjectId { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public int? YammerPostState { get; set; }

        public int OwnerIdType { get; set; }

        [StringLength(4000)]
        public string RegardingObjectIdName { get; set; }

        public int? RegardingObjectTypeCode { get; set; }

        [StringLength(4000)]
        public string RegardingObjectIdYomiName { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
