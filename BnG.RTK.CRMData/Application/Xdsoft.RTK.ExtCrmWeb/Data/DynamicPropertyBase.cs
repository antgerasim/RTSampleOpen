namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DynamicPropertyBase")]
    public partial class DynamicPropertyBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DynamicPropertyBase()
        {
            DynamicPropertyBase1 = new HashSet<DynamicPropertyBase>();
            DynamicPropertyOptionSetItemBase = new HashSet<DynamicPropertyOptionSetItemBase>();
        }

        public int? MinValueInteger { get; set; }

        public Guid? RootDynamicPropertyId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(1024)]
        public string DefaultValueString { get; set; }

        public int? MaxLengthString { get; set; }

        public decimal? MaxValueDecimal { get; set; }

        public Guid? BaseDynamicPropertyId { get; set; }

        public int? Precision { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? RegardingObjectId { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? DataType { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int? DefaultValueInteger { get; set; }

        public int? MaxValueInteger { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string Description { get; set; }

        public bool IsRequired { get; set; }

        public Guid? OverwrittenDynamicPropertyId { get; set; }

        public Guid? DefaultValueOptionSet { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public Guid? ModifiedBy { get; set; }

        public decimal? MinValueDecimal { get; set; }

        public int? statecode { get; set; }

        public bool IsHidden { get; set; }

        public bool IsReadOnly { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid OrganizationId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int? statuscode { get; set; }

        public double? DefaultValueDouble { get; set; }

        public double? MinValueDouble { get; set; }

        public double? MaxValueDouble { get; set; }

        [Key]
        public Guid DynamicPropertyId { get; set; }

        public decimal? DefaultValueDecimal { get; set; }

        public int? RegardingObjectTypeCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DynamicPropertyBase> DynamicPropertyBase1 { get; set; }

        public virtual DynamicPropertyBase DynamicPropertyBase2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DynamicPropertyOptionSetItemBase> DynamicPropertyOptionSetItemBase { get; set; }
    }
}
