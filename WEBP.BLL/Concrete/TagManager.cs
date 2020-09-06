using System;
using System.Collections.Generic;
using System.Text;
using WEBP.BLL.Abstract;
using WEBP.DAL.Interfaces;
using WEBP.Entities;

namespace WEBP.BLL.Concrete
{
    public class TagManager : ITagService
    {
        private ITagDal _tagsDal;

        public TagManager(ITagDal tagsDal)
        {
            _tagsDal = tagsDal;
        }

        public void Add(Tag tag)
        {
            _tagsDal.Add(tag);
        }

        public void Delete(Tag tag)
        {
            _tagsDal.Delete(tag);
        }

        public List<Tag> GetAll()
        {
            return 
                _tagsDal.GetList();
        }

        public Tag GetTagByName(Tag tag)
        {
            return
                _tagsDal.Get(   t => t.name == tag.name    );
        }

        public void Update(Tag tag)
        {
            _tagsDal.Update(tag);
        }
    }
}
