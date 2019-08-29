namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookableResourceBase")]
    public partial class BookableResourceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BookableResourceBase()
        {
            BookableResourceBookingBase = new HashSet<BookableResourceBookingBase>();
            BookableResourceCategoryAssnBase = new HashSet<BookableResourceCategoryAssnBase>();
            BookableResourceCharacteristicBase = new HashSet<BookableResourceCharacteristicBase>();
            BookableResourceGroupBase = new HashSet<BookableResourceGroupBase>();
            BookableResourceGroupBase1 = new HashSet<BookableResourceGroupBase>();
        }

        public Guid OwnerId { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? AccountId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int? StatusCode { get; set; }

        public Guid? ProcessId { get; set; }

        public Guid? StageId { get; set; }

        public Guid? CalendarId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int? ResourceType { get; set; }

        public int StateCode { get; set; }

        public Guid? UserId { get; set; }

        public Guid? ContactId { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(1250)]
        public string TraversedPath { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        [Key]
        public Guid BookableResourceId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public decimal? ExchangeRate { get; set; }

        public Guid? CreatedBy { get; set; }

        public int? TimeZone { get; set; }

        public int OwnerIdType { get; set; }

        public virtual AccountBase AccountBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookableResourceBookingBase> BookableResourceBookingBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookableResourceCategoryAssnBase> BookableResourceCategoryAssnBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookableResourceCharacteristicBase> BookableResourceCharacteristicBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookableResourceGroupBase> BookableResourceGroupBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookableResourceGroupBase> BookableResourceGroupBase1 { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual CalendarBase CalendarBase { get; set; }

        public virtual ContactBase ContactBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        public virtual SystemUserBase SystemUserBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
