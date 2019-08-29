namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class msdyn_wallsavedqueryusersettingsBase
    {
        [Key]
        public Guid msdyn_wallsavedqueryusersettingsId { get; set; }

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
        public string msdyn_entityname { get; set; }

        public string msdyn_data { get; set; }

        public int? msdyn_default { get; set; }

        [StringLength(100)]
        public string msdyn_entitydisplayname { get; set; }

        public bool? msdyn_includewallinresponse { get; set; }

        public bool? msdyn_isfollowing { get; set; }

        public bool? msdyn_IsVirtual { get; set; }

        public bool? msdyn_isvisible { get; set; }

        public int? msdyn_isvisiblebit { get; set; }

        public int? msdyn_otc { get; set; }

        [StringLength(100)]
        public string msdyn_savedqueryname { get; set; }

        public int? msdyn_sortorder { get; set; }

        public int? msdyn_type { get; set; }

        public Guid? msdyn_userid { get; set; }

        public Guid? msdyn_wallsavedqueryid { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual msdyn_wallsavedqueryBase msdyn_wallsavedqueryBase { get; set; }

        public virtual SystemUserBase SystemUserBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
