namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmailHashBase")]
    public partial class EmailHashBase
    {
        public int HashType { get; set; }

        public int Hash { get; set; }

        [Key]
        public Guid EmailHashId { get; set; }

        public Guid? ActivityId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public virtual ActivityPointerBase ActivityPointerBase { get; set; }

        public virtual ActivityPointerBase ActivityPointerBase1 { get; set; }
    }
}
