namespace EventEase.Services;

public static class AttendanceStore
{
    // eventId -> (registrations, totalTickets)
    private static readonly Dictionary<int, (int Registrations, int TotalTickets)> _stats = new();

    public static void AddRegistration(int eventId, int tickets)
    {
        if (tickets < 1) tickets = 1;

        if (_stats.TryGetValue(eventId, out var current))
        {
            _stats[eventId] = (current.Registrations + 1, current.TotalTickets + tickets);
        }
        else
        {
            _stats[eventId] = (1, tickets);
        }
    }

    public static (int Registrations, int TotalTickets) GetStats(int eventId)
    {
        return _stats.TryGetValue(eventId, out var value)
            ? value
            : (0, 0);
    }
}
