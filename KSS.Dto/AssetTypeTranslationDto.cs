namespace KSS.Dto
{
    public class AssetTypeTranslationDto
    {
        public int AssetTypeId { get; set; }
        public short LanguageId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
