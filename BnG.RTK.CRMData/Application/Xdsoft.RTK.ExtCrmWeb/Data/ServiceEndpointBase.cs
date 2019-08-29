namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceEndpointBase")]
    public partial class ServiceEndpointBase
    {
        public int Contract { get; set; }

        public int UserClaim { get; set; }

        public int ConnectionMode { get; set; }

        public string Description { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid SolutionId { get; set; }

        public Guid ServiceEndpointIdUnique { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        public bool IsCustomizable { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid ServiceEndpointId { get; set; }

        public Guid OrganizationId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public bool IsManaged { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        [Required]
        [StringLength(160)]
        public string Path { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime OverwriteTime { get; set; }

        public Guid? CreatedBy { get; set; }

        [Required]
        [StringLength(160)]
        public string SolutionNamespace { get; set; }

        [StringLength(48)]
        public string IntroducedVersion { get; set; }

        public byte[] SASToken { get; set; }

        public byte[] SASKey { get; set; }

        [StringLength(255)]
        public string NamespaceAddress { get; set; }

        public int? AuthType { get; set; }

        public int? NamespaceFormat { get; set; }

        public int? MessageFormat { get; set; }

        [StringLength(256)]
        public string SASKeyName { get; set; }
    }
}
