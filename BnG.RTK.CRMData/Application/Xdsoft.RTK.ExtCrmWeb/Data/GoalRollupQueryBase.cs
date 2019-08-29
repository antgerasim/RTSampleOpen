namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoalRollupQueryBase")]
    public partial class GoalRollupQueryBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GoalRollupQueryBase()
        {
            GoalBase = new HashSet<GoalBase>();
            GoalBase1 = new HashSet<GoalBase>();
            GoalBase2 = new HashSet<GoalBase>();
            GoalBase3 = new HashSet<GoalBase>();
            GoalBase4 = new HashSet<GoalBase>();
            GoalBase5 = new HashSet<GoalBase>();
            GoalBase6 = new HashSet<GoalBase>();
            GoalBase7 = new HashSet<GoalBase>();
            GoalBase8 = new HashSet<GoalBase>();
        }

        public DateTime? ModifiedOn { get; set; }

        public int StateCode { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int? QueryEntityType { get; set; }

        public string FetchXml { get; set; }

        public Guid? ModifiedBy { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid OwnerId { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public int? StatusCode { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [Key]
        public Guid GoalRollupQueryId { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int OwnerIdType { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoalBase> GoalBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoalBase> GoalBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoalBase> GoalBase2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoalBase> GoalBase3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoalBase> GoalBase4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoalBase> GoalBase5 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoalBase> GoalBase6 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoalBase> GoalBase7 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoalBase> GoalBase8 { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
