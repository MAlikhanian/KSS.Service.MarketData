using KSS.Entity;
using KSS.Repository.IRepository;
using MarketDataDbContext = KSS.Data.DbContexts.MainDbContext;

namespace KSS.Repository.Repository
{
    public class AssetRepository : BaseRepository<MarketDataDbContext, Asset>, IAssetRepository
    {
        public AssetRepository(MarketDataDbContext dbContext) : base(dbContext) { }
    }
}
