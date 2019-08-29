namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ContactOrders
    {
        public Guid SalesOrderId { get; set; }

        public Guid ContactId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Key]
        public Guid ContactOrderId { get; set; }

        public virtual ContactBase ContactBase { get; set; }

        public virtual SalesOrderBase SalesOrderBase { get; set; }
    }
}
