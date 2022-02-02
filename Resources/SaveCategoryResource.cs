using System.ComponentModel.DataAnnotations;

namespace api_rest.Resources
{
    public class SaveCategoryResource
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
