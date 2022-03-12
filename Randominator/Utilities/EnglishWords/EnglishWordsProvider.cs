using System.IO;
using System.Net.Http;

namespace TehGM.Randominator.Utilities.Services
{
    public class EnglishWordsProvider : IEnglishWordsProvider
    {
        private readonly HttpClient _client;
        private readonly ILogger _log;

        private IEnumerable<string> _verbs;
        private IEnumerable<string> _nouns;
        private IEnumerable<string> _adjectives;
        private IEnumerable<string> _adverbsOfManner;

        public EnglishWordsProvider(HttpClient client, ILogger<EnglishWordsProvider> log)
        {
            this._client = client;
            this._log = log;
        }

        public async Task<IEnumerable<string>> GetVerbsAsync(CancellationToken cancellationToken = default)
        {
            if (this._verbs == null)
            {
                this._verbs = await this.GetWordsListAsync("data/english-verbs.txt", cancellationToken).ConfigureAwait(false);
                this._log.LogInformation("Loaded {Count} English {WordType}", this._verbs.Count(), "verbs");
            }
            return this._verbs;
        }

        public async Task<IEnumerable<string>> GetNounsAsync(CancellationToken cancellationToken = default)
        {
            if (this._nouns == null)
            {
                this._nouns = await this.GetWordsListAsync("data/english-nouns.txt", cancellationToken).ConfigureAwait(false);
                this._log.LogInformation("Loaded {Count} English {WordType}", this._nouns.Count(), "nouns");
            }
            return this._nouns;
        }

        public async Task<IEnumerable<string>> GetAdjectivesAsync(CancellationToken cancellationToken = default)
        {
            if (this._adjectives == null)
            {
                this._adjectives = await this.GetWordsListAsync("data/english-adjectives.txt", cancellationToken).ConfigureAwait(false);
                this._log.LogInformation("Loaded {Count} English {WordType}", this._adjectives.Count(), "adjectives");
            }
            return this._adjectives;
        }

        public async Task<IEnumerable<string>> GetAdverbsOfMannerAsync(CancellationToken cancellationToken = default)
        {
            if (this._adverbsOfManner == null)
            {
                this._adverbsOfManner = await this.GetWordsListAsync("data/english-adverbs-of-manner.txt", cancellationToken).ConfigureAwait(false);
                this._log.LogInformation("Loaded {Count} English {WordType}", this._adverbsOfManner.Count(), "adverbs of manner");
            }
            return this._adverbsOfManner;
        }

        private async Task<IEnumerable<string>> GetWordsListAsync(string filename, CancellationToken cancellationToken)
        {
            this._log.LogDebug("Loading {Filename}", filename);
            using HttpResponseMessage response = await this._client.GetAsync(filename, cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            using Stream stream = await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
            using StreamReader reader = new StreamReader(stream);
            List<string> words = new List<string>();
            for (; ; )
            {
                string line = await reader.ReadLineAsync().ConfigureAwait(false);
                if (line == null)
                    break;
                if (string.IsNullOrWhiteSpace(line))
                    continue;
                line = line.Trim();
                if (line[0] == '#')
                    continue;
                words.Add(line);
            }
            return words.ToArray();
        }
    }
}
