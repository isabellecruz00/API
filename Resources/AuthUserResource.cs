using System.ComponentModel.DataAnnotations;

namespace api_rest.Resources
{
    public class AuthUserResource
    {
        [Required]
        [MaxLength(20)]
        public string Login { get; set; }

        [Required]
        [MaxLength(10)]
        public string Password { get; set; }
    }
}
