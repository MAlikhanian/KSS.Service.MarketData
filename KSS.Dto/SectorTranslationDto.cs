namespace KSS.Dto
{
    public class SectorTranslationDto
    {
        public int SectorId { get; set; }
        public short LanguageId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
