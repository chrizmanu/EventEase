namespace EventEase.Services;

public class UserSessionService
{
    public string SessionId { get; } = Guid.NewGuid().ToString("N");
    public DateTime StartedAtUtc { get; } = DateTime.UtcNow;

    public string? LastFullName { get; private set; }
    public string? LastEmail { get; private set; }

    public void RememberUser(string fullName, string email)
    {
        LastFullName = fullName?.Trim();
        LastEmail = email?.Trim();
    }
}
