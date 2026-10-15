namespace KSS.Dto
{
    public class AssetAddDto
    {
        public int MarketTypeId { get; set; }
        public int AssetTypeId { get; set; }
        public int? SectorId { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public string? InstrumentCode { get; set; }
        public decimal? CollateralFactor { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDelisted { get; set; }
        public DateTime? ListedDate { get; set; }
        public DateTime? DelistedDate { get; set; }
    }
}
