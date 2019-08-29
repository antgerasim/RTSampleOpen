namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CategoryBase")]
    public partial class CategoryBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CategoryBase()
        {
            KnowledgeArticlesCategories = new HashSet<KnowledgeArticlesCategories>();
        }

        public string Description { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [StringLength(4000)]
        public string Title { get; set; }

        [Required]
        [StringLength(127)]
        public string CategoryNumber { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public decimal? ExchangeRate { get; set; }

        [Key]
        public Guid CategoryId { get; set; }

        public int? SequenceNumber { get; set; }

        public Guid? ParentCategoryId { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public Guid OwnerId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int OwnerIdType { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KnowledgeArticlesCategories> KnowledgeArticlesCategories { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
