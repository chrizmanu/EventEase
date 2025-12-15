using System.Collections.Concurrent;

namespace EventEase.Services;

public class AttendanceService
{
    private readonly ConcurrentDictionary<int, int> _ticketsByEventId = new();

    public void AddTickets(int eventId, int tickets)
    {
        if (eventId <= 0) return;
        if (tickets <= 0) return;

        _ticketsByEventId.AddOrUpdate(eventId, tickets, (_, current) => current + tickets);
    }

    public int GetTickets(int eventId)
        => _ticketsByEventId.TryGetValue(eventId, out var count) ? count : 0;

    public IReadOnlyDictionary<int, int> Snapshot()
        => new Dictionary<int, int>(_ticketsByEventId);
}
