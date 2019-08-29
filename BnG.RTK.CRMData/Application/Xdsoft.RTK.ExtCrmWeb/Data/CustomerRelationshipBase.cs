namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerRelationshipBase")]
    public partial class CustomerRelationshipBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerRelationshipBase()
        {
            CustomerRelationshipBase1 = new HashSet<CustomerRelationshipBase>();
        }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? CustomerRoleId { get; set; }

        [Key]
        public Guid CustomerRelationshipId { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid PartnerId { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public Guid? ConverseRelationshipId { get; set; }

        public Guid? PartnerRoleId { get; set; }

        public string CustomerRoleDescription { get; set; }

        public Guid CustomerId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public string PartnerRoleDescription { get; set; }

        public int? PartnerIdType { get; set; }

        public int? CustomerIdType { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public Guid? UniqueDscId { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid OwnerId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [StringLength(4000)]
        public string PartnerIdName { get; set; }

        public int OwnerIdType { get; set; }

        [StringLength(4000)]
        public string CustomerIdName { get; set; }

        [StringLength(4000)]
        public string PartnerIdYomiName { get; set; }

        [StringLength(4000)]
        public string CustomerIdYomiName { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerRelationshipBase> CustomerRelationshipBase1 { get; set; }

        public virtual CustomerRelationshipBase CustomerRelationshipBase2 { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        public virtual RelationshipRoleBase RelationshipRoleBase { get; set; }

        public virtual RelationshipRoleBase RelationshipRoleBase1 { get; set; }
    }
}
