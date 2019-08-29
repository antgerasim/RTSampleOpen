namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_new_account_need_new_t_account_needBase
    {
        [Key]
        public Guid new_new_account_need_new_t_account_needId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid new_account_needid { get; set; }

        public Guid new_t_account_needid { get; set; }

        public virtual new_account_needBase new_account_needBase { get; set; }

        public virtual new_t_account_needBase new_t_account_needBase { get; set; }
    }
}
