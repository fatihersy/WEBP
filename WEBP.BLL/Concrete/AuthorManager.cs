using System.Collections.Generic;
using System.Threading.Tasks;
using WEBP.BLL.Abstract;
using WEBP.DAL.Interfaces;
using WEBP.Entities.Database;
using WEBP.Entities.UI;

namespace WEBP.BLL.Concrete
{
    public class AuthorManager : IAuthorService
    {
        private IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        public async Task<bool> AddAsync(Author authors)
        {
            return await _authorDal.AddAsync(authors);
        }

        public async Task<bool> DeleteAsync(Author authors)
        {
            return await _authorDal.AddAsync(authors);
        }

        public async Task<List<UiAuthor>> GetAllAsync()
        {
            List<Author> authors = await _authorDal.GetListAsync();
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

        public async Task<List<Author>> GetAllWithIdAsync() => await _authorDal.GetListAsync();

        public async Task<UiAuthor> GetAuthorByEmailAsync(Author authors)
        {
            Author author = await _authorDal.GetAsync(a => a.email == authors.email);

            UiAuthor uiAuthor = new UiAuthor
            {
                name = author.name,
                lastname = author.lastname,
                email = author.email,
                tel = author.tel
            };

            return uiAuthor;
        }

        public async Task<bool> UpdateAsync(Author authors)
        {
            return await _authorDal.UpdateAsync(authors);
        }
    }
}
