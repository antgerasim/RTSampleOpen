namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SdkMessageRequestBase")]
    public partial class SdkMessageRequestBase
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomizationLevel { get; set; }

        public Guid? SdkMessagePairId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid OrganizationId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid SdkMessageRequestIdUnique { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SdkMessageRequestId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int? PrimaryObjectTypeCode { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public virtual SdkMessagePairBaseIds SdkMessagePairBaseIds { get; set; }

        public virtual SystemUserBase SystemUserBase { get; set; }

        public virtual SystemUserBase SystemUserBase1 { get; set; }

        public virtual SystemUserBase SystemUserBase2 { get; set; }

        public virtual SystemUserBase SystemUserBase3 { get; set; }
    }
}
