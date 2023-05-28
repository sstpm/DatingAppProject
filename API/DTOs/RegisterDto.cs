using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        // API controller can automatically bind JSON object contents to class parameters
        // and the [Required] property makes the Controller automatically validate the input.
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}