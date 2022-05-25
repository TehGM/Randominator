using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TehGM.Randominator.UI.Pages;

namespace TehGM.Randominator.SitemapRenderer
{
    internal static class RouteFinder
    {
        public static IEnumerable<Type> GetPages(Assembly assembly)
        {
            return assembly.ExportedTypes
                .Where(type =>
                    // pages are always non-abstract classes that inherit from ComponentBase
                    type.IsClass && !type.IsAbstract && type.IsSubclassOf(typeof(ComponentBase))
                    // they also always have route attribute
                    && type.GetCustomAttribute<RouteAttribute>() != null
                    // additionally, we have a special attribute to explicitly ignore the page
                    && type.GetCustomAttribute<SitemapIgnoreAttribute>() == null);
        }
    }
}
