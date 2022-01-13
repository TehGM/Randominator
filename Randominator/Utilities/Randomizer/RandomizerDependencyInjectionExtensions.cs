using Microsoft.Extensions.DependencyInjection.Extensions;
using TehGM.Randominator;
using TehGM.Randominator.Utilities;
using TehGM.Randominator.Utilities.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class RandomizerDependencyInjectionExtensions
    {
        public static IServiceCollection AddRandomizer(this IServiceCollection services)
        {
            services.TryAddSingleton<IRandomizerProvider, RandomizerProvider>();
            services.TryAddSingleton<IRandomizer>(provider => provider.GetRequiredService<IRandomizerProvider>().GetSharedRandomizer());

            return services;
        }
    }
}
