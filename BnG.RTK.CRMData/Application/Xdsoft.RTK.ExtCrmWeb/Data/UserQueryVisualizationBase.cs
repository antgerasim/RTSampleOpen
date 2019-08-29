namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserQueryVisualizationBase")]
    public partial class UserQueryVisualizationBase
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public DateTime CreatedOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public string DataDescription { get; set; }

        [Key]
        public Guid UserQueryVisualizationId { get; set; }

        public bool IsDefault { get; set; }

        public Guid? WebResourceId { get; set; }

        public DateTime ModifiedOn { get; set; }

        public Guid OwnerId { get; set; }

        public int PrimaryEntityTypeCode { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public string Description { get; set; }

        public Guid ModifiedBy { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public string PresentationDescription { get; set; }

        public Guid CreatedBy { get; set; }

        public int OwnerIdType { get; set; }

        public int? ChartType { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
