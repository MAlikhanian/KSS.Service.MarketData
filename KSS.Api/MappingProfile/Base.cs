using AutoMapper;
using KSS.Entity;
using KSS.Dto;

namespace KSS.Api.MappingProfile
{
    public class BaseMappingProfile : Profile
    {
        public BaseMappingProfile()
        {
            CreateMap<MarketType, MarketTypeDto>().ReverseMap();
            CreateMap<MarketTypeTranslation, MarketTypeTranslationDto>().ReverseMap();
            CreateMap<AssetType, AssetTypeDto>().ReverseMap();
            CreateMap<AssetTypeTranslation, AssetTypeTranslationDto>().ReverseMap();
            CreateMap<Sector, SectorDto>().ReverseMap();
            CreateMap<SectorTranslation, SectorTranslationDto>().ReverseMap();

            CreateMap<KSS.Entity.Asset, AssetListDto>()
                .ForMember(d => d.MarketTypeCode, o => o.MapFrom(s => s.MarketType != null ? s.MarketType.Code : null))
                .ForMember(d => d.AssetTypeCode, o => o.MapFrom(s => s.AssetType != null ? s.AssetType.Code : null))
                .ForMember(d => d.SectorCode, o => o.MapFrom(s => s.Sector != null ? s.Sector.Code : null))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Translations != null && s.Translations.Count > 0 ? s.Translations.First().Name : null))
                .ForMember(d => d.ShortName, o => o.MapFrom(s => s.Translations != null && s.Translations.Count > 0 ? s.Translations.First().ShortName : null))
                .ReverseMap();
            CreateMap<AssetAddDto, KSS.Entity.Asset>().ReverseMap();
            CreateMap<AssetUpdateDto, KSS.Entity.Asset>().ReverseMap();
            CreateMap<AssetTranslation, AssetTranslationDto>().ReverseMap();
        }
    }
}
