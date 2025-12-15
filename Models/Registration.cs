using System.ComponentModel.DataAnnotations;

namespace EventEase.Models;

public class RegistrationModel
{
    public int EventId { get; set; }

    [Required(ErrorMessage = "Full name is required.")]
    [StringLength(80, ErrorMessage = "Full name is too long.")]
    public string FullName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Email is not valid.")]
    public string Email { get; set; } = string.Empty;

    [Range(1, 10, ErrorMessage = "Tickets must be between 1 and 10.")]
    public int Tickets { get; set; } = 1;
}

