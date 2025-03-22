using System.ComponentModel.DataAnnotations;

namespace JWT_Ref.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }

        public string MacAddress { get; set; } = string.Empty;
    }
}
