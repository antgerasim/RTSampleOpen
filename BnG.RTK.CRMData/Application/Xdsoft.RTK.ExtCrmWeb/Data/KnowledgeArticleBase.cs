namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KnowledgeArticleBase")]
    public partial class KnowledgeArticleBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KnowledgeArticleBase()
        {
            KnowledgeArticleIncidentBase = new HashSet<KnowledgeArticleIncidentBase>();
            KnowledgeArticlesCategories = new HashSet<KnowledgeArticlesCategories>();
            KnowledgeArticleBase1 = new HashSet<KnowledgeArticleBase>();
            KnowledgeArticleBase11 = new HashSet<KnowledgeArticleBase>();
            KnowledgeArticleBase12 = new HashSet<KnowledgeArticleBase>();
            KnowledgeArticleViewsBase = new HashSet<KnowledgeArticleViewsBase>();
        }

        public Guid? LanguageLocaleId { get; set; }

        public int? ExpirationStatusId { get; set; }

        [Required]
        [StringLength(127)]
        public string ArticlePublicNumber { get; set; }

        public Guid? CreatedBy { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public bool? UpdateContent { get; set; }

        public int MinorVersionNumber { get; set; }

        public bool? IsPrimary { get; set; }

        public Guid? ParentArticleContentId { get; set; }

        public Guid? stageid { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? RootArticleId { get; set; }

        public int? StatusCode { get; set; }

        public int StateCode { get; set; }

        public int? PublishStatusId { get; set; }

        public bool? SetProductAssociations { get; set; }

        [Key]
        public Guid knowledgearticleId { get; set; }

        [StringLength(4000)]
        public string Title { get; set; }

        [StringLength(1250)]
        public string traversedpath { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public DateTime? PublishOn { get; set; }

        public int? KnowledgeArticleViews { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public int? ExpiredReviewOptions { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? processid { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int? ExpirationStateId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public bool IsRootArticle { get; set; }

        public int? Review { get; set; }

        public Guid OwnerId { get; set; }

        public decimal? ExchangeRate { get; set; }

        public int MajorVersionNumber { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public Guid? PreviousArticleContentId { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public bool IsLatestVersion { get; set; }

        public string Keywords { get; set; }

        public int? ScheduledStatusId { get; set; }

        public Guid? SubjectId { get; set; }

        public Guid? primaryauthorid { get; set; }

        public bool? ReadyForReview { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public int OwnerIdType { get; set; }

        public int? KnowledgeArticleViews_State { get; set; }

        public DateTime? KnowledgeArticleViews_Date { get; set; }

        public bool? SetCategoryAssociations { get; set; }

        public bool? IsInternal { get; set; }

        public decimal? Rating { get; set; }

        public decimal? Rating_Sum { get; set; }

        public int? Rating_State { get; set; }

        public int? Rating_Count { get; set; }

        public DateTime? Rating_Date { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KnowledgeArticleIncidentBase> KnowledgeArticleIncidentBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KnowledgeArticlesCategories> KnowledgeArticlesCategories { get; set; }

        public virtual LanguageLocale LanguageLocale { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KnowledgeArticleBase> KnowledgeArticleBase1 { get; set; }

        public virtual KnowledgeArticleBase KnowledgeArticleBase2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KnowledgeArticleBase> KnowledgeArticleBase11 { get; set; }

        public virtual KnowledgeArticleBase KnowledgeArticleBase3 { get; set; }

        public virtual SystemUserBase SystemUserBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KnowledgeArticleBase> KnowledgeArticleBase12 { get; set; }

        public virtual KnowledgeArticleBase KnowledgeArticleBase4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KnowledgeArticleViewsBase> KnowledgeArticleViewsBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        public virtual SubjectBase SubjectBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
