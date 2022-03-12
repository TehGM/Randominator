using System.Reflection;

namespace TehGM.Randominator
{
    public static class AppInfo
    {
        private static string _version;

        // Name and AuthorInfo are not likely to change often, and are rather constant information
        // for this reason, it can be hardcoded - won't be an issue, and will be much easier to use
        public static string Name => "Randominator";
        public static string Author => "TehGM";
        public static string AuthorWebsite => "https://tehgm.net";
        public static string AuthorTwitter => "TehOriginalGM";

        public static string RepositoryURL => "https://github.com/TehGM/Randominator";
        public static string DiscussionsURL => $"{RepositoryURL}/discussions";
        public static string IssuesURL => $"{RepositoryURL}/issues";

        public static string Version
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_version))
                    _version = Assembly.GetExecutingAssembly()
                        .GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
                return _version;
            }
        }
    }
}
