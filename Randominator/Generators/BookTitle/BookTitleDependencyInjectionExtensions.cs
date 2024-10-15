using TehGM.Randominator.Generators.BookTitle;
using TehGM.Randominator.Generators.BookTitle.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class BookTitleDependencyInjectionExtensions
    {
        public static IServiceCollection AddBookTitleGenerator(this IServiceCollection services, Action<BookTitleOptions> configureOptions = null)
        {
            if (configureOptions != null)
                services.Configure(configureOptions);

            services.AddRandomizer();
            services.AddTransient<IBookTitleGenerator, BookTitleGenerator>();

            return services;
        }
    }
}
