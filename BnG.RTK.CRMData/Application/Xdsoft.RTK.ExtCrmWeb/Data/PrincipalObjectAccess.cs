namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrincipalObjectAccess")]
    public partial class PrincipalObjectAccess
    {
        public Guid PrincipalId { get; set; }

        public Guid ObjectId { get; set; }

        public int ObjectTypeCode { get; set; }

        public int? PrincipalTypeCode { get; set; }

        public int? AccessRightsMask { get; set; }

        public DateTime? ChangedOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int InheritedAccessRightsMask { get; set; }

        public Guid PrincipalObjectAccessId { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }
    }
}
