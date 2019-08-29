namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalesLiteratureBase")]
    public partial class SalesLiteratureBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SalesLiteratureBase()
        {
            CompetitorSalesLiterature = new HashSet<CompetitorSalesLiterature>();
            ProductSalesLiterature = new HashSet<ProductSalesLiterature>();
            SalesLiteratureItemBase = new HashSet<SalesLiteratureItemBase>();
        }

        [Key]
        public Guid SalesLiteratureId { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid? EmployeeContactId { get; set; }

        public Guid? SubjectId { get; set; }

        public string Description { get; set; }

        public int? LiteratureTypeCode { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public bool? IsCustomerViewable { get; set; }

        public Guid? CreatedBy { get; set; }

        public string KeyWords { get; set; }

        public bool? HasAttachments { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public decimal? ExchangeRate { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ProcessId { get; set; }

        public Guid? StageId { get; set; }

        public Guid? EntityImageId { get; set; }

        [StringLength(1250)]
        public string TraversedPath { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompetitorSalesLiterature> CompetitorSalesLiterature { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductSalesLiterature> ProductSalesLiterature { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesLiteratureItemBase> SalesLiteratureItemBase { get; set; }

        public virtual SubjectBase SubjectBase { get; set; }

        public virtual SystemUserBase SystemUserBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
