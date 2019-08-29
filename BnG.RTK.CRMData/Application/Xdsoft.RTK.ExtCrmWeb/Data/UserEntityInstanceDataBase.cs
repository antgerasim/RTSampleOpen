namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserEntityInstanceDataBase")]
    public partial class UserEntityInstanceDataBase
    {
        public DateTime? CommonStart { get; set; }

        public DateTime? ReminderTime { get; set; }

        [StringLength(2000)]
        public string ToDoTitle { get; set; }

        [StringLength(50)]
        public string FlagRequest { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public DateTime? ToDoOrdinalDate { get; set; }

        public DateTime? DueDate { get; set; }

        public int? FlagStatus { get; set; }

        public DateTime? FlagDueBy { get; set; }

        public bool? ReminderSet { get; set; }

        public Guid? ObjectId { get; set; }

        public int? ToDoItemFlags { get; set; }

        public int ObjectTypeCode { get; set; }

        public string PersonalCategories { get; set; }

        [StringLength(50)]
        public string ToDoSubOrdinal { get; set; }

        [Key]
        public Guid UserEntityInstanceDataId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid OwnerId { get; set; }

        public DateTime? CommonEnd { get; set; }

        public DateTime? StartTime { get; set; }

        public int OwnerIdType { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
