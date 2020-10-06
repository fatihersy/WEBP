using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

        public async Task<bool> AddAsync(Navitem navitem)
        {
            return await _navitemDal.AddAsync(navitem);
        }

        public async Task<bool> DeleteAsync(Navitem navitem)
        {
            return await _navitemDal.DeleteAsync(navitem);
        }

        public async Task<List<UiNavitem>> GetAllAsync()
        {
            List<Navitem> navitems = await _navitemDal.GetListAsync(ni => ni.aktifmi == true);
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

        public async Task<UiNavitem> GetByNameAsync(string name)
        {
            Navitem navitem = await _navitemDal.GetAsync(ni => ni.name == name);

            return new UiNavitem
            {
                name = navitem.name,
                controller = navitem.controller,
                action = navitem.action,
                aktifmi = navitem.aktifmi,
            };
        }

        public async Task<bool> UpdateAsync(Navitem navitem)
        {
            return await _navitemDal.UpdateAsync(navitem);
        }
    }
}
