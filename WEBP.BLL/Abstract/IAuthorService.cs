using System;
using System.Collections.Generic;
using System.Text;
using WEBP.Entities;

namespace WEBP.BLL.Abstract
{
    public interface IAuthorService
    {
        List<Author> GetAll();
        void Add(Author authors);
        void Update(Author authors);
        void Delete(Author authors);
        Author GetAuthorByEmail(Author authors);
    }
}
