using Microsoft.AspNetCore.Components;

namespace TehGM.Randominator.UI.Components
{
    public partial class PageFooter : ComponentBase
    {
        public class Item
        {
            public string AdditionalClasses { get; init; }
            public string DisplayText { get; }
            public string URL { get; }

            public Item(string displayText, string url)
            {
                this.DisplayText = displayText;
                this.URL = url;
            }

            public Item(string displayText)
                : this(displayText, null) { }
        }
    }
}
