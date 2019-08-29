namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FilterTemplate")]
    public partial class FilterTemplate
    {
        public string FetchXml { get; set; }

        public string Description { get; set; }

        public int QueryType { get; set; }

        public Guid FilterTemplateId { get; set; }

        public int ReturnedTypeCode { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}
