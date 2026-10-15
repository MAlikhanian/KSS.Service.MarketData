using KSS.Dto;
using KSS.Entity;
using KSS.Service.IService;
using KSS.API.Controller;

namespace KSS.Api.Controller
{
    public class AssetTranslationController : BaseController<AssetTranslation, AssetTranslationDto, AssetTranslationDto, AssetTranslationDto>
    {
        public AssetTranslationController(IAssetTranslationService service) : base(service) { }
    }
}
