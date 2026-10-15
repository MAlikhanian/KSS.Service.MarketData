namespace KSS.Dto
{
    public class AssetListDto
    {
        public Guid Id { get; set; }
        public int MarketTypeId { get; set; }
        public string MarketTypeCode { get; set; } = string.Empty;
        public int AssetTypeId { get; set; }
        public string AssetTypeCode { get; set; } = string.Empty;
        public int? SectorId { get; set; }
        public string? SectorCode { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public string? InstrumentCode { get; set; }
        public decimal? CollateralFactor { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelisted { get; set; }
        public DateTime? ListedDate { get; set; }
        public DateTime? DelistedDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? Name { get; set; }
        public string? ShortName { get; set; }
    }
}
