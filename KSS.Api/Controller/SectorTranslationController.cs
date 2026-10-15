using KSS.Dto;
using KSS.Entity;
using KSS.Service.IService;
using KSS.API.Controller;

namespace KSS.Api.Controller
{
    public class SectorTranslationController : BaseController<SectorTranslation, SectorTranslationDto, SectorTranslationDto, SectorTranslationDto>
    {
        public SectorTranslationController(ISectorTranslationService service) : base(service) { }
    }
}
