namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomControlResourceBase")]
    public partial class CustomControlResourceBase
    {
        public DateTime? ModifiedOn { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid CustomControlResourceId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid CustomControlId { get; set; }

        [StringLength(20)]
        public string VersionRequirement { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string Version { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid WebResourceId { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid OrganizationId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [StringLength(48)]
        public string IntroducedVersion { get; set; }

        public Guid CustomControlResourceIdUnique { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime OverwriteTime { get; set; }

        public bool IsManaged { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid SolutionId { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }
    }
}
