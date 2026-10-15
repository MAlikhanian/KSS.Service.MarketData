using KSS.Dto;
using KSS.Entity;
using KSS.Service.IService;
using KSS.API.Controller;

namespace KSS.Api.Controller
{
    public class MarketTypeTranslationController : BaseController<MarketTypeTranslation, MarketTypeTranslationDto, MarketTypeTranslationDto, MarketTypeTranslationDto>
    {
        public MarketTypeTranslationController(IMarketTypeTranslationService service) : base(service) { }
    }
}
