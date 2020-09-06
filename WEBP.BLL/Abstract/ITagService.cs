using System;
using System.Collections.Generic;
using System.Text;
using WEBP.Entities;

namespace WEBP.BLL.Abstract
{
    public interface ITagService
    {
        List<Tag> GetAll();
        void Add(Tag tag);
        void Update(Tag tag);
        void Delete(Tag tag);
        Tag GetTagByName(Tag tag);
    }
}
