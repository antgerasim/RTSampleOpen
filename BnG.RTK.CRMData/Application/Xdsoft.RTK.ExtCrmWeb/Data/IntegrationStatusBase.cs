namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IntegrationStatusBase")]
    public partial class IntegrationStatusBase
    {
        [Key]
        public Guid IntegrationEntryId { get; set; }

        [StringLength(200)]
        public string SystemName { get; set; }

        public Guid? ObjectId { get; set; }

        public int? ObjectTypeCode { get; set; }

        public int? StateCode { get; set; }

        public string StateDescription { get; set; }

        public int? StatusCode { get; set; }

        public string StatusDescription { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid OrganizationId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }
    }
}
