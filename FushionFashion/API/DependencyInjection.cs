using API.Service;
using Application.Interface;

namespace API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddWebAPIService(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IClaimService, ClaimService>();

            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddHttpContextAccessor();

            return services;
        }
    }
}
