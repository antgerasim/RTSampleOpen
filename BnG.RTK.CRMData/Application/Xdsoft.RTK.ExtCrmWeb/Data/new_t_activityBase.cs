namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_t_activityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public new_t_activityBase()
        {
            ContactBase = new HashSet<ContactBase>();
            new_commercial_offerBase = new HashSet<new_commercial_offerBase>();
            new_project_initiativeBase1 = new HashSet<new_project_initiativeBase>();
            new_purchaseBase = new HashSet<new_purchaseBase>();
            new_t_account_needBase = new HashSet<new_t_account_needBase>();
            new_t_project_riskBase = new HashSet<new_t_project_riskBase>();
            TaskBase = new HashSet<TaskBase>();
        }

        [Key]
        public Guid new_t_activityId { get; set; }

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

        [StringLength(100)]
        public string new_possible_content_of_works { get; set; }

        public Guid? new_link_account_activity { get; set; }

        public Guid? new_link_product_activity { get; set; }

        public Guid? new_d_forms_of_possible_income_id { get; set; }

        public Guid? new_d_possible_legal_form_id { get; set; }

        public Guid? new_link_d_businessunit_t_activity { get; set; }

        public Guid? processid { get; set; }

        public Guid? stageid { get; set; }

        [StringLength(1250)]
        public string traversedpath { get; set; }

        public Guid? new_new_d_sphere_of_activityId { get; set; }

        public int? new_NegotiationStatus { get; set; }

        public decimal? new_possible_amount_of_investments { get; set; }

        public int? new_QuantityOfOpenTasks { get; set; }

        public DateTime? new_QuantityOfOpenTasks_Date { get; set; }

        public int? new_QuantityOfOpenTasks_State { get; set; }

        public decimal? new_possible_revenue_rsbu { get; set; }

        public string new_description { get; set; }

        public string new_reason_for_refusal { get; set; }

        [StringLength(100)]
        public string new_TEO_number { get; set; }

        public decimal? new_possible_revenue_msfo { get; set; }

        public bool? new_RSBU_MSFO_sign { get; set; }

        public bool? new_Is_Negotiation_Ended { get; set; }

        public bool? new_Is_Stage_Ended { get; set; }

        public int? new_Quantity_Of_Negotiations { get; set; }

        public DateTime? new_Quantity_Of_Negotiations_Date { get; set; }

        public int? new_Quantity_Of_Negotiations_State { get; set; }

        public int? new_Amount_Of_Negotiated_Tasks { get; set; }

        public int? new_RSBU_MSFO_mark { get; set; }

        public int? new_Quantity_Of_Negotiations_Manual { get; set; }

        [StringLength(100)]
        public string new_subject { get; set; }

        [StringLength(100)]
        public string new_demand_period { get; set; }

        public int? new_msg_type { get; set; }

        [StringLength(1000)]
        public string new_msg_text { get; set; }

        public Guid? new_link_project_initiative_id { get; set; }

        public Guid? new_StepId { get; set; }

        public Guid? new_StageId { get; set; }

        public DateTime? new_StepDateStart { get; set; }

        [StringLength(100)]
        public string new_ID { get; set; }

        public Guid? new_KeyTask_TaskId { get; set; }

        public Guid? new_RouteId { get; set; }

        public int? new_purchase_count { get; set; }

        public DateTime? new_purchase_count_Date { get; set; }

        public int? new_purchase_count_State { get; set; }

        public bool? new_relation_activity_purchase { get; set; }

        public Guid? new_link_territory_id { get; set; }

        public Guid? new_link_businessunit_MRF_id { get; set; }

        public virtual AccountBase AccountBase { get; set; }

        public virtual ActivityPointerBase ActivityPointerBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase1 { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactBase> ContactBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_commercial_offerBase> new_commercial_offerBase { get; set; }

        public virtual new_d_forms_of_possible_incomeBase new_d_forms_of_possible_incomeBase { get; set; }

        public virtual new_d_possible_legal_formBase new_d_possible_legal_formBase { get; set; }

        public virtual new_d_product_catalogBase new_d_product_catalogBase { get; set; }

        public virtual new_d_sphere_of_activityBase new_d_sphere_of_activityBase { get; set; }

        public virtual new_project_initiativeBase new_project_initiativeBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_project_initiativeBase> new_project_initiativeBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_purchaseBase> new_purchaseBase { get; set; }

        public virtual new_RouteBase new_RouteBase { get; set; }

        public virtual new_StageBase new_StageBase { get; set; }

        public virtual new_StepBase new_StepBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_account_needBase> new_t_account_needBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_t_project_riskBase> new_t_project_riskBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskBase> TaskBase { get; set; }

        public virtual new_territoryBase new_territoryBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
