namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KnowledgeArticlesCategories
    {
        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid KnowledgeArticleId { get; set; }

        [Key]
        public Guid KnowledgeArticleCategoryId { get; set; }

        public Guid CategoryId { get; set; }

        public virtual CategoryBase CategoryBase { get; set; }

        public virtual KnowledgeArticleBase KnowledgeArticleBase { get; set; }
    }
}
