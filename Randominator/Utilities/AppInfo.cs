﻿using System.Reflection;

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
                {
                    string version = Assembly.GetExecutingAssembly()
                        .GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
                    int hashIndex = version.IndexOf('+');
                    if (hashIndex > 0)
                        version = version.Substring(0, hashIndex);
                    _version = version;
                }
                return _version;
            }
        }

        public static string GetDiscussionURL(uint discussionID)
            => $"{DiscussionsURL}/{discussionID}";
        public static string GetPullRequestURL(uint prID)
            => $"{RepositoryURL}/pull/{prID}";
    }
}
