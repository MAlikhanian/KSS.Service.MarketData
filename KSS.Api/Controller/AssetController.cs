using KSS.Dto;
using KSS.Helper.CustomAttribute;
using KSS.Service.IService;
using KSS.API.Controller;

namespace KSS.Api.Controller
{
    [PermissionGroup("Asset")]
    public class AssetController : BaseController<KSS.Entity.Asset, AssetListDto, AssetAddDto, AssetUpdateDto>
    {
        public AssetController(IAssetService service) : base(service) { }
    }
}
