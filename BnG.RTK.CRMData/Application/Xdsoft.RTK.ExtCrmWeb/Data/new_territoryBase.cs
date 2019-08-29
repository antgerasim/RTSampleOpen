namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_territoryBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public new_territoryBase()
        {
            new_contract_planBase = new HashSet<new_contract_planBase>();
            new_expense_contractBase = new HashSet<new_expense_contractBase>();
            new_expertiseBase = new HashSet<new_expertiseBase>();
            new_profit_contractBase = new HashSet<new_profit_contractBase>();
            new_project_initiativeBase = new HashSet<new_project_initiativeBase>();
            new_successful_project_historyBase = new HashSet<new_successful_project_historyBase>();
            new_t_activityBase = new HashSet<new_t_activityBase>();
            new_t_projectBase = new HashSet<new_t_projectBase>();
        }

        [Key]
        public Guid new_territoryId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? OrganizationId { get; set; }

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

        public int? new_kd_territory { get; set; }

        [StringLength(100)]
        public string new_GADM { get; set; }

        public Guid? new_link_businessunit_id { get; set; }

        public Guid? new_link_businessunit_MRF_id { get; set; }

        [StringLength(100)]
        public string new_ISO3166_2 { get; set; }

        public int? new_polygon_mapping { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_contract_planBase> new_contract_planBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_expense_contractBase> new_expense_contractBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_expertiseBase> new_expertiseBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_profit_contractBase> new_profit_contractBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_initiativeBase> new_project_initiativeBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_successful_project_historyBase> new_successful_project_historyBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_activityBase> new_t_activityBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_projectBase> new_t_projectBase { get; set; }
    }
}
