namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_t_projectBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public new_t_projectBase()
        {
            new_new_d_product_catalog_new_t_projectBase = new HashSet<new_new_d_product_catalog_new_t_projectBase>();
            new_new_t_project_new_t_projectBase = new HashSet<new_new_t_project_new_t_projectBase>();
            new_new_t_project_new_t_projectBase1 = new HashSet<new_new_t_project_new_t_projectBase>();
            new_product_of_projectBase = new HashSet<new_product_of_projectBase>();
            new_profit_contractBase = new HashSet<new_profit_contractBase>();
            new_project_calculation_parametrBase = new HashSet<new_project_calculation_parametrBase>();
            new_project_project_reporting_indexBase = new HashSet<new_project_project_reporting_indexBase>();
            new_project_reporting_indexBase = new HashSet<new_project_reporting_indexBase>();
            new_project_reportingBase = new HashSet<new_project_reportingBase>();
            new_successful_project_historyBase = new HashSet<new_successful_project_historyBase>();
            new_t_contractorBase = new HashSet<new_t_contractorBase>();
            new_t_project_riskBase = new HashSet<new_t_project_riskBase>();
            new_t_project_taskBase = new HashSet<new_t_project_taskBase>();
            new_t_project_taskBase1 = new HashSet<new_t_project_taskBase>();
            new_t_project_taskBase2 = new HashSet<new_t_project_taskBase>();
        }

        [Key]
        public Guid new_t_projectId { get; set; }

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
        public string new_project_name { get; set; }

        public Guid? new_project_type { get; set; }

        public string new_description { get; set; }

        [StringLength(100)]
        public string new_control_center { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public decimal? ExchangeRate { get; set; }

        public DateTime? new_fact_dt_st { get; set; }

        public DateTime? new_dt_st_plan { get; set; }

        public DateTime? new_dt_end_plan { get; set; }

        public DateTime? new_dt_end_fact { get; set; }

        public string new_project_team { get; set; }

        public Guid? new_project_initiative_project { get; set; }

        public DateTime? new_next_milestone { get; set; }

        public Guid? new_link_department_project { get; set; }

        public decimal? new_profitable_budget { get; set; }

        public decimal? new_expendable_budget_OPEX { get; set; }

        public decimal? new_expendable_budget_CAPEX { get; set; }

        public Guid? new_link_milestone_Id { get; set; }

        public Guid? new_link_curator_Id { get; set; }

        public decimal? new_IRR { get; set; }

        public decimal? new_NPV { get; set; }

        public Guid? new_link_sphere_of_activity_Id { get; set; }

        public Guid? new_link_territory_project { get; set; }

        public Guid? new_link_account_Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? new_Milestone_Type { get; set; }

        public virtual AccountBase AccountBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase1 { get; set; }

        public virtual new_d_product_typesBase new_d_product_typesBase { get; set; }

        public virtual new_d_sphere_of_activityBase new_d_sphere_of_activityBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_new_d_product_catalog_new_t_projectBase> new_new_d_product_catalog_new_t_projectBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_new_t_project_new_t_projectBase> new_new_t_project_new_t_projectBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_new_t_project_new_t_projectBase> new_new_t_project_new_t_projectBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_product_of_projectBase> new_product_of_projectBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_profit_contractBase> new_profit_contractBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_calculation_parametrBase> new_project_calculation_parametrBase { get; set; }

        public virtual new_project_initiativeBase new_project_initiativeBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_project_reporting_indexBase> new_project_project_reporting_indexBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_reporting_indexBase> new_project_reporting_indexBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_reportingBase> new_project_reportingBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_successful_project_historyBase> new_successful_project_historyBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_contractorBase> new_t_contractorBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_project_riskBase> new_t_project_riskBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_project_taskBase> new_t_project_taskBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_project_taskBase> new_t_project_taskBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_project_taskBase> new_t_project_taskBase2 { get; set; }

        public virtual new_t_project_taskBase new_t_project_taskBase3 { get; set; }

        public virtual new_territoryBase new_territoryBase { get; set; }

        public virtual SystemUserBase SystemUserBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
