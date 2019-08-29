namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompetitorBase")]
    public partial class CompetitorBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompetitorBase()
        {
            ActivityPointerBase = new HashSet<ActivityPointerBase>();
            CompetitorAddressBase = new HashSet<CompetitorAddressBase>();
            LeadCompetitors = new HashSet<LeadCompetitors>();
            OpportunityCompetitors = new HashSet<OpportunityCompetitors>();
            CompetitorProduct = new HashSet<CompetitorProduct>();
            CompetitorSalesLiterature = new HashSet<CompetitorSalesLiterature>();
        }

        [Key]
        public Guid CompetitorId { get; set; }

        public Guid OrganizationId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public string Overview { get; set; }

        [StringLength(200)]
        public string ReferenceInfoUrl { get; set; }

        [Column(TypeName = "money")]
        public decimal? ReportedRevenue { get; set; }

        public int? ReportingQuarter { get; set; }

        public int? ReportingYear { get; set; }

        public string Strengths { get; set; }

        public string Weaknesses { get; set; }

        public string Opportunities { get; set; }

        public string Threats { get; set; }

        [StringLength(10)]
        public string TickerSymbol { get; set; }

        [StringLength(200)]
        public string KeyProduct { get; set; }

        [StringLength(20)]
        public string StockExchange { get; set; }

        public double? WinPercentage { get; set; }

        [StringLength(200)]
        public string WebSiteUrl { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public decimal? ExchangeRate { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public int? ImportSequenceNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal? ReportedRevenue_Base { get; set; }

        [StringLength(100)]
        public string YomiName { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? EntityImageId { get; set; }

        public Guid? ProcessId { get; set; }

        public Guid? StageId { get; set; }

        [StringLength(1250)]
        public string TraversedPath { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityPointerBase> ActivityPointerBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompetitorAddressBase> CompetitorAddressBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeadCompetitors> LeadCompetitors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpportunityCompetitors> OpportunityCompetitors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompetitorProduct> CompetitorProduct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompetitorSalesLiterature> CompetitorSalesLiterature { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
