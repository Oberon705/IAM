using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace JWT_Ref.Models
{
    public class AppUser : IdentityUser
    {
        [MaxLength(150)]
        public string FullName { get; set; } = string.Empty;
        [MaxLength(30)]
        public string Designation { get; set; } = string.Empty;        
        [MaxLength(50)]
        public string MacAddress { get; set; } = string.Empty;
        [MaxLength(5000)]
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime RefreshTokenExpiryTime { get; set; }
        
    }
}
