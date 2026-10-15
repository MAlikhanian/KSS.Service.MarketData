using KSS.Helper;
using KSS.Helper.Authorization;
using Microsoft.AspNetCore.Authorization;
using KSS.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace KSS.Api.ServiceExtention
{
    public static class BaseServiceExtention
    {
        public static IServiceCollection AddBaseServiceExtention(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            var connectionString = configuration.GetSection("ConnectionStrings")["DefaultConnection"];

            serviceCollection.AddDbContext<MainDbContext>(options => options.UseSqlServer(connectionString));

            serviceCollection.AddMarketDataServiceExtention(configuration);

            serviceCollection.AddScoped<GlobalProperty>();

            // Permission-based authorization
            serviceCollection.AddSingleton<IAuthorizationPolicyProvider, PermissionPolicyProvider>();
            serviceCollection.AddSingleton<IAuthorizationHandler, PermissionAuthorizationHandler>();
            serviceCollection.AddScoped<PermissionAuthorizationFilter>();

            return serviceCollection;
        }
    }
}
