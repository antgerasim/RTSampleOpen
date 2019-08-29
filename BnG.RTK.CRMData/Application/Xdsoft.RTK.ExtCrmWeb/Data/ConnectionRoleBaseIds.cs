namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ConnectionRoleBaseIds
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ConnectionRoleBaseIds()
        {
            ConnectionBase = new HashSet<ConnectionBase>();
            ConnectionBase1 = new HashSet<ConnectionBase>();
            ConnectionRoleAssociation = new HashSet<ConnectionRoleAssociation>();
            ConnectionRoleAssociation1 = new HashSet<ConnectionRoleAssociation>();
            ConnectionRoleObjectTypeCodeBase = new HashSet<ConnectionRoleObjectTypeCodeBase>();
        }

        [Key]
        public Guid ConnectionRoleId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConnectionBase> ConnectionBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConnectionBase> ConnectionBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConnectionRoleAssociation> ConnectionRoleAssociation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConnectionRoleAssociation> ConnectionRoleAssociation1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConnectionRoleObjectTypeCodeBase> ConnectionRoleObjectTypeCodeBase { get; set; }
    }
}
