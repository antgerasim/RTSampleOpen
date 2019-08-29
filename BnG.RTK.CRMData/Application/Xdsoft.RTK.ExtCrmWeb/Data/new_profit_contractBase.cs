namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_profit_contractBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public new_profit_contractBase()
        {
            new_contract_string_historyBase = new HashSet<new_contract_string_historyBase>();
            new_contract_stringBase = new HashSet<new_contract_stringBase>();
            new_expertiseBase1 = new HashSet<new_expertiseBase>();
            new_new_profit_contract_new_expense_contracBase = new HashSet<new_new_profit_contract_new_expense_contracBase>();
            new_plan_factBase = new HashSet<new_plan_factBase>();
            new_t_ActBase = new HashSet<new_t_ActBase>();
            new_t_contract_productBase = new HashSet<new_t_contract_productBase>();
        }

        [Key]
        public Guid new_profit_contractId { get; set; }

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

        public Guid? new_link_project_profit_contract { get; set; }

        public DateTime? new_dt_en { get; set; }

        public DateTime? new_dt_st { get; set; }

        public DateTime? new_dt_sign { get; set; }

        public DateTime? new_dt_execute { get; set; }

        public Guid? new_link_businessunit_profit_contract { get; set; }

        public Guid? new_link_account_profit_contract { get; set; }

        public string new_subject_of_contract { get; set; }

        public bool? new_expertise_send_sign { get; set; }

        public bool? new_expertise_send_approval_sign { get; set; }

        [StringLength(100)]
        public string new_TEO_number { get; set; }

        public decimal? new_discount_sum_wo_VAT_fact { get; set; }

        public bool? new_Discount_sign { get; set; }

        public Guid? new_link_territory_Id { get; set; }

        public string new_content_of_works { get; set; }

        public Guid? new_link_product_group_Id { get; set; }

        public Guid? new_link_sphere_of_activity_Id { get; set; }

        public decimal? new_profit_contract_sum { get; set; }

        public DateTime? new_profit_contract_sum_Date { get; set; }

        public int? new_profit_contract_sum_State { get; set; }

        public Guid? new_expertiseId { get; set; }

        [StringLength(100)]
        public string new_contract_number_integration { get; set; }

        [StringLength(100)]
        public string new_integration_system_id { get; set; }

        public virtual AccountBase AccountBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_contract_string_historyBase> new_contract_string_historyBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_contract_stringBase> new_contract_stringBase { get; set; }

        public virtual new_d_product_groupsBase new_d_product_groupsBase { get; set; }

        public virtual new_d_sphere_of_activityBase new_d_sphere_of_activityBase { get; set; }

        public virtual new_expertiseBase new_expertiseBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_expertiseBase> new_expertiseBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_new_profit_contract_new_expense_contracBase> new_new_profit_contract_new_expense_contracBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_plan_factBase> new_plan_factBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_ActBase> new_t_ActBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_contract_productBase> new_t_contract_productBase { get; set; }

        public virtual new_t_projectBase new_t_projectBase { get; set; }

        public virtual new_territoryBase new_territoryBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
