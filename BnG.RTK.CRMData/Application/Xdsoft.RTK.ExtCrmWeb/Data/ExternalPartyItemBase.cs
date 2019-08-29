namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExternalPartyItemBase")]
    public partial class ExternalPartyItemBase
    {
        public DateTime? LastEnabledOn { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public Guid? ChannelAccessProfileId { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public int StateCode { get; set; }

        [Key]
        public Guid ExternalPartyItemId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? RegardingObjectId { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int? StatusCode { get; set; }

        public decimal? ExchangeRate { get; set; }

        public Guid? ExternalPartyId { get; set; }

        [StringLength(48)]
        public string IntroducedVersion { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(300)]
        public string Name { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? LastDisabledOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [StringLength(4000)]
        public string RegardingObjectIdYomiName { get; set; }

        public int? RegardingObjectTypeCode { get; set; }

        [StringLength(4000)]
        public string RegardingObjectIdName { get; set; }
    }
}
