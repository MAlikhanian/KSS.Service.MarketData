using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSS.Entity
{
    [Table("MarketTypeTranslation", Schema = "dbo")]
    public class MarketTypeTranslation
    {
        public int MarketTypeId { get; set; }
        public short LanguageId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [ForeignKey(nameof(MarketTypeId))]
        public MarketType MarketType { get; set; } = null!;
    }
}
