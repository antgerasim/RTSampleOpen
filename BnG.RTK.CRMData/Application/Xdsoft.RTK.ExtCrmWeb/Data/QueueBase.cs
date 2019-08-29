namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QueueBase")]
    public partial class QueueBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QueueBase()
        {
            QueueItemBase = new HashSet<QueueItemBase>();
            QueueMembership = new HashSet<QueueMembership>();
            SystemUserBase1 = new HashSet<SystemUserBase>();
            TeamBase = new HashSet<TeamBase>();
        }

        [Key]
        public Guid QueueId { get; set; }

        public Guid? BusinessUnitId { get; set; }

        public Guid OrganizationId { get; set; }

        [StringLength(100)]
        public string EMailAddress { get; set; }

        public Guid? PrimaryUserId { get; set; }

        public int? QueueTypeCode { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public string Description { get; set; }

        public int? QueueSemantics { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public bool? IgnoreUnsolicitedEmail { get; set; }

        public bool? IsFaxQueue { get; set; }

        [StringLength(200)]
        public string EmailPassword { get; set; }

        public int IncomingEmailDeliveryMethod { get; set; }

        [StringLength(200)]
        public string EmailUsername { get; set; }

        public int OutgoingEmailDeliveryMethod { get; set; }

        public bool AllowEmailCredentials { get; set; }

        public int IncomingEmailFilteringMethod { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public decimal? ExchangeRate { get; set; }

        public int StatusCode { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public int StateCode { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public Guid OwnerId { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int EmailRouterAccessApproval { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int OwnerIdType { get; set; }

        public bool IsEmailAddressApprovedByO365Admin { get; set; }

        public Guid? EntityImageId { get; set; }

        public Guid? DefaultMailbox { get; set; }

        public int QueueViewType { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase1 { get; set; }

        public virtual MailboxBase MailboxBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QueueItemBase> QueueItemBase { get; set; }

        public virtual SystemUserBase SystemUserBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QueueMembership> QueueMembership { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SystemUserBase> SystemUserBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeamBase> TeamBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
