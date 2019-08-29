namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ActionCardBase")]
    public partial class ActionCardBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ActionCardBase()
        {
            ActionCardUserStateBase = new HashSet<ActionCardUserStateBase>();
        }

        public DateTime StartDate { get; set; }

        [Key]
        public Guid ActionCardId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime ExpiryDate { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public string Data { get; set; }

        public int CardType { get; set; }

        public string ReferenceTokens { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public bool? Visibility { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? RecordId { get; set; }

        public Guid OwnerId { get; set; }

        public decimal? ExchangeRate { get; set; }

        public Guid? RegardingObjectId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public int Priority { get; set; }

        public int State { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public string Description { get; set; }

        public int Source { get; set; }

        public Guid CardTypeId { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int OwnerIdType { get; set; }

        public int? RecordIdObjectTypeCode { get; set; }

        [StringLength(400)]
        public string RecordIdName { get; set; }

        public int? RegardingObjectTypeCode { get; set; }

        [StringLength(4000)]
        public string RegardingObjectIdName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActionCardUserStateBase> ActionCardUserStateBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
