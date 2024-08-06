using System.ComponentModel.DataAnnotations;

namespace AuthAPI.Dtos
{
    public class RegisterDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string FullName { get; set; }

        public string Password { get; set; }

        public List<String>? Roles { get; set; }

    }
}
