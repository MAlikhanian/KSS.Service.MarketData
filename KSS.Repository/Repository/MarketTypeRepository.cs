using KSS.Entity;
using KSS.Repository.IRepository;
using MarketDataDbContext = KSS.Data.DbContexts.MainDbContext;

namespace KSS.Repository.Repository
{
    public class MarketTypeRepository : BaseRepository<MarketDataDbContext, MarketType>, IMarketTypeRepository
    {
        public MarketTypeRepository(MarketDataDbContext dbContext) : base(dbContext) { }
    }
}
