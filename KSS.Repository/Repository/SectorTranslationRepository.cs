using KSS.Entity;
using KSS.Repository.IRepository;
using MarketDataDbContext = KSS.Data.DbContexts.MainDbContext;

namespace KSS.Repository.Repository
{
    public class SectorTranslationRepository : BaseRepository<MarketDataDbContext, SectorTranslation>, ISectorTranslationRepository
    {
        public SectorTranslationRepository(MarketDataDbContext dbContext) : base(dbContext) { }
    }
}
