namespace TehGM.Randominator.Features.Player
{
    public interface IPlayerVideoProvider
    {
        event EventHandler RefreshRequested;
        string GetRandomVideoURL();
        string BuildYoutubeURL(string videoID);
    }
}
