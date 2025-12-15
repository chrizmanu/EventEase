using System.ComponentModel.DataAnnotations;

namespace EventEase.Models;

public class Event
{
    public int Id { get; set; }

    [Required, StringLength(80, MinimumLength = 3)]
    public string Name { get; set; } = string.Empty;

    [Required]
    public DateTime Date { get; set; } = DateTime.Today;

    [Required, StringLength(80, MinimumLength = 2)]
    public string Location { get; set; } = string.Empty;
}
