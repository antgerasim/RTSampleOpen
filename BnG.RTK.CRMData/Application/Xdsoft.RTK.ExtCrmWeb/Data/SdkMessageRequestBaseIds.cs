namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SdkMessageRequestBaseIds
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SdkMessageRequestBaseIds()
        {
            SdkMessageRequestFieldBase = new HashSet<SdkMessageRequestFieldBase>();
            SdkMessageResponseBase = new HashSet<SdkMessageResponseBase>();
        }

        [Key]
        public Guid SdkMessageRequestId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessageRequestFieldBase> SdkMessageRequestFieldBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessageResponseBase> SdkMessageResponseBase { get; set; }
    }
}
