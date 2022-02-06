using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using CommandLine;
using Serilog;

namespace Randominator.SitemapRenderer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Options options = ParseOptions(args);
            ConfigureLogging(options);

            IEnumerable<Type> pages = RouteFinder.GetPages(typeof(TehGM.Randominator.UI.Pages.Index).Assembly);

            SitemapBuilder builder = new SitemapBuilder(options.Protocol, options.Domain);
            foreach (Type page in pages)
                builder.AddRoute(page);
            string output = builder.Build();
            string filepath = Path.GetFullPath(Path.Combine(options.OutputDirectory, options.OutputFile));
            Log.Logger.Information("Writing to {FilePath}", filepath);
            using FileStream file = File.Create(filepath);
            using StreamWriter writer = new StreamWriter(file);
            writer.Write(output);
        }

        private static void ConfigureLogging(Options options)
        {
            LoggerConfiguration config = new LoggerConfiguration();
            if (Debugger.IsAttached)
                config.MinimumLevel.Verbose();
            else if (options.DebugLogging)
                config.MinimumLevel.Debug();
            else
                config.MinimumLevel.Information();
            config.Enrich.FromLogContext();
            config.WriteTo.Console();

            Log.Logger = config.CreateLogger();

            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                Log.Logger.Fatal((Exception)e.ExceptionObject, "An unhandled exception has occured");
            };
        }

        private static Options ParseOptions(string[] args)
        {
            using Parser parser = new Parser(config =>
            {
                config.IgnoreUnknownArguments = true;
                config.EnableDashDash = false;
                config.CaseSensitive = false;
                config.ParsingCulture = System.Globalization.CultureInfo.InvariantCulture;
            });

            Options result = null;
            parser.ParseArguments<Options>(args)
                .WithParsed(options => result = options);

            return result;
        }
    }
}
