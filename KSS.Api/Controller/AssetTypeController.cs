using KSS.Dto;
using KSS.Helper.CustomAttribute;
using KSS.Entity;
using KSS.Service.IService;
using KSS.API.Controller;

namespace KSS.Api.Controller
{
    [PermissionGroup("AssetType")]
    public class AssetTypeController : BaseController<AssetType, AssetTypeDto, AssetTypeDto, AssetTypeDto>
    {
        public AssetTypeController(IAssetTypeService service) : base(service) { }
    }
}
