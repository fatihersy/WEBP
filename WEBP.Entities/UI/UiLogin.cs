using System.ComponentModel.DataAnnotations;

namespace WEBP.Entities.UI
{
    public class UiLogin
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}