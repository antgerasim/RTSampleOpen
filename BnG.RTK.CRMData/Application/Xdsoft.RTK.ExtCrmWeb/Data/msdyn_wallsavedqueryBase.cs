namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class msdyn_wallsavedqueryBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public msdyn_wallsavedqueryBase()
        {
            msdyn_wallsavedqueryusersettingsBase = new HashSet<msdyn_wallsavedqueryusersettingsBase>();
        }

        [Key]
        public Guid msdyn_wallsavedqueryId { get; set; }

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
        public string msdyn_entityname { get; set; }

        [StringLength(100)]
        public string msdyn_entitydisplayname { get; set; }

        public bool? msdyn_IsVirtual { get; set; }

        public bool? msdyn_IsVisible { get; set; }

        public int? msdyn_isvisiblebit { get; set; }

        public int? msdyn_otc { get; set; }

        [StringLength(50)]
        public string msdyn_SavedQueryId { get; set; }

        [StringLength(100)]
        public string msdyn_savedqueryname { get; set; }

        public Guid? msdyn_postconfigurationid { get; set; }

        public virtual msdyn_PostConfigBase msdyn_PostConfigBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<msdyn_wallsavedqueryusersettingsBase> msdyn_wallsavedqueryusersettingsBase { get; set; }
    }
}
