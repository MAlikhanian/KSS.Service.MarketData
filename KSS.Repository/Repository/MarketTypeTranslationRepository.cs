using KSS.Entity;
using KSS.Repository.IRepository;
using MarketDataDbContext = KSS.Data.DbContexts.MainDbContext;

namespace KSS.Repository.Repository
{
    public class MarketTypeTranslationRepository : BaseRepository<MarketDataDbContext, MarketTypeTranslation>, IMarketTypeTranslationRepository
    {
        public MarketTypeTranslationRepository(MarketDataDbContext dbContext) : base(dbContext) { }
    }
}
