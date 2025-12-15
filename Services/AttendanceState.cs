namespace EventEase.Services;

public class AttendanceState
{
    private readonly Dictionary<int, int> _counts = new();

    public int GetCount(int eventId) => _counts.TryGetValue(eventId, out var c) ? c : 0;

    public void Increment(int eventId)
    {
        _counts[eventId] = GetCount(eventId) + 1;
    }

    public void Decrement(int eventId)
    {
        var current = GetCount(eventId);
        _counts[eventId] = Math.Max(0, current - 1);
    }
}
