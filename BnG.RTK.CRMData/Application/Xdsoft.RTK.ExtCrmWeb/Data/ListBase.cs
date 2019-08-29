namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ListBase")]
    public partial class ListBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ListBase()
        {
            ListMemberBase = new HashSet<ListMemberBase>();
        }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int? MemberCount { get; set; }

        [Required]
        [StringLength(128)]
        public string ListName { get; set; }

        public DateTime? LastUsedOn { get; set; }

        [Key]
        public Guid ListId { get; set; }

        public int StateCode { get; set; }

        public int? StatusCode { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public Guid? ModifiedBy { get; set; }

        public bool? DoNotSendOnOptOut { get; set; }

        public string Description { get; set; }

        [StringLength(512)]
        public string Purpose { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cost { get; set; }

        public bool? IgnoreInactiveListMembers { get; set; }

        public int? MemberType { get; set; }

        [StringLength(128)]
        public string Source { get; set; }

        public int CreatedFromCode { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public bool? LockStatus { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public decimal? ExchangeRate { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cost_Base { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public bool Type { get; set; }

        public string Query { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid OwnerId { get; set; }

        public int OwnerIdType { get; set; }

        public Guid? StageId { get; set; }

        public Guid? ProcessId { get; set; }

        [StringLength(1250)]
        public string TraversedPath { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListMemberBase> ListMemberBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
