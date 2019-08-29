namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContractTemplateBase")]
    public partial class ContractTemplateBase
    {
        [Key]
        [Column(Order = 0)]
        public Guid ContractTemplateId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public Guid OrganizationId { get; set; }

        public string Description { get; set; }

        [Required]
        [StringLength(20)]
        public string Abbreviation { get; set; }

        public int? ContractServiceLevelCode { get; set; }

        public int? BillingFrequencyCode { get; set; }

        public int? AllotmentTypeCode { get; set; }

        public bool? UseDiscountAsPercentage { get; set; }

        [StringLength(168)]
        public string EffectivityCalendar { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public bool IsManaged { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid SolutionId { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime OverwriteTime { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public Guid ContractTemplateIdUnique { get; set; }

        public bool IsCustomizable { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [StringLength(48)]
        public string IntroducedVersion { get; set; }
    }
}
