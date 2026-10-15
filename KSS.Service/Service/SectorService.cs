using AutoMapper;
using KSS.Dto;
using KSS.Entity;
using KSS.Repository.IRepository;
using KSS.Service.IService;

namespace KSS.Service.Service
{
    public class SectorService : BaseService<Sector, SectorDto, SectorDto, SectorDto>, ISectorService
    {
        public SectorService(IMapper mapper, ISectorRepository repository) : base(mapper, repository) { }
    }
}
