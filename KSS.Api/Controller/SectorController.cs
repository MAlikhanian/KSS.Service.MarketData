using KSS.Dto;
using KSS.Helper.CustomAttribute;
using KSS.Entity;
using KSS.Service.IService;
using KSS.API.Controller;

namespace KSS.Api.Controller
{
    [PermissionGroup("Sector")]
    public class SectorController : BaseController<Sector, SectorDto, SectorDto, SectorDto>
    {
        public SectorController(ISectorService service) : base(service) { }
    }
}
