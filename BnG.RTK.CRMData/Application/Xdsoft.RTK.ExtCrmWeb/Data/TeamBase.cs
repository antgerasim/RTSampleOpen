namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TeamBase")]
    public partial class TeamBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TeamBase()
        {
            TeamMembership = new HashSet<TeamMembership>();
            TeamProfiles = new HashSet<TeamProfiles>();
            TeamRoles = new HashSet<TeamRoles>();
            TeamSyncAttributeMappingProfiles = new HashSet<TeamSyncAttributeMappingProfiles>();
        }

        [Key]
        public Guid TeamId { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid BusinessUnitId { get; set; }

        [Required]
        [StringLength(160)]
        public string Name { get; set; }

        public string Description { get; set; }

        [StringLength(100)]
        public string EMailAddress { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public bool IsDefault { get; set; }

        public Guid AdministratorId { get; set; }

        public Guid? QueueId { get; set; }

        public decimal? ExchangeRate { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        [StringLength(160)]
        public string YomiName { get; set; }

        public Guid? RegardingObjectId { get; set; }

        public int TeamType { get; set; }

        public Guid? ProcessId { get; set; }

        public bool SystemManaged { get; set; }

        public Guid? StageId { get; set; }

        public Guid? TeamTemplateId { get; set; }

        public int? RegardingObjectTypeCode { get; set; }

        [StringLength(1250)]
        public string TraversedPath { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual QueueBase QueueBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeamMembership> TeamMembership { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeamProfiles> TeamProfiles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeamRoles> TeamRoles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeamSyncAttributeMappingProfiles> TeamSyncAttributeMappingProfiles { get; set; }

        public virtual TeamTemplateBase TeamTemplateBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
