namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LocalConfigStoreBase")]
    public partial class LocalConfigStoreBase
    {
        [Required]
        [StringLength(256)]
        public string AssemblyName { get; set; }

        [Required]
        [StringLength(256)]
        public string PublicToken { get; set; }

        [Required]
        [StringLength(256)]
        public string KeyName { get; set; }

        public Guid Id { get; set; }

        public byte[] Value { get; set; }
    }
}
