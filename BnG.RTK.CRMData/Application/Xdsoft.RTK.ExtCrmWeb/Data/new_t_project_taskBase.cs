namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_t_project_taskBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public new_t_project_taskBase()
        {
            new_new_d_service_types_new_t_project_task2Base = new HashSet<new_new_d_service_types_new_t_project_task2Base>();
            new_new_t_contractor_new_t_project_taskBase = new HashSet<new_new_t_contractor_new_t_project_taskBase>();
            new_new_t_project_task_new_t_project_taskBase = new HashSet<new_new_t_project_task_new_t_project_taskBase>();
            new_new_t_project_task_new_t_project_taskBase1 = new HashSet<new_new_t_project_task_new_t_project_taskBase>();
            new_t_contractorBase = new HashSet<new_t_contractorBase>();
            new_t_projectBase3 = new HashSet<new_t_projectBase>();
            new_t_project_taskBase1 = new HashSet<new_t_project_taskBase>();
        }

        [Key]
        public Guid new_t_project_taskId { get; set; }

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
        public string new_task_name { get; set; }

        public string new_task_content { get; set; }

        [Column(TypeName = "money")]
        public decimal? new_cost { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public decimal? ExchangeRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? new_cost_Base { get; set; }

        public DateTime? new_dt_st_plan { get; set; }

        public DateTime? new_dt_st_fact { get; set; }

        public DateTime? new_dt_complete_plan { get; set; }

        public int? new_milestone_sign { get; set; }

        public decimal? new_complete_percent { get; set; }

        public Guid? new_parent_task { get; set; }

        public Guid? new_project_task_link { get; set; }

        public Guid? new_service_type { get; set; }

        public int? new_priznak_etapa { get; set; }

        public int? new_complete_mark { get; set; }

        public Guid? new_link_t_project_t_task_stages { get; set; }

        public Guid? new_veha { get; set; }

        public Guid? new_link_department_project_task { get; set; }

        public DateTime? new_dt_complete_fact { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? new_expired_task_mark { get; set; }

        public int? new_task_weight { get; set; }

        public bool? new_IsEscalated { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase1 { get; set; }

        public virtual new_d_service_typesBase new_d_service_typesBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_new_d_service_types_new_t_project_task2Base> new_new_d_service_types_new_t_project_task2Base { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_new_t_contractor_new_t_project_taskBase> new_new_t_contractor_new_t_project_taskBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_new_t_project_task_new_t_project_taskBase> new_new_t_project_task_new_t_project_taskBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_new_t_project_task_new_t_project_taskBase> new_new_t_project_task_new_t_project_taskBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_contractorBase> new_t_contractorBase { get; set; }

        public virtual new_t_projectBase new_t_projectBase { get; set; }

        public virtual new_t_projectBase new_t_projectBase1 { get; set; }

        public virtual new_t_projectBase new_t_projectBase2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_projectBase> new_t_projectBase3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_project_taskBase> new_t_project_taskBase1 { get; set; }

        public virtual new_t_project_taskBase new_t_project_taskBase2 { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
