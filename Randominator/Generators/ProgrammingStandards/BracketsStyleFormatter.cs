using System.Text;

namespace TehGM.Randominator.Generators.ProgrammingStandards.Services
{
    public class BracketsStyleFormatter : IBracketsStyleFormatter
    {
        public string Apply(string beforeBrackets, string withinBrackets, BracketsStyle style)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(beforeBrackets);

            if (style == BracketsStyle.JavaScript || style == BracketsStyle.AllSameLine)
                builder.AppendLine(" {");
            else
                builder.AppendLine();
            if (style == BracketsStyle.Clean)
                builder.AppendLine("{");

            builder.Append("    ");
            builder.Append(withinBrackets);

            if (style == BracketsStyle.AllSameLine)
                builder.Append(" }");
            else if (style == BracketsStyle.Clean || style == BracketsStyle.JavaScript)
            {
                builder.AppendLine();
                builder.Append('}');
            }
            
            return builder.ToString();
        }
    }
}
