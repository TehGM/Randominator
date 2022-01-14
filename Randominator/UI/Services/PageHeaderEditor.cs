namespace TehGM.Randominator.UI.Services
{
    public class PageHeaderEditor : IPageHeaderEditor
    {
        public event EventHandler<string> OnTitleChanged;

        public void SetTitle(string content)
            => this.OnTitleChanged?.Invoke(this, content);
    }
}
