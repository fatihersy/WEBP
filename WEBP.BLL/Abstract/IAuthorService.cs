using System.Collections.Generic;
using WEBP.Entities.Database;
using WEBP.Entities.UI;

namespace WEBP.BLL.Abstract
{
    public interface IAuthorService
    {
        List<UiAuthor> GetAll();
        void Add(Author authors);
        void Update(Author authors);
        void Delete(Author authors);
        UiAuthor GetAuthorByEmail(Author authors);
    }
}
