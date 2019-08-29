namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoalBase")]
    public partial class GoalBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GoalBase()
        {
            GoalBase1 = new HashSet<GoalBase>();
            GoalBase11 = new HashSet<GoalBase>();
        }

        public DateTime? CreatedOn { get; set; }

        [Column(TypeName = "money")]
        public decimal? ComputedTargetAsOfTodayMoney { get; set; }

        public DateTime? LastRolledupDate { get; set; }

        public Guid? RollUpQueryInprogressDecimalId { get; set; }

        public int? RollupErrorCode { get; set; }

        public DateTime? GoalStartDate { get; set; }

        public Guid? CreatedBy { get; set; }

        public int StateCode { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int? ComputedTargetAsOfTodayInteger { get; set; }

        public Guid? RollUpQueryCustomDecimalId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int? TargetInteger { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public int? InProgressInteger { get; set; }

        public DateTime? GoalEndDate { get; set; }

        public int? StatusCode { get; set; }

        public decimal? ExchangeRate { get; set; }

        public int? FiscalPeriod { get; set; }

        public bool ConsiderOnlyGoalOwnersRecords { get; set; }

        public int? Depth { get; set; }

        public decimal? InProgressDecimal { get; set; }

        public decimal? Percentage { get; set; }

        [StringLength(100)]
        public string StretchTargetString { get; set; }

        public Guid OwnerId { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public Guid? RollUpQueryInprogressMoneyId { get; set; }

        public Guid? RollupQueryActualIntegerId { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        public bool RollupOnlyFromChildGoals { get; set; }

        public Guid? TreeId { get; set; }

        public decimal? StretchTargetDecimal { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? GoalWithErrorId { get; set; }

        [Column(TypeName = "money")]
        public decimal? ActualMoney { get; set; }

        public int? FiscalYear { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public Guid? RollUpQueryCustomMoneyId { get; set; }

        public int? CustomRollupFieldInteger { get; set; }

        public Guid? RollUpQueryInprogressIntegerId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? RollUpQueryCustomIntegerId { get; set; }

        public decimal? ActualDecimal { get; set; }

        public bool? IsOverridden { get; set; }

        [StringLength(100)]
        public string ActualString { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        [StringLength(100)]
        public string TargetString { get; set; }

        public bool? IsOverride { get; set; }

        public decimal? CustomRollupFieldDecimal { get; set; }

        public Guid? RollUpQueryActualMoneyId { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public bool? IsFiscalPeriodGoal { get; set; }

        public Guid? RollUpQueryActualDecimalId { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public decimal? ComputedTargetAsOfTodayDecimal { get; set; }

        public decimal? TargetDecimal { get; set; }

        [Column(TypeName = "money")]
        public decimal? StretchTargetMoney { get; set; }

        [StringLength(100)]
        public string InProgressString { get; set; }

        [Column(TypeName = "money")]
        public decimal? TargetMoney { get; set; }

        public Guid? MetricId { get; set; }

        [Column(TypeName = "money")]
        public decimal? InProgressMoney { get; set; }

        public Guid? GoalOwnerId { get; set; }

        [StringLength(100)]
        public string CustomRollupFieldString { get; set; }

        [Key]
        public Guid GoalId { get; set; }

        public decimal? ComputedTargetAsOfTodayPercentageAchieved { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomRollupFieldMoney { get; set; }

        public Guid? ParentGoalId { get; set; }

        public int? ActualInteger { get; set; }

        public int? StretchTargetInteger { get; set; }

        public int OwnerIdType { get; set; }

        public int? GoalOwnerIdType { get; set; }

        [StringLength(4000)]
        public string GoalOwnerIdName { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomRollupFieldMoney_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? ActualMoney_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? TargetMoney_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? StretchTargetMoney_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? InProgressMoney_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? ComputedTargetAsOfTodayMoney_Base { get; set; }

        [StringLength(4000)]
        public string GoalOwnerIdYomiName { get; set; }

        public Guid? EntityImageId { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoalBase> GoalBase1 { get; set; }

        public virtual GoalBase GoalBase2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoalBase> GoalBase11 { get; set; }

        public virtual GoalBase GoalBase3 { get; set; }

        public virtual GoalRollupQueryBase GoalRollupQueryBase { get; set; }

        public virtual GoalRollupQueryBase GoalRollupQueryBase1 { get; set; }

        public virtual GoalRollupQueryBase GoalRollupQueryBase2 { get; set; }

        public virtual GoalRollupQueryBase GoalRollupQueryBase3 { get; set; }

        public virtual GoalRollupQueryBase GoalRollupQueryBase4 { get; set; }

        public virtual GoalRollupQueryBase GoalRollupQueryBase5 { get; set; }

        public virtual GoalRollupQueryBase GoalRollupQueryBase6 { get; set; }

        public virtual GoalRollupQueryBase GoalRollupQueryBase7 { get; set; }

        public virtual GoalRollupQueryBase GoalRollupQueryBase8 { get; set; }

        public virtual MetricBase MetricBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
