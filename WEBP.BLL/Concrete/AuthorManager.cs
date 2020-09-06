using System;
using System.Collections.Generic;
using System.Text;
using WEBP.BLL.Abstract;
using WEBP.DAL.Interfaces;
using WEBP.Entities;

namespace WEBP.BLL.Concrete
{
    public class AuthorManager : IAuthorService
    {
        private IAuthorDal _authorsDal;

        public AuthorManager(IAuthorDal authorsDal)
        {
            _authorsDal = authorsDal;
        }

        public void Add(Author authors)
        {
            _authorsDal.Add(authors);
        }

        public void Delete(Author authors)
        {
            _authorsDal.Add(authors);
        }

        public List<Author> GetAll()
        {
            return _authorsDal.GetList();
        }

        public Author GetAuthorByEmail(Author authors)
        {
            return _authorsDal.Get( 
                                    a => a.email == authors.email
            );
        }

        public void Update(Author authors)
        {
            _authorsDal.Update(authors);
        }
    }
}
