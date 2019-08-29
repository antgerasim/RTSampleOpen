namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CalendarBase")]
    public partial class CalendarBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CalendarBase()
        {
            BookableResourceBase = new HashSet<BookableResourceBase>();
            BusinessUnitBase1 = new HashSet<BusinessUnitBase>();
            CalendarRuleBase = new HashSet<CalendarRuleBase>();
            CalendarBase1 = new HashSet<CalendarBase>();
            EquipmentBase = new HashSet<EquipmentBase>();
            OrganizationBase = new HashSet<OrganizationBase>();
            ServiceBase = new HashSet<ServiceBase>();
            SystemUserBase = new HashSet<SystemUserBase>();
            CalendarRuleBase1 = new HashSet<CalendarRuleBase>();
        }

        public Guid? ModifiedBy { get; set; }

        [Key]
        public Guid CalendarId { get; set; }

        public string Description { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(160)]
        public string Name { get; set; }

        public Guid? BusinessUnitId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? PrimaryUserId { get; set; }

        public Guid OrganizationId { get; set; }

        public bool IsShared { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int Type { get; set; }

        public Guid? HolidayScheduleCalendarId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookableResourceBase> BookableResourceBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessUnitBase> BusinessUnitBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CalendarRuleBase> CalendarRuleBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CalendarBase> CalendarBase1 { get; set; }

        public virtual CalendarBase CalendarBase2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EquipmentBase> EquipmentBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationBase> OrganizationBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceBase> ServiceBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SystemUserBase> SystemUserBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CalendarRuleBase> CalendarRuleBase1 { get; set; }
    }
}
