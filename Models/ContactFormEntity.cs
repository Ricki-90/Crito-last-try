using System.ComponentModel.DataAnnotations;

namespace Crito_project.Models;

public class ContactFormEntity
{
    [Required]
    public string Name { get; set; } = null!;

    [Key]
    [Required]
    [EmailAddress]
    public string Email { get; set; } = null!;

    [Required]
    public string Message { get; set; } = null!;

    public string? RedirectUrl { get; set; } = "/contacts";
}
