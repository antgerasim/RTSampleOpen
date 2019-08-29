namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceBase")]
    public partial class ServiceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ServiceBase()
        {
            AccountBase = new HashSet<AccountBase>();
            ActivityPointerBase = new HashSet<ActivityPointerBase>();
            CalendarRuleBase = new HashSet<CalendarRuleBase>();
            ContactBase = new HashSet<ContactBase>();
        }

        [Required]
        [StringLength(160)]
        public string Name { get; set; }

        public Guid OrganizationId { get; set; }

        [Key]
        public Guid ServiceId { get; set; }

        public Guid ResourceSpecId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int? AnchorOffset { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int Duration { get; set; }

        public bool IsSchedulable { get; set; }

        public Guid StrategyId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? CreatedBy { get; set; }

        public int InitialStatusCode { get; set; }

        public Guid? CalendarId { get; set; }

        public bool? ShowResources { get; set; }

        [Required]
        [StringLength(100)]
        public string Granularity { get; set; }

        public string Description { get; set; }

        public DateTime? CreatedOn { get; set; }

        public bool? IsVisible { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountBase> AccountBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityPointerBase> ActivityPointerBase { get; set; }

        public virtual CalendarBase CalendarBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CalendarRuleBase> CalendarRuleBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactBase> ContactBase { get; set; }

        public virtual ResourceSpecBase ResourceSpecBase { get; set; }
    }
}
