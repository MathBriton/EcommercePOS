using System.ComponentModel.DataAnnotations;
namespace API.Dtos
{
    public class RegisterDto
    {
        [Required]
        public string DisplayName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [RegularExpression("(?=^.{6,10}$)(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&amp;*()_+}{&quot;:;'?/&gt;.&lt;,])(?!.*\\s).*$",
        ErrorMessage = "Password must haave 1 UpperCase, 1 LowerCaase,1 number, 1 non alphanumeric and at least 6 characters"]
        public string Password { get; set; }
    }
}