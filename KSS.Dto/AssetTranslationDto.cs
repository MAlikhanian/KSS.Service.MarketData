namespace KSS.Dto
{
    public class AssetTranslationDto
    {
        public Guid AssetId { get; set; }
        public short LanguageId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? ShortName { get; set; }
    }
}
