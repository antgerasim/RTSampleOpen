namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConvertRuleBase")]
    public partial class ConvertRuleBase
    {
        [Key]
        [Column(Order = 0)]
        public Guid SolutionId { get; set; }

        public bool? AllowUnknownSender { get; set; }

        public bool? SendAutomaticResponse { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public bool? CheckBlockedSocialProfile { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime OverwriteTime { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? CheckDirectMessages { get; set; }

        public int? StatusCode { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public bool? CheckActiveEntitlement { get; set; }

        public Guid? ResponseTemplateId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public bool? CheckIfResolved { get; set; }

        public string Description { get; set; }

        public decimal? ExchangeRate { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public Guid? QueueId { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid ConvertRuleId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int StateCode { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid OwnerId { get; set; }

        public Guid ConvertRuleIdUnique { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public int? SourceTypeCode { get; set; }

        public bool IsManaged { get; set; }

        public Guid? WorkflowId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int? ResolvedSince { get; set; }

        public int OwnerIdType { get; set; }

        public int? SourceChannelTypeCode { get; set; }

        [Required]
        [StringLength(25)]
        public string RecordVersion { get; set; }

        public Guid? ChannelPropertyGroupId { get; set; }
    }
}
