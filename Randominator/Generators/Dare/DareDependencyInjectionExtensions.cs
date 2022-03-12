using TehGM.Randominator.Generators.Dare;
using TehGM.Randominator.Generators.Dare.Services;
using TehGM.Randominator.Generators.MobileGameName;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DareDependencyInjectionExtensions
    {
        public static IServiceCollection AddDareGenerator(this IServiceCollection services, Action<MobileGameNameOptions> configureOptions = null)
        {
            if (configureOptions != null)
                services.Configure(configureOptions);

            services.AddRandomizer();
            services.AddTransient<IDareGenerator, DareGenerator>();

            return services;
        }
    }
}
