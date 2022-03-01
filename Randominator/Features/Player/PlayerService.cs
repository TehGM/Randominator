using Microsoft.AspNetCore.Components;

namespace TehGM.Randominator.Features.Player.Services
{
    // if you found about this feature through seeing this code, well...
    // congrats for spoiling fun. Cheater!

    public class PlayerService : IPlayerVideoProvider, IPlayerRefresher
    {
        private readonly IRandomizer _randomizer;
        private readonly ILogger _log;
        private readonly PlayerOptions _options;
        private readonly NavigationManager _navigation;

        public event EventHandler RefreshRequested;

        public PlayerService(IRandomizer randomizer, NavigationManager navigation,
            ILogger<PlayerService> log, IOptions<PlayerOptions> options)
        {
            this._randomizer = randomizer;
            this._log = log;
            this._options = options.Value;
            this._navigation = navigation;

            this.LogVideosCount();
        }

        private void LogVideosCount()
        {
            if (this._log.IsEnabled(LogLevel.Debug))
                this._log.LogDebug("Total videos: {Count}", this._options.VideoIDs.Distinct().Count());
        }

        public string GetRandomVideoURL()
        {
            string videoID = this._randomizer.GetRandomValue(this._options.VideoIDs);

            this._log.LogInformation("Video ID {VideoID}", videoID);
            return this.BuildYoutubeURL(videoID);
        }

        public string BuildYoutubeURL(string videoID)
        {
            if (string.IsNullOrWhiteSpace(videoID))
                throw new ArgumentNullException(nameof(videoID));

            IDictionary<string, object> query = new Dictionary<string, object>(10)
            {
                { "autoplay", true },
                { "loop", true },
                { "modestbranding", true },
                { "disablekb", true },
                { "playsinline", true },
                { "rel", false },
                { "fs", false },            // fullscreen
                { "playlist", videoID },    // yt docs recommendation: https://developers.google.com/youtube/player_parameters#loop
                { "controls", this._options.EnableControls }
            };

            // navigation manager will not be initialized during pre-rendering, which causes InvalidOperationException
            try
            {
                query.Add("origin", this._navigation.BaseUri.TrimEnd('/'));
            }
            catch (InvalidOperationException) { }

            return $"https://www.youtube-nocookie.com/embed/{videoID}?{BuildQuery(query)}";
        }

        private string BuildQuery(IDictionary<string, object> values)
        {
            return string.Join('&', values.Select(kvp =>
            {
                string value;
                if (kvp.Value is bool v)
                    value = v ? "1" : "0";
                else
                    value = kvp.Value.ToString();

                return $"{kvp.Key}={value}";
            }));
        }

        public void Refresh()
            => this.RefreshRequested?.Invoke(this, EventArgs.Empty);
    }
}
