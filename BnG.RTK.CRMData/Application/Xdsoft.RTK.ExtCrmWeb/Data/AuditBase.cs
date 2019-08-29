namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AuditBase")]
    public partial class AuditBase
    {
        public string AttributeMask { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid TransactionId { get; set; }

        public int? Action { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ObjectId { get; set; }

        [StringLength(1)]
        public string ObjectIdName { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid UserId { get; set; }

        public string ChangeData { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime CreatedOn { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Operation { get; set; }

        [Key]
        [Column(Order = 5)]
        public Guid AuditId { get; set; }

        public Guid? CallingUserId { get; set; }

        public int? ObjectTypeCode { get; set; }

        public Guid? RegardingObjectId { get; set; }

        [StringLength(4000)]
        public string RegardingObjectIdName { get; set; }

        [StringLength(400)]
        public string UserAdditionalInfo { get; set; }
    }
}
