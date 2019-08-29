namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KnowledgeBaseRecordBase")]
    public partial class KnowledgeBaseRecordBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KnowledgeBaseRecordBase()
        {
            IncidentKnowledgeBaseRecord = new HashSet<IncidentKnowledgeBaseRecord>();
        }

        public Guid? TransactionCurrencyId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? CreatedBy { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        [Key]
        public Guid KnowledgeBaseRecordId { get; set; }

        public Guid? OrganizationId { get; set; }

        [StringLength(128)]
        public string UniqueId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(256)]
        public string PublicUrl { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        public decimal? ExchangeRate { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(256)]
        public string PrivateUrl { get; set; }

        [StringLength(2000)]
        public string Title { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IncidentKnowledgeBaseRecord> IncidentKnowledgeBaseRecord { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
