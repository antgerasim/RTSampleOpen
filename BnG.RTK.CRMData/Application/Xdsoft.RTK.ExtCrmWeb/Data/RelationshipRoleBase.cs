namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RelationshipRoleBase")]
    public partial class RelationshipRoleBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RelationshipRoleBase()
        {
            CustomerOpportunityRoleBase = new HashSet<CustomerOpportunityRoleBase>();
            CustomerRelationshipBase = new HashSet<CustomerRelationshipBase>();
            CustomerRelationshipBase1 = new HashSet<CustomerRelationshipBase>();
            RelationshipRoleMapBase = new HashSet<RelationshipRoleMapBase>();
        }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int? StatusCode { get; set; }

        [Key]
        public Guid RelationshipRoleId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid? ModifiedBy { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int StateCode { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerOpportunityRoleBase> CustomerOpportunityRoleBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerRelationshipBase> CustomerRelationshipBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerRelationshipBase> CustomerRelationshipBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelationshipRoleMapBase> RelationshipRoleMapBase { get; set; }
    }
}
