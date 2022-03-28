using Microsoft.Extensions.DependencyInjection.Extensions;
using TehGM.Randominator.Utilities.GeneratorMemory;
using TehGM.Randominator.Utilities.GeneratorMemory.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class GeneratorMemoryDependencyInjectionExtensions
    {
        public static IServiceCollection AddGeneratorMemory(this IServiceCollection services)
        {
            services.TryAddScoped<IGeneratorMemoryProvider, GeneratorMemoryProvider>();

            return services;
        }
    }
}
