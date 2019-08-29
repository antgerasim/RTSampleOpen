namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_plan_factBase
    {
        [Key]
        public Guid new_plan_factId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid OwnerId { get; set; }

        public int OwnerIdType { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public int statecode { get; set; }

        public int? statuscode { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        [StringLength(100)]
        public string new_name { get; set; }

        public int? new_year { get; set; }

        public decimal? new_plan { get; set; }

        public decimal? new_fact { get; set; }

        public Guid? new_link_profit_contract_Id { get; set; }

        public Guid? new_link_expense_contract_Id { get; set; }

        public int? new_month { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual new_expense_contractBase new_expense_contractBase { get; set; }

        public virtual new_profit_contractBase new_profit_contractBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
