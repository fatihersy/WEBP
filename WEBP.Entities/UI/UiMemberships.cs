using System.ComponentModel.DataAnnotations;

namespace WEBP.Entities.UI
{
    public class UiMemberships
    {
        [Required]
        public string EMail { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
    }
}