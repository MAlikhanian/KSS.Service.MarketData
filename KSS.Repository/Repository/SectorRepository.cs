using KSS.Entity;
using KSS.Repository.IRepository;
using MarketDataDbContext = KSS.Data.DbContexts.MainDbContext;

namespace KSS.Repository.Repository
{
    public class SectorRepository : BaseRepository<MarketDataDbContext, Sector>, ISectorRepository
    {
        public SectorRepository(MarketDataDbContext dbContext) : base(dbContext) { }
    }
}
