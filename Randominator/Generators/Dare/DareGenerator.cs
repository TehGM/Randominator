using TehGM.Randominator.Utilities;

namespace TehGM.Randominator.Generators.Dare.Services
{
    public class DareGenerator : IDareGenerator
    {
        private readonly IRandomizer _randomizer;
        private readonly IEnglishWordsProvider _wordsProvider;
        private readonly ILogger _log;
        private readonly DareGeneratorOptions _options;

        public DareGenerator(IRandomizer randomizer, IEnglishWordsProvider wordsProvider, ILogger<DareGenerator> log, IOptions<DareGeneratorOptions> options)
        {
            this._randomizer = randomizer;
            this._wordsProvider = wordsProvider;
            this._log = log;
            this._options = options.Value;
        }

        public async Task<string> GenerateAsync(CancellationToken cancellationToken = default)
        {
            this._log.LogTrace("Generating a new dare");

            string verb = this._randomizer.GetRandomValue(
                await this._wordsProvider.GetVerbsAsync(cancellationToken).ConfigureAwait(false));
            string noun = this._randomizer.GetRandomValue(
                await this._wordsProvider.GetNounsAsync(cancellationToken).ConfigureAwait(false));

            string result = string.Join(' ', this.TransformVerb(verb), this.GetArticle(noun), noun);
            if (this._randomizer.RollChance(this._options.AdverbChance))
            {
                string adverb = this._randomizer.GetRandomValue(
                    await this._wordsProvider.GetAdverbsOfMannerAsync(cancellationToken).ConfigureAwait(false));
                result += $", {adverb}";
            }
            return result;
        }

        private string TransformVerb(string verb)
        {
            if (verb == null)
                throw new ArgumentNullException(nameof(verb));
            if (string.IsNullOrWhiteSpace(verb))
                throw new ArgumentException("Verb cannot be empty", nameof(verb));

            if (this._options.VerbTransformations.TryGetValue(verb, out string transformation))
                return transformation;
            return verb;
        }

        private string GetArticle(string noun)
        {
            if (noun == null)
                throw new ArgumentNullException(nameof(noun));
            if (string.IsNullOrWhiteSpace(noun))
                throw new ArgumentException("Noun cannot be empty", nameof(noun));

            if (this._options.ArticleOverrides.TryGetValue(noun, out string article))
                return article;

            switch (char.ToLowerInvariant(noun[0]))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                //case 'y':
                    return "an";
                default:
                    return "a";
            }
        }
    }
}
