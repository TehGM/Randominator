using Blazored.LocalStorage;
using Blazored.LocalStorage.Exceptions;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace TehGM.Randominator.Services
{
    public class LocalStorageUserSettingsProvider : IUserSettingsProvider
    {
        private const string _key = "user_settings";

        private readonly ILogger _log;
        private readonly ILocalStorageService _localStorage;
        private readonly IWebAssemblyHostEnvironment _environment;

        public LocalStorageUserSettingsProvider(IWebAssemblyHostEnvironment environment, ILocalStorageService localStorage, ILogger<LocalStorageUserSettingsProvider> log)
        {
            this._environment = environment;
            this._localStorage = localStorage;
            this._log = log;
        }

        public event Action<UserSettings> Changed;

        public UserSettings GetDefault()
            => new UserSettings();

        public async Task<UserSettings> GetAsync(CancellationToken cancellationToken = default)
        {
            if (this._environment.IsPrerendering())
                return this.GetDefault();

            try
            {
                if (!await this._localStorage.ContainKeyAsync(_key, cancellationToken).ConfigureAwait(false))
                    return this.GetDefault();

                UserSettings result = await this._localStorage.GetItemAsync<UserSettings>(_key, cancellationToken).ConfigureAwait(false);
                return result ?? this.GetDefault();
            }
            catch (BrowserStorageDisabledException)
            {
                this._log.LogError("Failed to load user settings - cookies disabled in browser");
                return this.GetDefault();
            }
            catch (Exception ex)
            {
                this._log.LogError(ex, "Failed to load user settings");
                return this.GetDefault();
            }
        }

        public async Task SaveAsync(UserSettings settings, CancellationToken cancellationToken = default)
        {
            if (this._environment.IsPrerendering())
                return;
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            try
            {
                await this._localStorage.SetItemAsync(_key, settings, cancellationToken).ConfigureAwait(false);
            }
            catch (BrowserStorageDisabledException)
            {
                this._log.LogError("Failed to save user settings - cookies disabled in browser");
            }
            catch (Exception ex)
            {
                this._log.LogError(ex, "Failed to save user settings");
            }

            this.Changed?.Invoke(settings);
        }

        public async Task ClearAsync(CancellationToken cancellationToken = default)
        {
            if (this._environment.IsPrerendering())
                return;

            try
            {
                await this._localStorage.RemoveItemAsync(_key, cancellationToken).ConfigureAwait(false);
            }
            catch (BrowserStorageDisabledException)
            {
                this._log.LogError("Failed to clearing user settings - cookies disabled in browser");
            }
            catch (Exception ex)
            {
                this._log.LogError(ex, "Failed to clearing user settings");
            }

            this.Changed?.Invoke(this.GetDefault());
        }
    }
}
