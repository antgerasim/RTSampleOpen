namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SdkMessageResponseFieldBase")]
    public partial class SdkMessageResponseFieldBase
    {
        [StringLength(256)]
        public string PublicName { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid SdkMessageResponseFieldIdUnique { get; set; }

        [Required]
        [StringLength(256)]
        public string Value { get; set; }

        public Guid OrganizationId { get; set; }

        [StringLength(256)]
        public string Formatter { get; set; }

        [StringLength(256)]
        public string ClrFormatter { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomizationLevel { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        public Guid? CreatedBy { get; set; }

        public int Position { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SdkMessageResponseFieldId { get; set; }

        public Guid? SdkMessageResponseId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [StringLength(128)]
        public string ParameterBindingInformation { get; set; }

        public virtual SdkMessageResponseBaseIds SdkMessageResponseBaseIds { get; set; }

        public virtual SystemUserBase SystemUserBase { get; set; }

        public virtual SystemUserBase SystemUserBase1 { get; set; }

        public virtual SystemUserBase SystemUserBase2 { get; set; }

        public virtual SystemUserBase SystemUserBase3 { get; set; }
    }
}
