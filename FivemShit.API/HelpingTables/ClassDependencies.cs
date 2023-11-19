using FivemShit.API.HelpingTables.TokenManager;
using FivemShit.API.Repositories;
using FivemShit.API.Services;

namespace FivemShit.API.HelpingTables
{
    public static class ClassDependencies
    {
        public static IServiceCollection ClassDependency(this IServiceCollection services)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IUserInterface, UserService>();
            return services;
        }
    }
}
