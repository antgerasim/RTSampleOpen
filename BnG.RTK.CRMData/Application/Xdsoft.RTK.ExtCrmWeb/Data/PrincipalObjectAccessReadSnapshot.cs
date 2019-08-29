namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrincipalObjectAccessReadSnapshot")]
    public partial class PrincipalObjectAccessReadSnapshot
    {
        public int ObjectTypeCode { get; set; }

        public long Count { get; set; }

        public Guid PrincipalId { get; set; }

        public Guid PrincipalObjectAccessReadSnapshotId { get; set; }

        public long TeamPrincipalsCount { get; set; }

        public long ChildUserPrincipalsCount { get; set; }

        public int? RecordCountForOwnerIDPercentOfTotalRows { get; set; }

        public long? RecordCountForOwnerID { get; set; }

        public long? RecordCountForOwningBU { get; set; }

        public int? RecordCountForOwningBUPercentOfTotalRows { get; set; }

        public int? CountPercentOfTotalRows { get; set; }
    }
}
