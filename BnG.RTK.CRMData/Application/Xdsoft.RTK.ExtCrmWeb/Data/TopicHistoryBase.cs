namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TopicHistoryBase")]
    public partial class TopicHistoryBase
    {
        public int? Weight { get; set; }

        public Guid? TopicModelExecutionHistoryId { get; set; }

        [Key]
        public Guid TopicHistoryId { get; set; }

        [StringLength(512)]
        public string KeyPhrase { get; set; }

        public virtual TopicModelExecutionHistoryBase TopicModelExecutionHistoryBase { get; set; }
    }
}
