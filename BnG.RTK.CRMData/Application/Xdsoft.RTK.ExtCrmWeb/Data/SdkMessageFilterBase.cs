namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SdkMessageFilterBase")]
    public partial class SdkMessageFilterBase
    {
        public Guid? CreatedBy { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid SdkMessageFilterId { get; set; }

        public Guid OrganizationId { get; set; }

        public int PrimaryObjectTypeCode { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? ModifiedBy { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomizationLevel { get; set; }

        public int SecondaryObjectTypeCode { get; set; }

        public Guid SdkMessageFilterIdUnique { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsCustomProcessingStepAllowed { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int Availability { get; set; }

        public Guid SdkMessageId { get; set; }

        public bool IsVisible { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public bool? WorkflowSdkStepEnabled { get; set; }

        public virtual SdkMessageBaseIds SdkMessageBaseIds { get; set; }

        public virtual SystemUserBase SystemUserBase { get; set; }

        public virtual SystemUserBase SystemUserBase1 { get; set; }

        public virtual SystemUserBase SystemUserBase2 { get; set; }

        public virtual SystemUserBase SystemUserBase3 { get; set; }
    }
}
