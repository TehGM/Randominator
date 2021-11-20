using TehGM.Randominator.Generators.MobileGameName;
using TehGM.Randominator.Generators.MobileGameName.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class MobileGameNameDependencyInjectionExtensions
    {
        public static IServiceCollection AddMobileGameNameGenerator(this IServiceCollection services, Action<MobileGameNameOptions> configureOptions = null)
        {
            if (configureOptions != null)
                services.Configure(configureOptions);

            services.AddTransient<IMobileGameNameGenerator, MobileGameNameGenerator>();

            return services;
        }
    }
}
