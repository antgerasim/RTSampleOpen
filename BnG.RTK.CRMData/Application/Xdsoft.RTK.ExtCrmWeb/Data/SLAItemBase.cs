namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SLAItemBase")]
    public partial class SLAItemBase
    {
        public string ApplicableWhenXml { get; set; }

        [StringLength(100)]
        public string RelatedField { get; set; }

        public Guid? WorkflowId { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid SolutionId { get; set; }

        public string Description { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SLAItemId { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime OverwriteTime { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [Required]
        [StringLength(160)]
        public string Name { get; set; }

        public int? FailureAfter { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public decimal? ExchangeRate { get; set; }

        public string SuccessConditionsXml { get; set; }

        public Guid SLAItemIdUnique { get; set; }

        public int? SequenceNumber { get; set; }

        public int? WarnAfter { get; set; }

        public Guid? SLAId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public bool IsManaged { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }
    }
}
