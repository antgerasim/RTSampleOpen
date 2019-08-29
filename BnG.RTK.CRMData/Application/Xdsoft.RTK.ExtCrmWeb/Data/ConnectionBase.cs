namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConnectionBase")]
    public partial class ConnectionBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ConnectionBase()
        {
            ConnectionBase1 = new HashSet<ConnectionBase>();
        }

        public Guid? Record2RoleId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? Record2Id { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [Key]
        public Guid ConnectionId { get; set; }

        public bool IsMaster { get; set; }

        public Guid OwnerId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int? Record2ObjectTypeCode { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public int StateCode { get; set; }

        public string Description { get; set; }

        public DateTime? EffectiveStart { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public Guid? Record1Id { get; set; }

        public int? StatusCode { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int? Record1ObjectTypeCode { get; set; }

        public Guid? RelatedConnectionId { get; set; }

        public Guid? Record1RoleId { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? EffectiveEnd { get; set; }

        public decimal? ExchangeRate { get; set; }

        [StringLength(4000)]
        public string Record2IdName { get; set; }

        [StringLength(4000)]
        public string Record1IdName { get; set; }

        public int OwnerIdType { get; set; }

        public int? Record2IdObjectTypeCode { get; set; }

        public int? Record1IdObjectTypeCode { get; set; }

        public Guid? EntityImageId { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConnectionBase> ConnectionBase1 { get; set; }

        public virtual ConnectionBase ConnectionBase2 { get; set; }

        public virtual ConnectionRoleBaseIds ConnectionRoleBaseIds { get; set; }

        public virtual ConnectionRoleBaseIds ConnectionRoleBaseIds1 { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
