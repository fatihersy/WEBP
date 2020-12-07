using System;
using System.Threading.Tasks;
using WEBP.BLL.Abstract;
using WEBP.DAL.Interfaces;
using WEBP.Entities.Database;
using WEBP.Entities.UI;

namespace WEBP.BLL.Concrete
{
    public class LoginManager : ILoginService
    {
        private readonly ILoginDal _loginDal;
        private readonly IUserDal _userDal;
        private readonly IMembershipsDal _membershipsDal;
        
        public LoginManager(ILoginDal loginDal, IUserDal userDal, IMembershipsDal membershipsDal)
        {
            _loginDal = loginDal;
            _userDal = userDal;
            _membershipsDal = membershipsDal;
        }
        
        public async Task<bool> SingUp(UiLogin login, UiUser user, UiMemberships memberships)
        {
            if (login == null || user == null || memberships == null) return false;
            
            var guid = Guid.NewGuid();
            var loginInf = new Login
            {
                RelatedUniqueNo = guid,
                UserName = login.UserName
            };
            loginInf.SetPassword(login.Password);
                
            var userInf = new User
            {
                UniqueNo = guid,
                FirstName = user.FirstName,
                LastName =  user.LastName,
                UserName = login.UserName
            };
                
            var membershipsInf = new Memberships
            {
                AccountEmailAddress = memberships.EMail,
                AccountPhoneNumber = memberships.PhoneNumber,
                RelatedUniqueNo = guid
            };
                
            var result = 
                await _loginDal.AddAsync(loginInf) &&
                await _userDal.AddAsync(userInf) &&
                await _membershipsDal.AddAsync(membershipsInf);
            return result;
        }

        public async Task<string> LogIn(UiLogin login)
        {
            if (login == null) return null;
            
                var user = await _loginDal.GetAsync(u => u.UserName == login.UserName);

            if ( user == null || !user.VerifyPassword(login.Password) ) return null;

            return user.UserName;
        }
    }
}
