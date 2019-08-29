namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OwnerMappingBase")]
    public partial class OwnerMappingBase
    {
        public DateTime CreatedOn { get; set; }

        [StringLength(160)]
        public string TargetUserValueForSourceCRMUserLink { get; set; }

        public int StatusCode { get; set; }

        public Guid? ImportMapId { get; set; }

        public Guid? ModifiedBy { get; set; }

        [Key]
        public Guid OwnerMappingId { get; set; }

        public Guid? CreatedBy { get; set; }

        public int ProcessCode { get; set; }

        [StringLength(160)]
        public string SourceSystemUserName { get; set; }

        public Guid? TargetSystemUserId { get; set; }

        public int StateCode { get; set; }

        [StringLength(160)]
        public string SourceUserValueForSourceCRMUserLink { get; set; }

        [StringLength(260)]
        public string TargetSystemUserDomainName { get; set; }

        public DateTime ModifiedOn { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public virtual ImportMapBase ImportMapBase { get; set; }

        public virtual SystemUserBase SystemUserBase { get; set; }
    }
}
