namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImportJobBase")]
    public partial class ImportJobBase
    {
        public DateTime? CompletedOn { get; set; }

        public DateTime? StartedOn { get; set; }

        [Key]
        public Guid ImportJobId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public string Data { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(256)]
        public string Name { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [StringLength(256)]
        public string SolutionName { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public double? Progress { get; set; }

        public Guid? ModifiedBy { get; set; }
    }
}
