namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_expertiseBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public new_expertiseBase()
        {
            new_licenseBase = new HashSet<new_licenseBase>();
            new_profit_contractBase = new HashSet<new_profit_contractBase>();
            new_t_ActBase = new HashSet<new_t_ActBase>();
            new_new_package_of_documents_new_expertiseBase = new HashSet<new_new_package_of_documents_new_expertiseBase>();
        }

        [Key]
        public Guid new_expertiseId { get; set; }

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

        public Guid? new_license_Id { get; set; }

        public Guid? new_profit_contract_Id { get; set; }

        public string new_comment { get; set; }

        public Guid? new_act_id { get; set; }

        [StringLength(1000)]
        public string new_link { get; set; }

        public Guid? new_link_territory_Id { get; set; }

        public Guid? new_link_businessunit_Id { get; set; }

        public Guid? new_link_product_group_Id { get; set; }

        public Guid? new_link_sphere_of_activity_Id { get; set; }

        public string new_subject_of_contract { get; set; }

        public int? new_service_type { get; set; }

        public DateTime? new_act_date { get; set; }

        public decimal? new_act_sum { get; set; }

        public string new_act_description { get; set; }

        public int? new_expertise_type { get; set; }

        public DateTime? new_licenseEndDate { get; set; }

        public DateTime? new_licenseStartDate { get; set; }

        [StringLength(100)]
        public string new_numberLicense { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase1 { get; set; }

        public virtual new_d_product_groupsBase new_d_product_groupsBase { get; set; }

        public virtual new_d_sphere_of_activityBase new_d_sphere_of_activityBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_licenseBase> new_licenseBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_profit_contractBase> new_profit_contractBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_ActBase> new_t_ActBase { get; set; }

        public virtual new_licenseBase new_licenseBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_new_package_of_documents_new_expertiseBase> new_new_package_of_documents_new_expertiseBase { get; set; }

        public virtual new_profit_contractBase new_profit_contractBase1 { get; set; }

        public virtual new_t_ActBase new_t_ActBase1 { get; set; }

        public virtual new_territoryBase new_territoryBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
