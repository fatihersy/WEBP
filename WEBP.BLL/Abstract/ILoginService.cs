using System.Threading.Tasks;
using WEBP.Entities.UI;

namespace WEBP.BLL.Abstract
{
    public interface ILoginService
    {
        Task<bool> SingUp(UiLogin login, UiUser user, UiMemberships memberships);
        
        Task<bool> LogIn(UiLogin login);
    }
}