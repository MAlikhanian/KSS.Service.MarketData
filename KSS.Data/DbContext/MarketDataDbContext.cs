using Microsoft.EntityFrameworkCore;
using KSS.Entity;

namespace KSS.Data.DbContexts
{
    public partial class MainDbContext
    {
        public DbSet<MarketType> MarketTypes { get; set; }
        public DbSet<MarketTypeTranslation> MarketTypeTranslations { get; set; }
        public DbSet<AssetType> AssetTypes { get; set; }
        public DbSet<AssetTypeTranslation> AssetTypeTranslations { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<SectorTranslation> SectorTranslations { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetTranslation> AssetTranslations { get; set; }
    }
}
