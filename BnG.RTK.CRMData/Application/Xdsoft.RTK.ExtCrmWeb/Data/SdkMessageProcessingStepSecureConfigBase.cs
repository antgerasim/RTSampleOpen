namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SdkMessageProcessingStepSecureConfigBase")]
    public partial class SdkMessageProcessingStepSecureConfigBase
    {
        public int CustomizationLevel { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string SecureConfig { get; set; }

        [Key]
        public Guid SdkMessageProcessingStepSecureConfigId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid SdkMessageProcessingStepSecureConfigIdUnique { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }
    }
}
