namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TeamTemplateBase")]
    public partial class TeamTemplateBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TeamTemplateBase()
        {
            TeamBase = new HashSet<TeamBase>();
        }

        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int DefaultAccessRightsMask { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int ObjectTypeCode { get; set; }

        [StringLength(100)]
        public string TeamTemplateName { get; set; }

        [Key]
        public Guid TeamTemplateId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public string Description { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public bool IsSystem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeamBase> TeamBase { get; set; }
    }
}
