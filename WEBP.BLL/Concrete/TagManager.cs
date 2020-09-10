using System.Collections.Generic;
using WEBP.BLL.Abstract;
using WEBP.DAL.Interfaces;
using WEBP.Entities.UI;
using WEBP.Entities.Database;

namespace WEBP.BLL.Concrete
{
    public class TagManager : ITagService
    {
        private ITagDal _tagDal;

        public TagManager(ITagDal tagsDal)
        {
            _tagDal = tagsDal;
        }

        public void Add(Tag tag)
        {
            _tagDal.Add(tag);
        }

        public void Delete(Tag tag)
        {
            _tagDal.Delete(tag);
        }

        public List<UiTag> GetAll()
        {
            List<Tag> tags = _tagDal.GetList();
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

        public UiTag GetTagByName(Tag tag)
        {
            return
                new UiTag 
                {
                    name = _tagDal.Get(t => t.id == tag.id).name
                };
        }

        public void Update(Tag tag)
        {
            _tagDal.Update(tag);
        }
    }
}
