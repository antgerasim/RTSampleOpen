namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserEntityUISettingsBase")]
    public partial class UserEntityUISettingsBase
    {
        public string RecentlyViewedXml { get; set; }

        [Key]
        public Guid UserEntityUISettingsId { get; set; }

        public string LookupMRUXml { get; set; }

        public string InsertIntoEmailMRUXml { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public Guid OwnerId { get; set; }

        public int ObjectTypeCode { get; set; }

        public string ReadingPaneXml { get; set; }

        public string TabOrderXml { get; set; }

        public string LastViewedFormXml { get; set; }

        public string MRUXml { get; set; }

        public bool? ShowInAddressBook { get; set; }

        public int OwnerIdType { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
