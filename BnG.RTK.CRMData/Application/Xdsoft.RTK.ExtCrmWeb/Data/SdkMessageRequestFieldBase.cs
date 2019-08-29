namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SdkMessageRequestFieldBase")]
    public partial class SdkMessageRequestFieldBase
    {
        public DateTime? CreatedOn { get; set; }

        public Guid SdkMessageRequestFieldIdUnique { get; set; }

        public bool? Optional { get; set; }

        public Guid? CreatedBy { get; set; }

        public int Position { get; set; }

        [StringLength(256)]
        public string ClrParser { get; set; }

        [StringLength(256)]
        public string PublicName { get; set; }

        public Guid? SdkMessageRequestId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(256)]
        public string Parser { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomizationLevel { get; set; }

        public Guid OrganizationId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SdkMessageRequestFieldId { get; set; }

        public Guid? ModifiedBy { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int FieldMask { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [StringLength(128)]
        public string ParameterBindingInformation { get; set; }

        public virtual SdkMessageRequestBaseIds SdkMessageRequestBaseIds { get; set; }

        public virtual SystemUserBase SystemUserBase { get; set; }

        public virtual SystemUserBase SystemUserBase1 { get; set; }

        public virtual SystemUserBase SystemUserBase2 { get; set; }

        public virtual SystemUserBase SystemUserBase3 { get; set; }
    }
}
