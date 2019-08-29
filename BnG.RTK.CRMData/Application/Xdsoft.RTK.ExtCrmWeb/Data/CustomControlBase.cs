namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomControlBase")]
    public partial class CustomControlBase
    {
        public Guid CustomControlIdUnique { get; set; }

        [Required]
        [StringLength(500)]
        public string CompatibleDataTypes { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid OrganizationId { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        [StringLength(48)]
        public string IntroducedVersion { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid CustomControlId { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string Version { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        [Required]
        public string Manifest { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid SolutionId { get; set; }

        public bool IsManaged { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime OverwriteTime { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }
    }
}
