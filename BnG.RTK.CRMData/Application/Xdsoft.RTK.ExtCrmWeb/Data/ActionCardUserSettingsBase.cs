namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ActionCardUserSettingsBase")]
    public partial class ActionCardUserSettingsBase
    {
        [Key]
        public Guid ActionCardUserSettingsId { get; set; }

        public Guid CardTypeId { get; set; }

        public bool? IsEnabled { get; set; }

        public string StringCardOption { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public int? IntCardOption { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid OwnerId { get; set; }

        public bool? BoolCardOption { get; set; }

        public int CardType { get; set; }

        public int OwnerIdType { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
