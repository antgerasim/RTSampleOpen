namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PostBase")]
    public partial class PostBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PostBase()
        {
            PostCommentBase = new HashSet<PostCommentBase>();
            PostLikeBase = new HashSet<PostLikeBase>();
            PostRoleBase = new HashSet<PostRoleBase>();
        }

        [Key]
        public Guid PostId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid PostRegardingId { get; set; }

        public int? YammerRetryCount { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [StringLength(2000)]
        public string Text { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid OrganizationId { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int? Source { get; set; }

        public int? Type { get; set; }

        public bool? PostToYammer { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int? YammerPostState { get; set; }

        public Guid CreatedBy { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostCommentBase> PostCommentBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostLikeBase> PostLikeBase { get; set; }

        public virtual PostRegardingBase PostRegardingBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostRoleBase> PostRoleBase { get; set; }
    }
}
