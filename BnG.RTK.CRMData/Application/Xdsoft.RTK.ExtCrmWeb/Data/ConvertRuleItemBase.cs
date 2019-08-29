namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConvertRuleItemBase")]
    public partial class ConvertRuleItemBase
    {
        public DateTime? ModifiedOn { get; set; }

        public Guid? ConditionId { get; set; }

        public Guid ConvertRuleItemIdUnique { get; set; }

        public Guid ConvertRuleId { get; set; }

        public Guid? QueueId { get; set; }

        public bool IsManaged { get; set; }

        public int? SequenceNumber { get; set; }

        public string PropertiesXml { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid SolutionId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public Guid? CreatedBy { get; set; }

        public string ConditionXml { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime OverwriteTime { get; set; }

        public Guid? ModifiedBy { get; set; }

        public decimal? ExchangeRate { get; set; }

        public DateTime? CreatedOn { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid ConvertRuleItemId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public string Description { get; set; }

        public Guid? WorkflowId { get; set; }
    }
}
