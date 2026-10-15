using KSS.Entity;
using KSS.Repository.IRepository;
using MarketDataDbContext = KSS.Data.DbContexts.MainDbContext;

namespace KSS.Repository.Repository
{
    public class AssetTranslationRepository : BaseRepository<MarketDataDbContext, AssetTranslation>, IAssetTranslationRepository
    {
        public AssetTranslationRepository(MarketDataDbContext dbContext) : base(dbContext) { }
    }
}
