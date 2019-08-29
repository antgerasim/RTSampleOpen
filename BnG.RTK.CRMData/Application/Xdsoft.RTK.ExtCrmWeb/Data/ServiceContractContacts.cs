namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ServiceContractContacts
    {
        public Guid ContractId { get; set; }

        public Guid ContactId { get; set; }

        public int? ServiceLevel { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Key]
        public Guid ServiceContractContactId { get; set; }

        public virtual ContactBase ContactBase { get; set; }

        public virtual ContractBase ContractBase { get; set; }
    }
}