namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EntitlementTemplateBase")]
    public partial class EntitlementTemplateBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EntitlementTemplateBase()
        {
            EntitlementBase = new HashSet<EntitlementBase>();
            EntitlementTemplateChannelBase = new HashSet<EntitlementTemplateChannelBase>();
            EntitlementTemplateProducts = new HashSet<EntitlementTemplateProducts>();
        }

        public DateTime? OverriddenCreatedOn { get; set; }

        public decimal? TotalTerms { get; set; }

        public int? DecreaseRemainingOn { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        [Key]
        public Guid EntitlementTemplateId { get; set; }

        [StringLength(160)]
        public string Name { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public DateTime? EndDate { get; set; }

        public decimal? ExchangeRate { get; set; }

        public bool? RestrictCaseCreation { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int? AllocationTypeCode { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public int? KbAccessLevel { get; set; }

        public DateTime? StartDate { get; set; }

        public Guid? SLAId { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid OrganizationId { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntitlementBase> EntitlementBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntitlementTemplateChannelBase> EntitlementTemplateChannelBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntitlementTemplateProducts> EntitlementTemplateProducts { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
