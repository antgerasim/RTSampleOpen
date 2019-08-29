namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EntitlementBase")]
    public partial class EntitlementBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EntitlementBase()
        {
            IncidentBase = new HashSet<IncidentBase>();
            EntitlementChannelBase = new HashSet<EntitlementChannelBase>();
            EntitlementContacts = new HashSet<EntitlementContacts>();
            EntitlementProducts = new HashSet<EntitlementProducts>();
        }

        public DateTime? OverriddenCreatedOn { get; set; }

        public Guid? SLAId { get; set; }

        public Guid? ProcessId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public decimal? RemainingTerms { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public Guid? CustomerId { get; set; }

        public int? StatusCode { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int? KbAccessLevel { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [StringLength(160)]
        public string Name { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public decimal? TotalTerms { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Key]
        public Guid EntitlementId { get; set; }

        public int? AllocationTypeCode { get; set; }

        public int? DecreaseRemainingOn { get; set; }

        public Guid? EntitlementTemplateId { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public DateTime? StartDate { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public string Description { get; set; }

        public DateTime? EndDate { get; set; }

        [StringLength(1250)]
        public string TraversedPath { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public Guid OwnerId { get; set; }

        public int? StateCode { get; set; }

        public bool? RestrictCaseCreation { get; set; }

        public Guid? StageId { get; set; }

        public decimal? ExchangeRate { get; set; }

        public Guid? AccountId { get; set; }

        public Guid? ContactId { get; set; }

        [StringLength(4000)]
        public string CustomerIdName { get; set; }

        [StringLength(4000)]
        public string AccountIdName { get; set; }

        [StringLength(160)]
        public string ContactIdName { get; set; }

        public int? CustomerIdType { get; set; }

        public int? OwnerIdType { get; set; }

        [StringLength(4000)]
        public string AccountIdYomiName { get; set; }

        [StringLength(450)]
        public string ContactIdYomiName { get; set; }

        [StringLength(4000)]
        public string CustomerIdYomiName { get; set; }

        public bool? IsDefault { get; set; }

        public virtual AccountBase AccountBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual ContactBase ContactBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IncidentBase> IncidentBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntitlementChannelBase> EntitlementChannelBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntitlementContacts> EntitlementContacts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntitlementProducts> EntitlementProducts { get; set; }

        public virtual EntitlementTemplateBase EntitlementTemplateBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
