namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_contract_plan_quarterBase
    {
        [Key]
        public Guid new_contract_plan_quarterId { get; set; }

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

        public Guid? new_link_product_group_id { get; set; }

        public decimal? new_112_sum_service { get; set; }

        public decimal? new_112_sum_consulting { get; set; }

        public decimal? new_RT_medicine_sum_service { get; set; }

        public decimal? new_RT_medicine_sum_consulting { get; set; }

        public int? new_quarter { get; set; }

        public Guid? new_contract_plan_year_id { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual new_contract_planBase new_contract_planBase { get; set; }

        public virtual new_d_product_groupsBase new_d_product_groupsBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
