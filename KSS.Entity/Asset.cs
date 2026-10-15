using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSS.Entity
{
    [Table("Asset", Schema = "dbo")]
    public class Asset
    {
        [Key]
        public Guid Id { get; set; }

        public int MarketTypeId { get; set; }
        public int AssetTypeId { get; set; }
        public int? SectorId { get; set; }

        [Required]
        [MaxLength(30)]
        public string Symbol { get; set; } = string.Empty;

        [MaxLength(50)]
        [Unicode(false)]
        public string? InstrumentCode { get; set; }

        [Column(TypeName = "DECIMAL(10,4)")]
        public decimal? CollateralFactor { get; set; }

        public bool IsActive { get; set; }
        public bool IsDelisted { get; set; }
        public DateTime? ListedDate { get; set; }
        public DateTime? DelistedDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        [ForeignKey(nameof(MarketTypeId))]
        public MarketType MarketType { get; set; } = null!;

        [ForeignKey(nameof(AssetTypeId))]
        public AssetType AssetType { get; set; } = null!;

        [ForeignKey(nameof(SectorId))]
        public Sector? Sector { get; set; }

        public ICollection<AssetTranslation> Translations { get; set; } = new List<AssetTranslation>();
    }
}
