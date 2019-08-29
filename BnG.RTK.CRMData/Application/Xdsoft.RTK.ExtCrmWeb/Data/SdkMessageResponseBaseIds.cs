namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SdkMessageResponseBaseIds
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SdkMessageResponseBaseIds()
        {
            SdkMessageResponseFieldBase = new HashSet<SdkMessageResponseFieldBase>();
        }

        [Key]
        public Guid SdkMessageResponseId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SdkMessageResponseFieldBase> SdkMessageResponseFieldBase { get; set; }
    }
}
