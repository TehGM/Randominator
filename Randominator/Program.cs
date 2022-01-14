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
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using TehGM.Randominator.UI.Services;

namespace TehGM.Randominator;

public class Program
{
    public static async Task Main(string[] args)
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

        // create default http client for config loading
        HttpClient client = new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };
        builder.Services.AddScoped(sp => client);

        // load appsettings
        await builder.Configuration.AddJsonFileAsync(client, "appsettings.json", optional: false).ConfigureAwait(false);
        await builder.Configuration.AddJsonFileAsync(client, $"appsettings.{builder.HostEnvironment.Environment}.json", optional: true).ConfigureAwait(false);

        ConfigureLogging(builder);
        ConfigureOptions(builder.Services, builder.Configuration);
        ConfigureServices(builder.Services);

        await builder.Build().RunAsync();
    }

    private static void ConfigureOptions(IServiceCollection services, IConfiguration configuration)
    {
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        // utilities
        services.AddRandomizer();

        // generators
        services.AddMobileGameNameGenerator();
        services.AddProgrammingStandardsGenerator();

        // UI services
        services.AddScoped<IPageHeaderEditor, PageHeaderEditor>();
    }

    private static void ConfigureLogging(WebAssemblyHostBuilder builder)
    {
        Serilog.Debugging.SelfLog.Enable(m => Console.Error.WriteLine(m));

        Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(builder.Configuration, "Logging")
            .CreateLogger();

        builder.Logging.ClearProviders();
        builder.Logging.AddSerilog(Log.Logger, true);
    }
}
