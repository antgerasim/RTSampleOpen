namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImportLogBase")]
    public partial class ImportLogBase
    {
        public Guid? ModifiedBy { get; set; }

        public int SequenceNumber { get; set; }

        public int? LineNumber { get; set; }

        public string AdditionalInfo { get; set; }

        public int? LogPhaseCode { get; set; }

        public int StateCode { get; set; }

        public int? ErrorNumber { get; set; }

        public int StatusCode { get; set; }

        public DateTime CreatedOn { get; set; }

        [Key]
        public Guid ImportLogId { get; set; }

        [StringLength(512)]
        public string ErrorDescription { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public DateTime ModifiedOn { get; set; }

        public string HeaderColumn { get; set; }

        public string ColumnValue { get; set; }

        public Guid? ImportDataId { get; set; }

        public Guid? ImportFileId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid OwnerId { get; set; }

        public int OwnerIdType { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual ImportDataBase ImportDataBase { get; set; }

        public virtual ImportFileBase ImportFileBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
