using System;
using System.Collections.Generic;
using System.Text;
using WEBP.Entities.Database;
using WEBP.Entities.UI;

namespace WEBP.BLL.Abstract
{
    public interface INavitemService
    {
        List<UiNavitem> GetAll();
        void Add(Navitem navitem);
        void Update(Navitem navitem);
        void Delete(Navitem navitem);
        UiNavitem GetByName(string name);
    }
}
