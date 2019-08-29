namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerOpportunityRoleBase")]
    public partial class CustomerOpportunityRoleBase
    {
        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid CustomerId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Key]
        public Guid CustomerOpportunityRoleId { get; set; }

        public Guid? OpportunityRoleId { get; set; }

        public Guid OpportunityId { get; set; }

        public int? CustomerIdType { get; set; }

        public Guid? UniqueDscId { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid OwnerId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [StringLength(4000)]
        public string CustomerIdName { get; set; }

        public int OwnerIdType { get; set; }

        [StringLength(4000)]
        public string CustomerIdYomiName { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual OpportunityBase OpportunityBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        public virtual RelationshipRoleBase RelationshipRoleBase { get; set; }
    }
}
