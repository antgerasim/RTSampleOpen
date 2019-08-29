namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TimeZoneLocalizedNameBase")]
    public partial class TimeZoneLocalizedNameBase
    {
        public int CultureId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid TimeZoneDefinitionId { get; set; }

        [Required]
        [StringLength(100)]
        public string StandardName { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? ModifiedBy { get; set; }

        [Key]
        public Guid TimeZoneLocalizedNameId { get; set; }

        [Required]
        [StringLength(100)]
        public string UserInterfaceName { get; set; }

        [StringLength(100)]
        public string DaylightName { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? OrganizationId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public virtual TimeZoneDefinitionBase TimeZoneDefinitionBase { get; set; }
    }
}
