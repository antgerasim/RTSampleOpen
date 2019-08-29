namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RoleTemplatePrivileges
    {
        public Guid RoleTemplateId { get; set; }

        public Guid PrivilegeId { get; set; }

        public bool IsBasic { get; set; }

        public bool IsLocal { get; set; }

        public bool IsDeep { get; set; }

        public bool IsGlobal { get; set; }

        public bool Upgrading { get; set; }

        [Key]
        public Guid RoleTemplatePrivilegeId { get; set; }

        public virtual PrivilegeBase PrivilegeBase { get; set; }
    }
}
