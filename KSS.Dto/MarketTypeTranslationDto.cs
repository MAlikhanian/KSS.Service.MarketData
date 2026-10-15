namespace KSS.Dto
{
    public class MarketTypeTranslationDto
    {
        public int MarketTypeId { get; set; }
        public short LanguageId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
