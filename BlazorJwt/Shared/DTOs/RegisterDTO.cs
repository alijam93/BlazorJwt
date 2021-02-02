using System.ComponentModel.DataAnnotations;

namespace BlazorJwt.Shared.DTOs
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "UserName must not empty.")]
        [DataType(DataType.Text)]
        [RegularExpression("([a-zA-Z0-9_-]+)", ErrorMessage = "User name not valid." )]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email must not empty.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password must not empty.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("ConfirmPassword", ErrorMessage = "Password not match.")]
        public string ConfirmPassword { get; set; }
    }
}
