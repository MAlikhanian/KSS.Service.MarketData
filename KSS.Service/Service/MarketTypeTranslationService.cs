using AutoMapper;
using KSS.Dto;
using KSS.Entity;
using KSS.Repository.IRepository;
using KSS.Service.IService;

namespace KSS.Service.Service
{
    public class MarketTypeTranslationService : BaseService<MarketTypeTranslation, MarketTypeTranslationDto, MarketTypeTranslationDto, MarketTypeTranslationDto>, IMarketTypeTranslationService
    {
        public MarketTypeTranslationService(IMapper mapper, IMarketTypeTranslationRepository repository) : base(mapper, repository) { }
    }
}
