namespace TehGM.Randominator
{
    public interface IUserSettingsProvider
    {
        event Action<UserSettings> Changed;

        UserSettings GetDefault();
        Task<UserSettings> GetAsync(CancellationToken cancellationToken = default);
        Task SaveAsync(UserSettings settings, CancellationToken cancellationToken = default);
        Task ClearAsync(CancellationToken cancellationToken = default);
    }
}
