using Microsoft.Extensions.DependencyInjection.Extensions;
using TehGM.Randominator.Features.Player;
using TehGM.Randominator.Features.Player.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class PlayerDependencyInjectionExtensions
    {
        public static IServiceCollection AddPlayer(this IServiceCollection services)
        {
            services.TryAddScoped<IPlayerVideoProvider, PlayerService>();
            services.TryAddScoped<IPlayerRefresher>(provider => (IPlayerRefresher)provider.GetRequiredService<IPlayerVideoProvider>());

            return services;
        }
    }
}
