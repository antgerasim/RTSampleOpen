namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class msdyn_PostRuleConfigBase
    {
        [Key]
        public Guid msdyn_PostRuleConfigId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? OrganizationId { get; set; }

        public int statecode { get; set; }

        public int? statuscode { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        [StringLength(256)]
        public string msdyn_name { get; set; }

        [StringLength(256)]
        public string msdyn_FormatId { get; set; }

        public bool? msdyn_PostToYammer { get; set; }

        [StringLength(256)]
        public string msdyn_RuleId { get; set; }

        [StringLength(256)]
        public string msdyn_RuleSource { get; set; }

        [StringLength(100)]
        public string msdyn_StepId { get; set; }

        public Guid? msdyn_PostConfigId { get; set; }

        public virtual msdyn_PostConfigBase msdyn_PostConfigBase { get; set; }
    }
}
