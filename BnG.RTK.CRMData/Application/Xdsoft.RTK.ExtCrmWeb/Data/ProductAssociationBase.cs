namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductAssociationBase")]
    public partial class ProductAssociationBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductAssociationBase()
        {
            InvoiceDetailBase = new HashSet<InvoiceDetailBase>();
            OpportunityProductBase = new HashSet<OpportunityProductBase>();
            QuoteDetailBase = new HashSet<QuoteDetailBase>();
            SalesOrderDetailBase = new HashSet<SalesOrderDetailBase>();
        }

        public Guid AssociatedProduct { get; set; }

        public Guid ProductId { get; set; }

        [Key]
        public Guid ProductAssociationId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid? UoMId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public decimal? ExchangeRate { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public int? statuscode { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public decimal? Quantity { get; set; }

        public int? ProductIsRequired { get; set; }

        public int statecode { get; set; }

        public int PropertyCustomizationStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceDetailBase> InvoiceDetailBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpportunityProductBase> OpportunityProductBase { get; set; }

        public virtual ProductBase ProductBase { get; set; }

        public virtual ProductBase ProductBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuoteDetailBase> QuoteDetailBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderDetailBase> SalesOrderDetailBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
