using Microsoft.Extensions.DependencyInjection.Extensions;
using TehGM.Randominator.Utilities;
using TehGM.Randominator.Utilities.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class EnglishWordsDependencyInjectionExtensions
    {
        public static IServiceCollection AddEnglishWords(this IServiceCollection services)
        {
            services.TryAddScoped<IEnglishWordsProvider, EnglishWordsProvider>();

            return services;
        }
    }
}
