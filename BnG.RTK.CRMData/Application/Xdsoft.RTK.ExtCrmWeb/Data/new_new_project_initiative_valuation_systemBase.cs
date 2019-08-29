namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_new_project_initiative_valuation_systemBase
    {
        [Key]
        public Guid new_new_project_initiative_valuation_systemId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid new_project_initiative_valuationid { get; set; }

        public Guid systemuserid { get; set; }

        public virtual new_project_initiative_valuationBase new_project_initiative_valuationBase { get; set; }

        public virtual SystemUserBase SystemUserBase { get; set; }
    }
}
