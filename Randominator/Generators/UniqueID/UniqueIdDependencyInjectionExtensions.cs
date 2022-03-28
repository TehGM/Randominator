using Microsoft.Extensions.DependencyInjection.Extensions;
using TehGM.Randominator.Generators.UniqueID;
using TehGM.Randominator.Generators.UniqueID.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class UniqueIdDependencyInjectionExtensions
    {
        public static IServiceCollection AddUniqueIdGenerator(this IServiceCollection services)
        {
            services.TryAddTransient<IUniqueIdGenerator, UniqueIdGenerator>();

            return services;
        }
    }
}
