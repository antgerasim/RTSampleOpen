namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SqlEncryptionAudit")]
    public partial class SqlEncryptionAudit
    {
        [Key]
        public DateTime CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }
    }
}
