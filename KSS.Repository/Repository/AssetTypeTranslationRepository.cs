using KSS.Entity;
using KSS.Repository.IRepository;
using MarketDataDbContext = KSS.Data.DbContexts.MainDbContext;

namespace KSS.Repository.Repository
{
    public class AssetTypeTranslationRepository : BaseRepository<MarketDataDbContext, AssetTypeTranslation>, IAssetTypeTranslationRepository
    {
        public AssetTypeTranslationRepository(MarketDataDbContext dbContext) : base(dbContext) { }
    }
}
