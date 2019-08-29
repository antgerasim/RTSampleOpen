namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_new_profit_contract_new_expense_contracBase
    {
        [Key]
        public Guid new_new_profit_contract_new_expense_contracId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid new_profit_contractid { get; set; }

        public Guid new_expense_contractid { get; set; }

        public virtual new_expense_contractBase new_expense_contractBase { get; set; }

        public virtual new_profit_contractBase new_profit_contractBase { get; set; }
    }
}
