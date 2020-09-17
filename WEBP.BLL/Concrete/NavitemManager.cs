using System;
using System.Collections.Generic;
using System.Text;
using WEBP.BLL.Abstract;
using WEBP.DAL.Interfaces;
using WEBP.Entities.Database;
using WEBP.Entities.UI;

namespace WEBP.BLL.Concrete
{
    public class NavitemManager : INavitemService
    {
        private INavitemDal _navitemDal;
        public NavitemManager(INavitemDal navitemDal)
        {
            _navitemDal = navitemDal;
        }

        public void Add(Navitem navitem)
        {
            _navitemDal.Add(navitem);
        }

        public void Delete(Navitem navitem)
        {
            _navitemDal.Delete(navitem);
        }

        public List<UiNavitem> GetAll()
        {
            List<Navitem> navitems = _navitemDal.GetList(ni => ni.aktifmi == true);
            List<UiNavitem> uiNavitems = new List<UiNavitem>();

            foreach (var item in navitems)
            {
                UiNavitem uiNavitem = new UiNavitem
                {
                    name = item.name,
                    controller = item.controller,
                    action = item.action,
                    aktifmi = item.aktifmi,
                };

                uiNavitems.Add(uiNavitem);
            }

            return uiNavitems;
        }

        public UiNavitem GetByName(string name)
        {
            Navitem navitem = _navitemDal.Get( ni => ni.name == name);

            return new UiNavitem
            {
                name = navitem.name,
                controller = navitem.controller,
                action = navitem.action,
                aktifmi = navitem.aktifmi,
            };
        }

        public void Update(Navitem navitem)
        {
            throw new NotImplementedException();
        }
    }
}
