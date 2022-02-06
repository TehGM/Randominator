using Microsoft.AspNetCore.Components;
using Serilog;
using System;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using TehGM.Randominator.UI.Pages;

namespace Randominator.SitemapRenderer
{
    internal class SitemapBuilder
    {
        private const float _defaultPriority = 0.5f;
        private static readonly Regex _invalidRouteRegex = new Regex(@"^[^A-Za-z0-9-_/.%\\/]$", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);

        private readonly StringBuilder _builder;
        private readonly string _scheme;
        private readonly string _host;

        private string _result;

        public SitemapBuilder(string scheme, string host)
        {
            this._scheme = scheme;
            this._host = host;
            this._builder = new StringBuilder("<?xml version='1.0' encoding='UTF-8' ?><urlset xmlns = 'http://www.sitemaps.org/schemas/sitemap/0.9'>");
        }

        public void AddRoute(Type pageType)
        {
            Log.Logger.Verbose("Getting location for page {PageType}", pageType.FullName);

            // if route has explicit sitemap attribute, this always takes priority
            SitemapAttribute sitemapAttribute = pageType.GetCustomAttribute<SitemapAttribute>();

            // if sitemap attribute has null location or it doesn't exist, we need to parse location from route attribute
            string location = sitemapAttribute?.Location;
            if (location == null)
            {
                Log.Logger.Debug("Sitemap attribute for {PageType} not found, checking route", pageType.FullName);

                RouteAttribute routeAttribute = pageType.GetCustomAttribute<RouteAttribute>();
                if (routeAttribute == null)
                {
                    Log.Logger.Error("Type {PageType} does not have a route and isn't a valid Blazor page", pageType.FullName);
                    return;
                }
                location = routeAttribute.Template;
            }

            if (location == null)
                return;

            DateTimeOffset? modifiedTime = null;
            if (sitemapAttribute?.LastModified != null)
                modifiedTime = DateTimeOffset.Parse(sitemapAttribute.LastModified);

            this.AddRoute(location, sitemapAttribute?.Priority ?? _defaultPriority, sitemapAttribute?.ChangeFrequency, modifiedTime);
        }

        public void AddRoute(string location, float priority = _defaultPriority, SitemapChangeFrequency? changeFrequency = null, DateTimeOffset? lastModified = null)
        {
            if (string.IsNullOrWhiteSpace(location))
                throw new ArgumentNullException(nameof(location));

            Log.Logger.Information("Building sitemap node for route {Route}", location);

            if (!location.StartsWith('/') || _invalidRouteRegex.IsMatch(location))
            {
                Log.Logger.Error("Route {Route} is not a valid sitemap route", location);
                return;
            }

            string url = $"{this._scheme}://{this._host}{location}";

            lock (this._builder)
            {
                // ok, XmlSerializer was failing me when it comes to lastmod prop... let's just do it manually
                this._builder.Append("<url>");
                this._builder.AppendFormat("<loc>{0}</loc>", url);
                this._builder.AppendFormat("<priority>{0}</priority>", priority.ToString("0.0", CultureInfo.InvariantCulture));
                if (changeFrequency != null)
                    this._builder.AppendFormat("<changefreq>{0}</changefreq>", changeFrequency.ToString().ToLowerInvariant());
                if (lastModified != null)
                    this._builder.AppendFormat("<lastmod>{0}</lastmod>", lastModified.Value.ToString("yyyy-MM-ddTHH:mm:sszzz"));
                this._builder.Append("</url>");
            }
        }

        public string Build()
        {
            if (this._result == null)
            {
                this._builder.Append("</urlset>");
                this._result = this._builder.ToString();
            }
            return this._result;
        }

        public override string ToString()
            => this.Build();
    }
}
