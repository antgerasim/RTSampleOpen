namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SdkMessagePairBase")]
    public partial class SdkMessagePairBase
    {
        public Guid? ModifiedBy { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid SdkMessagePairId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomizationLevel { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid SdkMessagePairIdUnique { get; set; }

        [Required]
        [StringLength(128)]
        public string Endpoint { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Required]
        [StringLength(256)]
        public string Namespace { get; set; }

        public Guid? SdkMessageId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [StringLength(128)]
        public string SdkMessageBindingInformation { get; set; }

        public virtual SdkMessageBaseIds SdkMessageBaseIds { get; set; }

        public virtual SystemUserBase SystemUserBase { get; set; }

        public virtual SystemUserBase SystemUserBase1 { get; set; }

        public virtual SystemUserBase SystemUserBase2 { get; set; }

        public virtual SystemUserBase SystemUserBase3 { get; set; }
    }
}
