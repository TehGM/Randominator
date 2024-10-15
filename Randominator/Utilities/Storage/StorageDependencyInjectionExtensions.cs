using Blazored.LocalStorage;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TehGM.Randominator;
using TehGM.Randominator.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class StorageDependencyInjectionExtensions
    {
        public static IServiceCollection AddUserSettings(this IServiceCollection services)
        {
            services.AddBlazoredLocalStorage();
            services.TryAddScoped<IUserSettingsProvider, LocalStorageUserSettingsProvider>();
            services.TryAddTransient<UserSettings>(provider => provider.GetRequiredService<IUserSettingsProvider>().GetAsync().GetAwaiter().GetResult());

            return services;
        }
    }
}
