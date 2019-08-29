namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TimeZoneDefinitionBase")]
    public partial class TimeZoneDefinitionBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TimeZoneDefinitionBase()
        {
            TimeZoneLocalizedNameBase = new HashSet<TimeZoneLocalizedNameBase>();
            TimeZoneRuleBase = new HashSet<TimeZoneRuleBase>();
        }

        public DateTime? ModifiedOn { get; set; }

        public int TimeZoneCode { get; set; }

        public Guid? OrganizationId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Key]
        public Guid TimeZoneDefinitionId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int? Bias { get; set; }

        [StringLength(100)]
        public string DaylightName { get; set; }

        public Guid? CreatedBy { get; set; }

        [Required]
        [StringLength(100)]
        public string UserInterfaceName { get; set; }

        [Required]
        [StringLength(100)]
        public string StandardName { get; set; }

        public int RetiredOrder { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeZoneLocalizedNameBase> TimeZoneLocalizedNameBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeZoneRuleBase> TimeZoneRuleBase { get; set; }
    }
}
