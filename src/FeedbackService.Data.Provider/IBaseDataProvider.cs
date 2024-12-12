namespace FeedbackService.Data.Provider;

/// <feedback>
/// Data provider with provider extra methods.
/// </feedback>
public interface IBaseDataProvider
{
    void Save();

    Task SaveAsync(CancellationToken cancellationToken = default);

    object MakeEntityDetached(object obj);

    void EnsureDeleted();

    bool IsInMemory();
}