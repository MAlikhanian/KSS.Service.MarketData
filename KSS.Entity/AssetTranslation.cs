using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSS.Entity
{
    [Table("AssetTranslation", Schema = "dbo")]
    public class AssetTranslation
    {
        public Guid AssetId { get; set; }
        public short LanguageId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(100)]
        public string? ShortName { get; set; }

        [ForeignKey(nameof(AssetId))]
        public Asset Asset { get; set; } = null!;
    }
}
