namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TopicBase")]
    public partial class TopicBase
    {
        public Guid IncidentId { get; set; }

        [StringLength(512)]
        public string KeyPhrase { get; set; }

        [Key]
        public Guid TopicId { get; set; }

        public int? Score { get; set; }
    }
}
