namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TraceLogBase")]
    public partial class TraceLogBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TraceLogBase()
        {
            TraceAssociationBase = new HashSet<TraceAssociationBase>();
            TraceLogBase1 = new HashSet<TraceLogBase>();
        }

        public string TraceActionXml { get; set; }

        public int? TraceParameterHash { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int? CollationLevel { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public string TraceDetailXml { get; set; }

        public int? Level { get; set; }

        public bool? CanBeDeleted { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid TraceRegardingId { get; set; }

        public string TraceParameterXml { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid CreatedBy { get; set; }

        public int TraceCode { get; set; }

        public Guid? ParentTraceLogId { get; set; }

        [Key]
        public Guid TraceLogId { get; set; }

        [StringLength(2000)]
        public string Text { get; set; }

        public Guid OrganizationId { get; set; }

        public bool? IsUnique { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        [StringLength(160)]
        public string MachineName { get; set; }

        public bool? TraceStatus { get; set; }

        [StringLength(160)]
        public string ErrorTypeDisplay { get; set; }

        [StringLength(1024)]
        public string ErrorDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TraceAssociationBase> TraceAssociationBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TraceLogBase> TraceLogBase1 { get; set; }

        public virtual TraceLogBase TraceLogBase2 { get; set; }

        public virtual TraceRegardingBase TraceRegardingBase { get; set; }
    }
}
