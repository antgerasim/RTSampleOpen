namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SocialProfileBase")]
    public partial class SocialProfileBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SocialProfileBase()
        {
            ActivityPointerBase = new HashSet<ActivityPointerBase>();
            IncidentBase = new HashSet<IncidentBase>();
        }

        public bool? Blocked { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? Community { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public int? StatusCode { get; set; }

        public Guid? CustomerId { get; set; }

        [StringLength(100)]
        public string ProfileLink { get; set; }

        [Key]
        public Guid SocialProfileId { get; set; }

        [StringLength(160)]
        public string ProfileFullName { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public int StateCode { get; set; }

        [StringLength(100)]
        public string ProfileName { get; set; }

        public double? InfluenceScore { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public decimal? ExchangeRate { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public Guid OwnerId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [StringLength(100)]
        public string UniqueProfileID { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int OwnerIdType { get; set; }

        [StringLength(4000)]
        public string CustomerIdName { get; set; }

        public int? CustomerIdType { get; set; }

        [StringLength(4000)]
        public string CustomerIdYomiName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityPointerBase> ActivityPointerBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IncidentBase> IncidentBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
