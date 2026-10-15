using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSS.Entity
{
    [Table("MarketType", Schema = "dbo")]
    public class MarketType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Unicode(false)]
        public string Code { get; set; } = string.Empty;

        public bool IsActive { get; set; }

        public ICollection<MarketTypeTranslation> Translations { get; set; } = new List<MarketTypeTranslation>();
        public ICollection<Asset> Assets { get; set; } = new List<Asset>();
    }
}
