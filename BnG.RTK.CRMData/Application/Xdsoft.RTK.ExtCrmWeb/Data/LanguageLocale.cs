namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LanguageLocale")]
    public partial class LanguageLocale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LanguageLocale()
        {
            KnowledgeArticleBase = new HashSet<KnowledgeArticleBase>();
        }

        public int statecode { get; set; }

        [Required]
        [StringLength(256)]
        public string Code { get; set; }

        [StringLength(256)]
        public string Region { get; set; }

        public int LocaleId { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid OrganizationId { get; set; }

        [Required]
        [StringLength(256)]
        public string Language { get; set; }

        public int? statuscode { get; set; }

        public Guid LanguageLocaleId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KnowledgeArticleBase> KnowledgeArticleBase { get; set; }
    }
}
