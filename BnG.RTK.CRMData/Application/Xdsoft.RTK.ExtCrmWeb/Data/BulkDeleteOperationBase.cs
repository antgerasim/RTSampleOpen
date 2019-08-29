namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BulkDeleteOperationBase")]
    public partial class BulkDeleteOperationBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BulkDeleteOperationBase()
        {
            BulkDeleteFailureBase = new HashSet<BulkDeleteFailureBase>();
        }

        public Guid? OwningUser { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Key]
        public Guid BulkDeleteOperationId { get; set; }

        public bool IsRecurring { get; set; }

        public int? ProcessingQEIndex { get; set; }

        public Guid? AsyncOperationId { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public string OrderedQuerySetXml { get; set; }

        public int? FailureCount { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? SuccessCount { get; set; }

        public DateTime CreatedOn { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid OwnerId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int OwnerIdType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BulkDeleteFailureBase> BulkDeleteFailureBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }
    }
}
