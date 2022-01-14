namespace TehGM.Randominator.UI
{
    public interface IPageHeaderEditor
    {
        event EventHandler<string> OnTitleChanged;

        void SetTitle(string content);
    }
}
