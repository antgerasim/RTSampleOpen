namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KbArticleBase")]
    public partial class KbArticleBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KbArticleBase()
        {
            IncidentBase = new HashSet<IncidentBase>();
            KbArticleCommentBase = new HashSet<KbArticleCommentBase>();
        }

        [Key]
        public Guid KbArticleId { get; set; }

        public Guid KbArticleTemplateId { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid SubjectId { get; set; }

        public string ArticleXml { get; set; }

        [StringLength(500)]
        public string Title { get; set; }

        [StringLength(100)]
        public string Number { get; set; }

        public string Content { get; set; }

        public string Description { get; set; }

        public string Comments { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int StateCode { get; set; }

        public int? StatusCode { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public string KeyWords { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public decimal? ExchangeRate { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public int? LanguageCode { get; set; }

        public Guid? EntityImageId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IncidentBase> IncidentBase { get; set; }

        public virtual KbArticleTemplateBaseIds KbArticleTemplateBaseIds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KbArticleCommentBase> KbArticleCommentBase { get; set; }

        public virtual SubjectBase SubjectBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
