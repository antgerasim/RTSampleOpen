namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_revenue_by_yearBase
    {
        [Key]
        public Guid new_revenue_by_yearId { get; set; }

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

        public bool? new_RSBU_MSFO_sign { get; set; }

        public int? new_year { get; set; }

        public decimal? new_possible_revenue_rsbu { get; set; }

        public decimal? new_possible_revenue_msfo { get; set; }

        public Guid? new_link_revenue_by_year_Id { get; set; }

        public decimal? new_sum_VAT_to_close_in_particular_rsbu { get; set; }

        public decimal? new_sum_VAT_to_close_in_particular_msfo { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual new_project_initiativeBase new_project_initiativeBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
