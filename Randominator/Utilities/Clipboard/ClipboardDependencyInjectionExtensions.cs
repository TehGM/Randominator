using Microsoft.Extensions.DependencyInjection.Extensions;
using TehGM.Randominator.Utilities;
using TehGM.Randominator.Utilities.Clipboard;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ClipboardDependencyInjectionExtensions
    {
        public static IServiceCollection AddClipboard(this IServiceCollection services)
        {
            services.TryAddTransient<IClipboard, JsInteropClipboard>();

            return services;
        }
    }
}
