using KSS.Dto;
using KSS.Entity;

namespace KSS.Service.IService
{
    public interface IAssetService : IBaseService<Asset, AssetListDto, AssetAddDto, AssetUpdateDto> { }
}
