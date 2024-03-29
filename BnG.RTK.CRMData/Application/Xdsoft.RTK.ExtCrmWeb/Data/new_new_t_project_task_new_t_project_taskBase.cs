namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_new_t_project_task_new_t_project_taskBase
    {
        [Key]
        public Guid new_new_t_project_task_new_t_project_taskId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid new_t_project_taskidOne { get; set; }

        public Guid new_t_project_taskidTwo { get; set; }

        public virtual new_t_project_taskBase new_t_project_taskBase { get; set; }

        public virtual new_t_project_taskBase new_t_project_taskBase1 { get; set; }
    }
}
