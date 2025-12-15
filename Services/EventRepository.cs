using EventEase.Models;

namespace EventEase.Services;

public static class EventRepository
{
    private static readonly List<Event> _events = new()
    {
        new Event { Id = 1, Name = "Corporate Leadership Summit", Date = DateTime.Today.AddDays(7), Location = "Lima, Perú" },
        new Event { Id = 2, Name = "Tech Networking Night",        Date = DateTime.Today.AddDays(14), Location = "Arequipa, Perú" },
        new Event { Id = 3, Name = "Charity Gala Dinner",          Date = DateTime.Today.AddDays(30), Location = "Cusco, Perú" },
    };

    public static IReadOnlyList<Event> GetAll() => _events;

    public static Event? GetById(int id) => _events.FirstOrDefault(e => e.Id == id);
}
