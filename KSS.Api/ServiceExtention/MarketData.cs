using KSS.Repository.IRepository;
using KSS.Repository.Repository;
using KSS.Service.IService;
using KSS.Service.Service;

namespace KSS.Api.ServiceExtention
{
    public static class MarketDataServiceExtention
    {
        public static IServiceCollection AddMarketDataServiceExtention(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IMarketTypeRepository, MarketTypeRepository>();
            services.AddScoped<IMarketTypeService, MarketTypeService>();
            services.AddScoped<IMarketTypeTranslationRepository, MarketTypeTranslationRepository>();
            services.AddScoped<IMarketTypeTranslationService, MarketTypeTranslationService>();

            services.AddScoped<IAssetTypeRepository, AssetTypeRepository>();
            services.AddScoped<IAssetTypeService, AssetTypeService>();
            services.AddScoped<IAssetTypeTranslationRepository, AssetTypeTranslationRepository>();
            services.AddScoped<IAssetTypeTranslationService, AssetTypeTranslationService>();

            services.AddScoped<ISectorRepository, SectorRepository>();
            services.AddScoped<ISectorService, SectorService>();
            services.AddScoped<ISectorTranslationRepository, SectorTranslationRepository>();
            services.AddScoped<ISectorTranslationService, SectorTranslationService>();

            services.AddScoped<IAssetRepository, AssetRepository>();
            services.AddScoped<IAssetService, AssetService>();
            services.AddScoped<IAssetTranslationRepository, AssetTranslationRepository>();
            services.AddScoped<IAssetTranslationService, AssetTranslationService>();

            return services;
        }
    }
}
