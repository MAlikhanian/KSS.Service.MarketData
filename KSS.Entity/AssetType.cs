using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSS.Entity
{
    [Table("AssetType", Schema = "dbo")]
    public class AssetType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Unicode(false)]
        public string Code { get; set; } = string.Empty;

        public bool IsActive { get; set; }

        public ICollection<AssetTypeTranslation> Translations { get; set; } = new List<AssetTypeTranslation>();
        public ICollection<Asset> Assets { get; set; } = new List<Asset>();
    }
}
