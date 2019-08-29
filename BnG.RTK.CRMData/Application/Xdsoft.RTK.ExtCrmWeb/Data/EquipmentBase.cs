namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EquipmentBase")]
    public partial class EquipmentBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EquipmentBase()
        {
            AccountBase = new HashSet<AccountBase>();
            ContactBase = new HashSet<ContactBase>();
        }

        [Key]
        public Guid EquipmentId { get; set; }

        public Guid? SiteId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid BusinessUnitId { get; set; }

        [StringLength(100)]
        public string Skills { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int TimeZoneCode { get; set; }

        public bool? DisplayInServiceViews { get; set; }

        public bool? IsDisabled { get; set; }

        [Required]
        [StringLength(160)]
        public string Name { get; set; }

        public Guid CalendarId { get; set; }

        public string Description { get; set; }

        [StringLength(100)]
        public string EMailAddress { get; set; }

        public Guid OrganizationId { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public decimal? ExchangeRate { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountBase> AccountBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual CalendarBase CalendarBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactBase> ContactBase { get; set; }

        public virtual SiteBase SiteBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
