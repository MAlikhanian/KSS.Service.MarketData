using AutoMapper;
using KSS.Dto;
using KSS.Entity;
using KSS.Repository.IRepository;
using KSS.Service.IService;

namespace KSS.Service.Service
{
    public class AssetTypeService : BaseService<AssetType, AssetTypeDto, AssetTypeDto, AssetTypeDto>, IAssetTypeService
    {
        public AssetTypeService(IMapper mapper, IAssetTypeRepository repository) : base(mapper, repository) { }
    }
}
