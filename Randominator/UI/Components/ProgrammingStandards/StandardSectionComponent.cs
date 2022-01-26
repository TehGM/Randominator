using Microsoft.AspNetCore.Components;
using TehGM.Randominator.Generators.ProgrammingStandards;

namespace TehGM.Randominator.UI.Components.ProgrammingStandards
{
    public class StandardSectionComponent : ComponentBase
    {
        [Parameter, EditorRequired]
        public ProgrammingStandard Standard { get; set; }
        [Parameter, EditorRequired]
        public string SectionName { get; set; }
        [Parameter]
        public string OverrideSectionID { get; set; }

        protected string SectionID => this.Slugify(this.OverrideSectionID) ?? this.Slugify(this.SectionName);
        protected string CodeSampleID => $"{this.SectionID}-code";

        protected string LanguageName => this.Standard.LanguageName;

        private string Slugify(string text)
            => text?.ToLowerInvariant().Replace(' ', '-');

        protected MarkupString RenderSectionHeader()
            => (MarkupString)@$"<h4 id=""{this.SectionID}"" class=""section-header"">{this.SectionName}</h2>";

        protected MarkupString RenderLanguageName
            => (MarkupString)@$"<span class=""text-special bold"">{this.LanguageName}</span>";
    }
}
