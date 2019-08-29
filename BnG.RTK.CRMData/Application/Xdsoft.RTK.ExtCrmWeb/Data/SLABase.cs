namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SLABase")]
    public partial class SLABase
    {
        public int StateCode { get; set; }

        public decimal? ExchangeRate { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid SLAId { get; set; }

        public Guid OwnerId { get; set; }

        public string Description { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [StringLength(500)]
        public string ChangedAttributeList { get; set; }

        [StringLength(100)]
        public string ApplicableFrom { get; set; }

        public Guid? WorkflowId { get; set; }

        public int? StatusCode { get; set; }

        [Required]
        [StringLength(160)]
        public string Name { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool AllowPauseResume { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public bool? IsDefault { get; set; }

        public Guid SolutionId { get; set; }

        public Guid? BusinessHoursId { get; set; }

        public int SLAType { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime OverwriteTime { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int? ApplicableFromPickList { get; set; }

        public int? ObjectTypeCode { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public Guid SLAIdUnique { get; set; }

        public bool IsManaged { get; set; }

        public int OwnerIdType { get; set; }

        public int PrimaryEntityOTC { get; set; }
    }
}
