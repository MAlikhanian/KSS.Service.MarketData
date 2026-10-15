using KSS.Dto;
using KSS.Helper.CustomAttribute;
using KSS.Entity;
using KSS.Service.IService;
using KSS.API.Controller;

namespace KSS.Api.Controller
{
    [PermissionGroup("MarketType")]
    public class MarketTypeController : BaseController<MarketType, MarketTypeDto, MarketTypeDto, MarketTypeDto>
    {
        public MarketTypeController(IMarketTypeService service) : base(service) { }
    }
}
