using System;
using WEBP.Core.Entities;
using WEBP.Core.Utilities;

namespace WEBP.Entities.Database
{
    public class Login : IEntity
    {
        private static readonly CryptoServiceProvider HashService = new CryptoServiceProvider();
        private string   PasswordHash    { get; set; }
        public  string   UserName        { get; set; }
        public  Guid     RelatedUniqueNo { get; set; }
        
        public int      Id               { get; set; }

        public void SetPassword   (string password) => PasswordHash = HashService.CreateHash(password);
        public bool VerifyPassword(string password) => HashService.Verify(password, PasswordHash);


    }
}