using AutoMapper;
using KSS.Dto;
using KSS.Entity;
using KSS.Repository.IRepository;
using KSS.Service.IService;

namespace KSS.Service.Service
{
    public class AssetService : BaseService<Asset, AssetListDto, AssetAddDto, AssetUpdateDto>, IAssetService
    {
        public AssetService(IMapper mapper, IAssetRepository repository) : base(mapper, repository) { }
    }
}
