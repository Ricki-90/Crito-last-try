using System.ComponentModel.DataAnnotations;

namespace Crito_project.Models
{
    public class ContactUsForm
    {
        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public string Message { get; set; } = null!;

        public string? RedirectUrl { get; set; } = "/contacts";
    }
}
