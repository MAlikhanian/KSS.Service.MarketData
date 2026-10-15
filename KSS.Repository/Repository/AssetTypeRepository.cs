using KSS.Entity;
using KSS.Repository.IRepository;
using MarketDataDbContext = KSS.Data.DbContexts.MainDbContext;

namespace KSS.Repository.Repository
{
    public class AssetTypeRepository : BaseRepository<MarketDataDbContext, AssetType>, IAssetTypeRepository
    {
        public AssetTypeRepository(MarketDataDbContext dbContext) : base(dbContext) { }
    }
}
