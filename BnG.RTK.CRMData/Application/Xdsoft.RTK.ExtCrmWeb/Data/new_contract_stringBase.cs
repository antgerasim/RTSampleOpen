namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_contract_stringBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public new_contract_stringBase()
        {
            new_contract_string_historyBase = new HashSet<new_contract_string_historyBase>();
        }

        [Key]
        public Guid new_contract_stringId { get; set; }

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

        public Guid? new_linkexpense_contract_contract_str { get; set; }

        public Guid? new_link_profit_contract_contract_str { get; set; }

        public Guid? new_article_of_profit_and_expense_Id { get; set; }

        public decimal? new_sum { get; set; }

        [StringLength(100)]
        public string new_code { get; set; }

        [StringLength(100)]
        public string new_cor_period { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual new_article_of_Profit_and_ExpenseBase new_article_of_Profit_and_ExpenseBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_contract_string_historyBase> new_contract_string_historyBase { get; set; }

        public virtual new_expense_contractBase new_expense_contractBase { get; set; }

        public virtual new_profit_contractBase new_profit_contractBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
