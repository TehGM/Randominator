using System.Reflection;
using System.Text.RegularExpressions;
using TehGM.Randominator.Utilities;

namespace TehGM.Randominator.Generators.ProgrammingStandards.Services
{
    public class ProgrammingStandardsGenerator : IProgrammingStandardsGenerator
    {
        private readonly IRandomizerProvider _randomizerProvider;
        private readonly ProgrammingStandardsOptions _options;
        private readonly ILogger _log;

        private static readonly Regex _languagePrefixRegex = new Regex(@"[A-Za-z0-9]+\b", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Singleline);

        public ProgrammingStandardsGenerator(IRandomizerProvider randomizerProvider, IOptions<ProgrammingStandardsOptions> options, ILogger<ProgrammingStandardsGenerator> log)
        {
            this._randomizerProvider = randomizerProvider;
            this._options = options.Value;
            this._log = log;
        }

        public ProgrammingStandard Generate(string languageName)
        {
            this._log.LogInformation("Generating {Type} for language {Language}", nameof(ProgrammingStandard), languageName);

            // generate randomizer based on language name
            Seed seed = Seed.FromString(languageName, caseInsensitive: true);
            IRandomizer random = this._randomizerProvider.GetRandomizerWithSeed(seed);
            this._log.LogDebug("Seed for language {Language}: {Seed}", languageName, seed.Value);

            // generate language prefix
            string languagePrefix = this.GetLanguagePrefix(languageName);
            this._log.LogDebug("Prefix for language {Language}: {Prefix}", languageName, languagePrefix);

            return new ProgrammingStandard(languageName)
            {
                // brackets styles
                TypeBracketsStyle = this.GenerateBracketsStyle(random),
                MethodBracketsStyle = this.GenerateBracketsStyle(random),
                LoopBracketsStyle = this.GenerateBracketsStyle(random),
                FlowControlBracketsStyle = this.GenerateBracketsStyle(random),

                // naming styles
                ClassNamingStyle = this.GenerateNamingStyle(random, 
                    new string[] { languagePrefix, "c", "cls", "class" },
                    new string[] { "heavy", "fat", "phat" }),
                StructNamingStyle = this.GenerateNamingStyle(random, 
                    new string[] { languagePrefix, "s", "struct" }, 
                    new string[] { "light", "lightweight", "value", "slim", "slim shady" }),
                InterfaceNamingStyle = this.GenerateNamingStyle(random, 
                    new string[] { languagePrefix, "i", "interface", "abs" }, 
                    new string[] { "interface", "abstract" }),
                MethodNamingStyle = this.GenerateNamingStyle(random, 
                    new string[] { languagePrefix, "method", "do", "run", "run me", "yeet" }, 
                    new string[] { "go", "yeet", "lets go" }),
                MethodArgumentNamingStyle = this.GenerateNamingStyle(random,
                    new string[] { languagePrefix, "arg", "argument", "borrowed" }, 
                    new string[] { "use me" }),
                PropertyNamingStyle = this.GenerateNamingStyle(random, 
                    new string[] { languagePrefix, "prop", "property", "_" }, 
                    new string[] { "prop", "property", "thingy" }, true),
                PublicFieldNamingStyle = this.GenerateNamingStyle(random, 
                    new string[] { languagePrefix, "field", "variable", "var", "value", "val", "_", "m_", "m", "pub", "public", "exposing", "nude" }, 
                    new string[] { "field", "variable", "var", "value", "val", "_m", "public", "pub" }, true),
                PrivateFieldNamingStyle = this.GenerateNamingStyle(random, 
                    new string[] { languagePrefix, "field", "variable", "var", "value", "val", "_", "m_", "m", "priv", "private", "hidden", "conservative" }, 
                    new string[] { "field", "variable", "var", "value", "val", "_m", "private", "priv" }, true),
                LocalFieldNamingStyle = this.GenerateNamingStyle(random, 
                    new string[] { languagePrefix, "variable", "var", "value", "val", "_", "local", "loc", "inner" }, 
                    new string[] { "variable", "var", "value", "val", "local" }, true),
                ConstantNamingStyle = this.GenerateNamingStyle(random, 
                    new string[] { languagePrefix, "const", "constant", "permanent", "perm", "_" }, 
                    new string[] { "const", "constant", "permanent", "perm", "cant touch this" }, true),

                // allow modes
                AllowLoops = this.GenerateAllowMode(random),
                AllowFlowControl = this.GenerateAllowMode(random),
                AllowClasses = this.GenerateAllowMode(random),
                AllowStructs = this.GenerateAllowMode(random),
                AllowInterfaces = this.GenerateAllowMode(random),
                AllowProperties = this.GenerateAllowMode(random),
                AllowPublicFields = this.GenerateAllowMode(random),
                AllowPrivateFields = this.GenerateAllowMode(random),
                AllowConstants = this.GenerateAllowMode(random)
            };
        }

        private string GetLanguagePrefix(string languageName)
        {
            MatchCollection words = _languagePrefixRegex.Matches(languageName);
            if (!words.Any())
                return null;

            return new string(words
                .Where(w => !string.IsNullOrWhiteSpace(w.Value))
                .Take(2)
                .Select(w => w.Value.First())
                .ToArray());
        }

        private BracketsStyle GenerateBracketsStyle(IRandomizer randomizer)
            => randomizer.GetRandomEnumValue<BracketsStyle>();

        private AllowMode GenerateAllowMode(IRandomizer randomizer)
            => randomizer.GetRandomEnumValue<AllowMode>();

        private NamingStyle GenerateNamingStyle(IRandomizer randomizer, IEnumerable<string> prefixes, IEnumerable<string> suffixes, bool allowHungarian = false)
        {
            // calculate affixes
            HungarianPartStyle hungarianPrefix = GetHungarianPrefix(this._options.HungarianPrefixChance);
            HungarianPartStyle hungarianSuffix = GetHungarianPrefix(this._options.HungarianSuffixChance);
            string prefix = GetAffix(prefixes, this._options.NormalPrefixChance);
            string suffix = GetAffix(suffixes, this._options.NormalSuffixChance);

            // get case style and its name
            LetterCaseStyle letterCaseStyle = randomizer.GetRandomEnumValue<LetterCaseStyle>();
            string caseStyleName = randomizer.GetRandomValue(
                typeof(LetterCaseStyle)
                .GetMember(letterCaseStyle.ToString())
                .First()
                .GetCustomAttribute<DisplayNameAttribute>()
                .Values);

            // build result style
            return new NamingStyle(letterCaseStyle, caseStyleName)
            {
                NormalPrefix = prefix,
                NormalSuffix = suffix,
                HungarianPrefix = hungarianPrefix,
                HungarianSuffix = hungarianSuffix
            };

            HungarianPartStyle GetHungarianPrefix(double chance)
            {
                if (!allowHungarian)
                    return HungarianPartStyle.None;
                if (!randomizer.RollChance(chance))
                    return HungarianPartStyle.None;
                IEnumerable<HungarianPartStyle> hungarianStyles 
                    = Enum.GetValues<HungarianPartStyle>().Except(new[] { HungarianPartStyle.None });
                return randomizer.GetRandomValue(hungarianStyles);
            }

            string GetAffix(IEnumerable<string> values, double chance)
            {
                values = values?.Where(val => !string.IsNullOrWhiteSpace(val));
                if (values?.Any() != true)
                    return null;
                if (!randomizer.RollChance(chance))
                    return null;
                return randomizer.GetRandomValue(values);
            }
        }
    }
}
