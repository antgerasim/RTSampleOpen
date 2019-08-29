namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomControlDefaultConfigBase")]
    public partial class CustomControlDefaultConfigBase
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PrimaryEntityTypeCode { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool IsManaged { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid OrganizationId { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid CustomControlDefaultConfigId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        [Key]
        [Column(Order = 5)]
        public Guid CustomControlDefaultConfigIdUnique { get; set; }

        [Key]
        [Column(Order = 6)]
        public string ControlDescriptionXML { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        [StringLength(48)]
        public string IntroducedVersion { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime OverwriteTime { get; set; }

        [Key]
        [Column(Order = 8)]
        public Guid SolutionId { get; set; }

        public string EventsXml { get; set; }
    }
}
