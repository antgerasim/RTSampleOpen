namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PublisherBase")]
    public partial class PublisherBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PublisherBase()
        {
            SolutionBase = new HashSet<SolutionBase>();
        }

        public long? PinpointPublisherId { get; set; }

        [Required]
        [StringLength(8)]
        public string CustomizationPrefix { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(100)]
        public string EMailAddress { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [Key]
        public Guid PublisherId { get; set; }

        [StringLength(16)]
        public string PinpointPublisherDefaultLocale { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        public int? CustomizationOptionValuePrefix { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid OrganizationId { get; set; }

        [StringLength(200)]
        public string SupportingWebsiteUrl { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [Required]
        [StringLength(256)]
        public string UniqueName { get; set; }

        public Guid? CreatedBy { get; set; }

        public bool IsReadonly { get; set; }

        [Required]
        [StringLength(256)]
        public string FriendlyName { get; set; }

        public Guid? EntityImageId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SolutionBase> SolutionBase { get; set; }
    }
}
