namespace Microsoft.AspNetCore.Components.WebAssembly.Hosting
{
    public static class WebHostEnvironmentExtensions
    {
        public static bool IsPrerendering(this IWebAssemblyHostEnvironment env)
            => env.Environment == "Prerendering";
    }
}
