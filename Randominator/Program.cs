global using System;
global using System.Linq;
global using System.Threading;
global using System.Threading.Tasks;
global using System.Collections.Generic;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TehGM.Randominator.UI;
using Serilog;

namespace TehGM.Randominator;

public class Program
{
    public static Task Main(string[] args)
    {
        // add default logger for errors that happen before host runs
        Log.Logger = new LoggerConfiguration()
                    .WriteTo.Console()
                    .CreateLogger();
        // capture unhandled exceptions
        AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
        {
            try
            {
                Log.Logger.Error((Exception)e.ExceptionObject, "An exception was unhandled");
                Log.CloseAndFlush();
            }
            catch { }
        };

        WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");
        builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

        ConfigureLogging(builder);
        ConfigureOptions(builder.Services, builder.Configuration);
        ConfigureServices(builder.Services);

        return builder.Build().RunAsync();
    }

    private static void ConfigureOptions(IServiceCollection services, IConfiguration configuration)
    {
    }

    private static void ConfigureServices(IServiceCollection services)
    {
    }

    private static void ConfigureLogging(WebAssemblyHostBuilder builder)
    {
        LoggerConfiguration config = new LoggerConfiguration()
            .ReadFrom.Configuration(builder.Configuration, "Logging");

        builder.Logging.ClearProviders();
        builder.Logging.AddSerilog(config.CreateLogger(), true);
    }
}
