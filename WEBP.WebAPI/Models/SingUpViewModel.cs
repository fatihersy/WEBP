using WEBP.Entities.UI;

namespace WEBP.WebAPI.Models
{
    public class SingUpViewModel
    {
        public UiUser User { get; set; }

        public UiLogin Login { get; set; }

        public UiMemberships Membership { get; set; }
    }
}