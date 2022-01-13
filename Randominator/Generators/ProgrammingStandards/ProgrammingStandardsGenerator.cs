using System.Reflection;
using TehGM.Randominator.Utilities;

namespace TehGM.Randominator.Generators.ProgrammingStandards.Services
{
    public class ProgrammingStandardsGenerator : IProgrammingStandardsGenerator
    {
        private readonly IRandomizerProvider _randomizerProvider;
        private readonly ProgrammingStandardsOptions _options;
        private readonly ILogger _log;

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
            int seed = this.GetSeed(languageName);
            IRandomizer random = this._randomizerProvider.GetRandomizerWithSeed(seed);
            this._log.LogDebug("Seed for language {Language}: {Seed}", languageName, seed);

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
                    new string[] { "heavy", "fat" }),
                StructNamingStyle = this.GenerateNamingStyle(random, 
                    new string[] { languagePrefix, "s", "struct" }, 
                    new string[] { "light", "lightweight", "value" }),
                InterfaceNamingStyle = this.GenerateNamingStyle(random, 
                    new string[] { languagePrefix, "i", "interface" }, 
                    new string[] { "interface" }),
                MethodNamingStyle = this.GenerateNamingStyle(random, 
                    new string[] { languagePrefix, "method", "do", "run", "run me" }, 
                    new string[] { "go" }),
                MethodArgumentNamingStyle = this.GenerateNamingStyle(random,
                    new string[] { languagePrefix, "arg", "argument" }, 
                    null),
                PropertyNamingStyle = this.GenerateNamingStyle(random, 
                    new string[] { languagePrefix, "prop", "property", "_" }, 
                    new string[] { "prop", "property" }, true),
                PublicFieldNamingStyle = this.GenerateNamingStyle(random, 
                    new string[] { languagePrefix, "field", "variable", "var", "value", "val", "_" }, 
                    new string[] { "field", "variable", "var", "value", "val" }, true),
                PrivateFieldNamingStyle = this.GenerateNamingStyle(random, 
                    new string[] { languagePrefix, "field", "variable", "var", "value", "val", "_" }, 
                    new string[] { "field", "variable", "var", "value", "val" }, true),
                LocalFieldNamingStyle = this.GenerateNamingStyle(random, 
                    new string[] { languagePrefix, "variable", "var", "value", "val", "_" }, 
                    new string[] { "variable", "var", "value", "val" }, true),
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
            string result = languageName[0].ToString();

            for (int i = 1; i < languageName.Length; i++)
            {
                char additional = languageName[i];
                if (char.IsUpper(additional))
                {
                    result += additional;
                    break;
                }
            }

            return result;
        }

        private int GetSeed(string languageName)
        {
            unchecked
            {
                int hash1 = (5381 << 16) + 5381;
                int hash2 = hash1;

                for (int i = 0; i < languageName.Length; i += 2)
                {
                    hash1 = ((hash1 << 5) + hash1) ^ languageName[i];
                    if (i == languageName.Length - 1)
                        break;
                    hash2 = ((hash2 << 5) + hash2) ^ languageName[i + 1];
                }

                return hash1 + (hash2 * 1566083941);
            }
        }

        private BracketsStyle GenerateBracketsStyle(IRandomizer randomizer)
            => randomizer.GetRandomEnumValue<BracketsStyle>();

        private AllowMode GenerateAllowMode(IRandomizer randomizer)
            => randomizer.GetRandomEnumValue<AllowMode>();

        private NamingStyle GenerateNamingStyle(IRandomizer randomizer, IEnumerable<string> prefixes, IEnumerable<string> suffixes, bool allowHungarian = false)
        {
            // calculate prefixes and sufixes
            HungarianPartStyle hungarianPrefix = GetHungarianPrefix(this._options.HungarianPrefixChance);
            HungarianPartStyle hungarianSuffix = GetHungarianPrefix(this._options.HungarianSuffixChance);
            string prefix = GetNormalPart(prefixes, this._options.NormalPrefixChance);
            string suffix = GetNormalPart(suffixes, this._options.NormalSuffixChance);

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

            string GetNormalPart(IEnumerable<string> values, double chance)
            {
                if (values?.Any() != true)
                    return null;
                if (!randomizer.RollChance(chance))
                    return null;
                return randomizer.GetRandomValue(values);
            }
        }
    }
}
