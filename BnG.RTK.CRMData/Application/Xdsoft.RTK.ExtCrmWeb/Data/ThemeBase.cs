namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThemeBase")]
    public partial class ThemeBase
    {
        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(7)]
        public string DefaultCustomEntityColor { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public Guid? OrganizationId { get; set; }

        [StringLength(80)]
        public string LogoToolTip { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public bool Type { get; set; }

        [StringLength(7)]
        public string ProcessControlColor { get; set; }

        [StringLength(7)]
        public string HeaderColor { get; set; }

        public Guid? CreatedBy { get; set; }

        public int? statuscode { get; set; }

        [StringLength(7)]
        public string DefaultEntityColor { get; set; }

        public int statecode { get; set; }

        [StringLength(7)]
        public string NavBarShelfColor { get; set; }

        [StringLength(7)]
        public string ControlShade { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public Guid? LogoId { get; set; }

        [StringLength(7)]
        public string HoverLinkEffect { get; set; }

        [StringLength(7)]
        public string SelectedLinkEffect { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [StringLength(7)]
        public string NavBarBackgroundColor { get; set; }

        [Key]
        public Guid ThemeId { get; set; }

        public bool IsDefaultTheme { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        [StringLength(7)]
        public string ControlBorder { get; set; }

        [StringLength(7)]
        public string GlobalLinkColor { get; set; }

        public decimal? ExchangeRate { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        [StringLength(7)]
        public string BackgroundColor { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
