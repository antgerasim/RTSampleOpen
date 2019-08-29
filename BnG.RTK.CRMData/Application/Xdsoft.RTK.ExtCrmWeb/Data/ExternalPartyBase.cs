namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExternalPartyBase")]
    public partial class ExternalPartyBase
    {
        public decimal? ExchangeRate { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public int? StatusCode { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? LastEnabledOn { get; set; }

        [StringLength(300)]
        public string Type { get; set; }

        public int StateCode { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public DateTime? LastDisabledOn { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid OwnerId { get; set; }

        public int? ImportSequenceNumber { get; set; }

        [StringLength(50)]
        public string CorrelationKey { get; set; }

        public Guid? ModifiedBy { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [StringLength(300)]
        public string FullName { get; set; }

        public Guid ExternalPartyIdUnique { get; set; }

        [StringLength(100)]
        public string EmailAddress { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public Guid? CreatedBy { get; set; }

        [Key]
        public Guid ExternalPartyId { get; set; }

        public int OwnerIdType { get; set; }

        [StringLength(150)]
        public string YomiLastName { get; set; }

        [StringLength(450)]
        public string YomiFullName { get; set; }

        [StringLength(150)]
        public string YomiMiddleName { get; set; }

        [StringLength(150)]
        public string YomiFirstName { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
