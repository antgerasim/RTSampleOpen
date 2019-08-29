namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AccountLeads
    {
        public Guid AccountId { get; set; }

        public Guid LeadId { get; set; }

        [Key]
        public Guid AccountLeadId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public virtual AccountBase AccountBase { get; set; }

        public virtual LeadBase LeadBase { get; set; }
    }
}
