namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AppModuleComponentBase")]
    public partial class AppModuleComponentBase
    {
        public bool? IsDefault { get; set; }

        public decimal? ExchangeRate { get; set; }

        public Guid AppModuleComponentIdUnique { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(48)]
        public string IntroducedVersion { get; set; }

        public Guid? RootAppModuleComponentId { get; set; }

        public int? RootComponentBehavior { get; set; }

        public int? ComponentType { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? AppModuleIdUnique { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public Guid? ObjectId { get; set; }

        public bool? IsMetadata { get; set; }

        [Key]
        [Column(Order = 0)]
        public DateTime OverwriteTime { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid AppModuleComponentId { get; set; }
    }
}
