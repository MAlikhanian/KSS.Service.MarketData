using AutoMapper;
using KSS.Dto;
using KSS.Entity;
using KSS.Repository.IRepository;
using KSS.Service.IService;

namespace KSS.Service.Service
{
    public class SectorTranslationService : BaseService<SectorTranslation, SectorTranslationDto, SectorTranslationDto, SectorTranslationDto>, ISectorTranslationService
    {
        public SectorTranslationService(IMapper mapper, ISectorTranslationRepository repository) : base(mapper, repository) { }
    }
}
