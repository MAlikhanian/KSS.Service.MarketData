using AutoMapper;
using KSS.Dto;
using KSS.Entity;
using KSS.Repository.IRepository;
using KSS.Service.IService;

namespace KSS.Service.Service
{
    public class AssetTranslationService : BaseService<AssetTranslation, AssetTranslationDto, AssetTranslationDto, AssetTranslationDto>, IAssetTranslationService
    {
        public AssetTranslationService(IMapper mapper, IAssetTranslationRepository repository) : base(mapper, repository) { }
    }
}
