using CommandLine;

namespace Randominator.SitemapRenderer
{
    internal class Options
    {
        [Option('o', "output", Default = "bin/publish/wwwroot")]
        public string OutputDirectory { get; }
        [Option('f', "filename", Default = "sitemap.xml")]
        public string OutputFile { get; }
        [Option('d', "domain", Default = "randominator.tehgm.net")]
        public string Domain { get; }
        [Option('p', "protocol", Default = "https")]
        public string Protocol { get; }
        [Option("debug", Default = false)]
        public bool DebugLogging { get; }

        public Options(string outputDirectory, string outputFile, string domain, string protocol, bool debugLogging)
        {
            this.OutputDirectory = outputDirectory;
            this.OutputFile = outputFile;
            this.Domain = domain;
            this.Protocol = protocol;
            this.DebugLogging = debugLogging;
        }
    }
}
