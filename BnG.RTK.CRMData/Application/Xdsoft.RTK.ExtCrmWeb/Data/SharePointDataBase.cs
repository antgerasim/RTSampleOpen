namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SharePointDataBase")]
    public partial class SharePointDataBase
    {
        [StringLength(160)]
        public string RegardingObjectId { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime ModifiedOn { get; set; }

        [StringLength(160)]
        public string NextPageToken { get; set; }

        [Key]
        public Guid SharePointDataId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? UserId { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? Location { get; set; }

        public string Data { get; set; }

        [StringLength(160)]
        public string PreviousPageToken { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool? IsValid { get; set; }

        public Guid OrganizationId { get; set; }

        public DateTime OverwriteTime { get; set; }

        public int? RegardingObjectTypeCode { get; set; }
    }
}
