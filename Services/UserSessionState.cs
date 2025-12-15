namespace EventEase.Services;

public class UserSessionState
{
    public bool IsSignedIn => !string.IsNullOrWhiteSpace(FullName) && !string.IsNullOrWhiteSpace(Email);

    public string FullName { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;

    public void SetUser(string fullName, string email)
    {
        FullName = fullName?.Trim() ?? string.Empty;
        Email = email?.Trim() ?? string.Empty;
    }

    public void Clear()
    {
        FullName = string.Empty;
        Email = string.Empty;
    }
}
