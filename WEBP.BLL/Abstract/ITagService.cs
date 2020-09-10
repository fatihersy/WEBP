using System.Collections.Generic;
using WEBP.Entities.Database;
using WEBP.Entities.UI;

namespace WEBP.BLL.Abstract
{
    public interface ITagService
    {
        List<UiTag> GetAll();
        void Add(Tag tag);
        void Update(Tag tag);
        void Delete(Tag tag);
        UiTag GetTagByName(Tag tag);
    }
}
