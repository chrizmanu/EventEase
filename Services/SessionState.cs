namespace EventEase.Services;

public class SessionState
{
    public string SessionId { get; private set; } = Guid.NewGuid().ToString("N");
    public DateTime StartedAt { get; private set; } = DateTime.Now;

    public string UserName { get; set; } = "Guest";

    public void StartNew()
    {
        SessionId = Guid.NewGuid().ToString("N");
        StartedAt = DateTime.Now;
    }
}
