using System.Collections.Generic;
using WEBP.BLL.Abstract;
using WEBP.DAL.Interfaces;
using WEBP.Entities.UI;
using WEBP.Entities.Database;

namespace WEBP.BLL.Concrete
{
    public class AuthorManager : IAuthorService
    {
        private IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        public void Add(Author authors)
        {
            _authorDal.Add(authors);
        }

        public void Delete(Author authors)
        {
            _authorDal.Add(authors);
        }

        public List<UiAuthor> GetAll()
        {
            List<Author> authors = _authorDal.GetList();
            List<UiAuthor> uiAuthors = new List<UiAuthor>();

            foreach (var item in authors)
            {
                UiAuthor uiAuthor = new UiAuthor
                {
                    name = item.name,
                    lastname = item.lastname,
                    email = item.email,
                    tel = item.tel
                };

                uiAuthors.Add(uiAuthor);
            }

            return uiAuthors;
        }

        public UiAuthor GetAuthorByEmail(Author authors)
        {
            Author author = _authorDal.Get( a => a.email == authors.email );

            UiAuthor uiAuthor = new UiAuthor
            {
                name = author.name,
                lastname = author.lastname,
                email = author.email,
                tel = author.tel
            };

            return uiAuthor;
        }

        public void Update(Author authors)
        {
            _authorDal.Update(authors);
        }
    }
}
