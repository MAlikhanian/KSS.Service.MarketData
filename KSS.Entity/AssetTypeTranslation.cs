using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSS.Entity
{
    [Table("AssetTypeTranslation", Schema = "dbo")]
    public class AssetTypeTranslation
    {
        public int AssetTypeId { get; set; }
        public short LanguageId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [ForeignKey(nameof(AssetTypeId))]
        public AssetType AssetType { get; set; } = null!;
    }
}
