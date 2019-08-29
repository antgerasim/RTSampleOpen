namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LetterBase")]
    public partial class LetterBase
    {
        [Key]
        public Guid ActivityId { get; set; }

        public virtual ActivityPointerBase ActivityPointerBase { get; set; }
    }
}
