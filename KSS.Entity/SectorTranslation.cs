using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSS.Entity
{
    [Table("SectorTranslation", Schema = "dbo")]
    public class SectorTranslation
    {
        public int SectorId { get; set; }
        public short LanguageId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [ForeignKey(nameof(SectorId))]
        public Sector Sector { get; set; } = null!;
    }
}
