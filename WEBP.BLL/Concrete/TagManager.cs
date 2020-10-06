using System.Collections.Generic;
using System.Threading.Tasks;
using WEBP.BLL.Abstract;
using WEBP.DAL.Interfaces;
using WEBP.Entities.Database;
using WEBP.Entities.UI;

namespace WEBP.BLL.Concrete
{
    public class TagManager : ITagService
    {
        private ITagDal _tagDal;

        public TagManager(ITagDal tagsDal)
        {
            _tagDal = tagsDal;
        }

        public async Task<bool> AddAsync(Tag tag)
        {
            return await _tagDal.AddAsync(tag);
        }

        public async Task<bool> DeleteAsync(Tag tag)
        {
            return await _tagDal.DeleteAsync(tag);
        }

        public async Task< List<UiTag> > GetAllAsync()
        {
            List<Tag> tags = await _tagDal.GetListAsync();
            List<UiTag> uiTags = new List<UiTag>();

            foreach (var item in tags)
            {
                UiTag uiTag = new UiTag
                {
                    name = item.name
                };

                uiTags.Add(uiTag);
            }

            return uiTags;
        }

        public async Task<UiTag> GetTagByNameAsync(Tag tag)
        {
            return
                new UiTag
                {
                    name = (await _tagDal.GetAsync(t => t.id == tag.id)).name
                };
        }

        public async Task<bool> UpdateAsync(Tag tag)
        {
            return await _tagDal.UpdateAsync(tag);
        }
    }
}
