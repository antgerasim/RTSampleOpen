namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_commercial_offerBase
    {
        [Key]
        public Guid new_commercial_offerId { get; set; }

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
        public string new_code { get; set; }

        public decimal? new_sum { get; set; }

        public DateTime? new_preparation_date { get; set; }

        public DateTime? new_send_date { get; set; }

        public Guid? new_link_account_id { get; set; }

        public Guid? new_link_activity_id { get; set; }

        public string new_solution_architecture_description { get; set; }

        public string new_realisation_scheme_description { get; set; }

        public string new_deal_passport_description { get; set; }

        public string new_contractor_commercial_offer_description { get; set; }

        public virtual AccountBase AccountBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual new_t_activityBase new_t_activityBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
