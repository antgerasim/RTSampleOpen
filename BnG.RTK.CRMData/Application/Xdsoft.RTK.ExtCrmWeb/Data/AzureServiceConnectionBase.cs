namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AzureServiceConnectionBase")]
    public partial class AzureServiceConnectionBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AzureServiceConnectionBase()
        {
            TopicModelBase = new HashSet<TopicModelBase>();
        }

        public int StateCode { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid OrganizationId { get; set; }

        [Key]
        public Guid AzureServiceConnectionId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(160)]
        public string Name { get; set; }

        [StringLength(100)]
        public string AccountKey { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public string Description { get; set; }

        public Guid? CreatedBy { get; set; }

        public int? StatusCode { get; set; }

        public int? ConnectionType { get; set; }

        [StringLength(500)]
        public string ServiceUri { get; set; }

        public int? LastConnectionStatusCode { get; set; }

        public DateTime? LastConnectionTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TopicModelBase> TopicModelBase { get; set; }
    }
}
