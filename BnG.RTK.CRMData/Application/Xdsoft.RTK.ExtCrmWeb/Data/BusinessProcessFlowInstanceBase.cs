namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BusinessProcessFlowInstanceBase")]
    public partial class BusinessProcessFlowInstanceBase
    {
        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? Entity4Id { get; set; }

        public Guid? Entity2Id { get; set; }

        public int? Entity5ObjectTypeCode { get; set; }

        public Guid? Entity5Id { get; set; }

        [Key]
        public Guid BusinessProcessFlowInstanceId { get; set; }

        public Guid? Entity3Id { get; set; }

        public int? Entity3ObjectTypeCode { get; set; }

        public int? Entity2ObjectTypeCode { get; set; }

        public int? Entity1ObjectTypeCode { get; set; }

        public Guid? Entity1Id { get; set; }

        public int? Entity4ObjectTypeCode { get; set; }

        public Guid ProcessId { get; set; }

        public Guid? ProcessStageId { get; set; }

        [StringLength(1250)]
        public string TraversedPath { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public DateTime? CompletedOn { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int StatusCode { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int StateCode { get; set; }

        public DateTime? ActiveStageStartedOn { get; set; }
    }
}
