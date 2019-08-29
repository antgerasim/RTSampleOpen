namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_t_contractorBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public new_t_contractorBase()
        {
            new_new_t_contractor_new_t_project_taskBase = new HashSet<new_new_t_contractor_new_t_project_taskBase>();
            new_t_contractorBase1 = new HashSet<new_t_contractorBase>();
        }

        [Key]
        public Guid new_t_contractorId { get; set; }

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

        public Guid? TransactionCurrencyId { get; set; }

        public decimal? ExchangeRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? new_sum { get; set; }

        [Column(TypeName = "money")]
        public decimal? new_sum_Base { get; set; }

        public Guid? new_link_t_project_t_contractor { get; set; }

        public Guid? new_child_contractor { get; set; }

        public Guid? new_account_id { get; set; }

        public Guid? new_link_expense_contract_contractor { get; set; }

        public Guid? new_link_project_stage_id { get; set; }

        public string new_content_of_works { get; set; }

        public string new_comment { get; set; }

        public int? new_claim { get; set; }

        public string new_contract_subject { get; set; }

        public decimal? new_contract_sum { get; set; }

        public virtual AccountBase AccountBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual new_expense_contractBase new_expense_contractBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_new_t_contractor_new_t_project_taskBase> new_new_t_contractor_new_t_project_taskBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_contractorBase> new_t_contractorBase1 { get; set; }

        public virtual new_t_contractorBase new_t_contractorBase2 { get; set; }

        public virtual new_t_projectBase new_t_projectBase { get; set; }

        public virtual new_t_project_taskBase new_t_project_taskBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
