namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_businessunit_roleBase
    {
        [Key]
        public Guid new_businessunit_roleId { get; set; }

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

        public Guid? new_businessunit_Id { get; set; }

        public Guid? new_systemuser_Id { get; set; }

        public Guid? new_sphere_of_activity_Id { get; set; }

        public int? new_role { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual new_d_sphere_of_activityBase new_d_sphere_of_activityBase { get; set; }

        public virtual SystemUserBase SystemUserBase { get; set; }
    }
}
