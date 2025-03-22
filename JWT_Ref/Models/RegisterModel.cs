using System.ComponentModel.DataAnnotations;

namespace JWT_Ref.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Full Name is required")]
        [MaxLength(150)]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Designation is required")]
        [MaxLength(30)]
        public string Designation { get; set; } = string.Empty;

        [Required(ErrorMessage = "Username is required")]
        [MaxLength(30)]
        public string? Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Confirm password is required")]
        [Compare("Password", ErrorMessage ="Confirm password not matching with password")]
        public string? ConfirmPassword { get; set; }
    }
}
