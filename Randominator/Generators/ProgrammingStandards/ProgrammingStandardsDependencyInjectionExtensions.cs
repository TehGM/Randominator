using Microsoft.Extensions.DependencyInjection.Extensions;
using TehGM.Randominator.Generators.ProgrammingStandards;
using TehGM.Randominator.Generators.ProgrammingStandards.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ProgrammingStandardsDependencyInjectionExtensions
    {
        public static IServiceCollection AddProgrammingStandardsGenerator(this IServiceCollection services, Action<ProgrammingStandardsOptions> configureOptions = null)
        {
            if (configureOptions != null)
                services.Configure(configureOptions);

            services.AddRandomizer();
            services.TryAddTransient<INamingStyleFormatter, NamingStyleFormatter>();
            services.TryAddTransient<IBracketsStyleFormatter, BracketsStyleFormatter>();
            services.TryAddTransient<IProgrammingStandardsGenerator, ProgrammingStandardsGenerator>();

            return services;
        }
    }
}
