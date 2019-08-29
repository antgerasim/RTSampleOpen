namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_new_d_service_types_new_t_project_task2Base
    {
        [Key]
        public Guid new_new_d_service_types_new_t_project_task2Id { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid new_d_service_typesid { get; set; }

        public Guid new_t_project_taskid { get; set; }

        public virtual new_d_service_typesBase new_d_service_typesBase { get; set; }

        public virtual new_t_project_taskBase new_t_project_taskBase { get; set; }
    }
}
