namespace KSS.Dto
{
    public class AssetUpdateDto
    {
        public Guid Id { get; set; }
        public int MarketTypeId { get; set; }
        public int AssetTypeId { get; set; }
        public int? SectorId { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public string? InstrumentCode { get; set; }
        public decimal? CollateralFactor { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelisted { get; set; }
        public DateTime? ListedDate { get; set; }
        public DateTime? DelistedDate { get; set; }
    }
}
