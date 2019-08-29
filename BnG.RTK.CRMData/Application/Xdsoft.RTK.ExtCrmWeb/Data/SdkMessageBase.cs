namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SdkMessageBase")]
    public partial class SdkMessageBase
    {
        public Guid OrganizationId { get; set; }

        public bool? IsPrivate { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid SdkMessageId { get; set; }

        public Guid? CreatedBy { get; set; }

        [Required]
        [StringLength(25)]
        public string CategoryName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomizationLevel { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid SdkMessageIdUnique { get; set; }

        public bool? Expand { get; set; }

        public bool? AutoTransact { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int Availability { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        public bool? Template { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [StringLength(512)]
        public string ThrottleSettings { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsValidForExecuteAsync { get; set; }

        public bool? WorkflowSdkStepEnabled { get; set; }

        public bool IsReadOnly { get; set; }

        public virtual SystemUserBase SystemUserBase { get; set; }

        public virtual SystemUserBase SystemUserBase1 { get; set; }

        public virtual SystemUserBase SystemUserBase2 { get; set; }

        public virtual SystemUserBase SystemUserBase3 { get; set; }
    }
}
