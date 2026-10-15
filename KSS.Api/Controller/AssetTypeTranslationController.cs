using KSS.Dto;
using KSS.Entity;
using KSS.Service.IService;
using KSS.API.Controller;

namespace KSS.Api.Controller
{
    public class AssetTypeTranslationController : BaseController<AssetTypeTranslation, AssetTypeTranslationDto, AssetTypeTranslationDto, AssetTypeTranslationDto>
    {
        public AssetTypeTranslationController(IAssetTypeTranslationService service) : base(service) { }
    }
}
