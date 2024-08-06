using System.ComponentModel.DataAnnotations;

namespace AuthAPI.Dtos
{
    public class CreateRoleDTO
    {
        [Required(ErrorMessage = "Role Name is required")]
        public string RoleName { get; set; } = null!;
    }
}
