using AutoMapper;
using KSS.Dto;
using KSS.Entity;
using KSS.Repository.IRepository;
using KSS.Service.IService;

namespace KSS.Service.Service
{
    public class MarketTypeService : BaseService<MarketType, MarketTypeDto, MarketTypeDto, MarketTypeDto>, IMarketTypeService
    {
        public MarketTypeService(IMapper mapper, IMarketTypeRepository repository) : base(mapper, repository) { }
    }
}
