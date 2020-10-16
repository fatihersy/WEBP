using System.ComponentModel.DataAnnotations;

namespace WEBP.Entities.UI
{
    public class UiUser
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}