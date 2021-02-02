using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorJwt.Shared.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Email or User name must not empty.")]
        public string EmailOrName { get; set; } 

        [Required(ErrorMessage = "Password must not empty.")]
        public string Password { get; set; }

        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
        public bool RememberMe { get; set; }
    }
}
