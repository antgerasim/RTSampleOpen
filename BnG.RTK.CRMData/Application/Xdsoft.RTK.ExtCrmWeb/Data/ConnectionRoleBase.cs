namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConnectionRoleBase")]
    public partial class ConnectionRoleBase
    {
        public Guid ConnectionRoleIdUnique { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid ConnectionRoleId { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public bool IsManaged { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid OrganizationId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int? ImportSequenceNumber { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int? StatusCode { get; set; }

        public int StateCode { get; set; }

        public int? Category { get; set; }

        public Guid? ModifiedBy { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime OverwriteTime { get; set; }

        public bool IsCustomizable { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid SolutionId { get; set; }

        [StringLength(48)]
        public string IntroducedVersion { get; set; }
    }
}
