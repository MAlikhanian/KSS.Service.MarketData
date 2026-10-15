using AutoMapper;
using KSS.Dto;
using KSS.Entity;
using KSS.Repository.IRepository;
using KSS.Service.IService;

namespace KSS.Service.Service
{
    public class AssetTypeTranslationService : BaseService<AssetTypeTranslation, AssetTypeTranslationDto, AssetTypeTranslationDto, AssetTypeTranslationDto>, IAssetTypeTranslationService
    {
        public AssetTypeTranslationService(IMapper mapper, IAssetTypeTranslationRepository repository) : base(mapper, repository) { }
    }
}
