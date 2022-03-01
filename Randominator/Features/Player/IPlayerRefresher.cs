namespace TehGM.Randominator.Features.Player
{
    public interface IPlayerRefresher
    {
        /// <summary>Notifies player page that user requested player refresh.</summary>
        void Refresh();
    }
}
