namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class msdyn_PostConfigBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public msdyn_PostConfigBase()
        {
            msdyn_PostRuleConfigBase = new HashSet<msdyn_PostRuleConfigBase>();
            msdyn_wallsavedqueryBase = new HashSet<msdyn_wallsavedqueryBase>();
        }

        [Key]
        public Guid msdyn_PostConfigId { get; set; }

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
        public string msdyn_EntityDisplayName { get; set; }

        public bool? msdyn_ConfigureWall { get; set; }

        [StringLength(100)]
        public string msdyn_EntityName { get; set; }

        [StringLength(100)]
        public string msdyn_FollowingViewId { get; set; }

        [StringLength(100)]
        public string msdyn_FollowingViewId2 { get; set; }

        public int? msdyn_Otc { get; set; }

        public string msdyn_Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<msdyn_PostRuleConfigBase> msdyn_PostRuleConfigBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<msdyn_wallsavedqueryBase> msdyn_wallsavedqueryBase { get; set; }
    }
}
