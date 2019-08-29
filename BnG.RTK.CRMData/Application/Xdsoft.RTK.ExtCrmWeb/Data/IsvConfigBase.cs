namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IsvConfigBase")]
    public partial class IsvConfigBase
    {
        public string ConfigXML { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid OrganizationId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public DateTime? CreatedOn { get; set; }

        [Key]
        public Guid IsvConfigId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }
    }
}
