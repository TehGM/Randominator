using Microsoft.AspNetCore.Components;
using TehGM.Randominator.Generators.ProgrammingStandards;

namespace TehGM.Randominator.UI.Components.ProgrammingStandards
{
    public static class StandardRendering
    {
        public static MarkupString RenderCodeHtml(this IBracketsStyleFormatter formatter, string beforeBrackets, string withinBrackets, BracketsStyle style)
        {
            string result = formatter.Apply(beforeBrackets, withinBrackets, style);
            return (MarkupString)result.Replace(Environment.NewLine, "<br/>").Replace(" ", "&nbsp;");
        }

        public static MarkupString RenderBracketsStyleText(this BracketsStyle style)
        {
            string result;
            if (style == BracketsStyle.NoBrackets)
                result = "you should never use any brackets, and use identation instead.";
            else if (style == BracketsStyle.Clean)
                result = "you should put both <code>{</code> and <code>}</code> brackets on separate lines.";
            else if (style == BracketsStyle.JavaScript)
                result = "you should put opening brackets <code>{</code> on the same line, but closing brackets <code>}</code> on a separate line.";
            else
                result = "you should put both <code>{</code> and <code>}</code> brackets on the same lines.";
            return (MarkupString)result;
        }

        public static MarkupString ListNormalAffixRules(this NamingStyle style, INamingStyleFormatter formatter)
        {
            List<string> rules = new List<string>(2);
            if (!string.IsNullOrWhiteSpace(style.NormalPrefix))
                rules.Add($"prefixed with <code>{formatter.ApplyToWord(style, style.NormalPrefix, true)}</code>");
            if (!string.IsNullOrWhiteSpace(style.NormalSuffix))
                rules.Add($"suffixed with <code>{formatter.ApplyToWord(style, style.NormalSuffix, false)}</code>");
            return (MarkupString)string.Join(" and ", rules);
        }

        public static MarkupString ListHungarianAffixRules(this NamingStyle style)
        {
            List<string> rules = new List<string>(2);
            if (style.HungarianPrefix != HungarianPartStyle.None)
                rules.Add($"{style.HungarianPrefix} word for prefix");
            if (style.HungarianSuffix != HungarianPartStyle.None)
                rules.Add($"{style.HungarianSuffix} word for suffix");
            return (MarkupString)string.Join(" and also ", rules);

            string GetHungarianStyleDescription(HungarianPartStyle style)
            {
                if (style == HungarianPartStyle.Short)
                    return "short";
                if (style == HungarianPartStyle.Long)
                    return "long";
                throw new NotSupportedException($"{nameof(GetHungarianStyleDescription)} doesn't support hungarian style {style}");
            }
        }
    }
}