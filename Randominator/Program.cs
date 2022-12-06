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
using TehGM.Randominator.Features.Player;
using TehGM.Randominator.Generators.Dare;
using TehGM.Randominator.Generators.MobileGameName;
using TehGM.Randominator.Generators.ProgrammingStandards;

namespace TehGM.Randominator;

public class Program
{
    public static async Task Main(string[] args)
    {
        // add default logger for errors that happen before host runs
        Log.Logger = new LoggerConfiguration()
                    .MinimumLevel.Error()
                    .WriteTo.BrowserConsole()
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
        ConfigureServices(builder.Services, builder.HostEnvironment.BaseAddress, builder.Configuration);

        await builder.Build().RunAsync();
    }

    private static void ConfigureOptions(IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<PlayerOptions>(configuration.GetSection("Player"));
        services.Configure<DareGeneratorOptions>(configuration.GetSection("Generators:Dare"));
        services.Configure<MobileGameNameOptions>(configuration.GetSection("Generators:MobileGameName"));
        services.Configure<ProgrammingStandardsOptions>(configuration.GetSection("Generators:ProgrammingStandards"));
    }

    private static void ConfigureServices(IServiceCollection services, string baseAddress, IConfiguration configuration)
    {
        // options
        ConfigureOptions(services, configuration);

        // utilities
        services.AddUserSettings();
        services.AddRandomizer();
        services.AddClipboard();
        services.AddGeneratorMemory();
        services.AddEnglishWords();

        // generators
        services.AddMobileGameNameGenerator();
        services.AddProgrammingStandardsGenerator();
        services.AddUniqueIdGenerator();
        services.AddDareGenerator();

        // features
        services.AddPlayer();
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
