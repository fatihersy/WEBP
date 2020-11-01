using System.Collections.Generic;
using WEBP.Entities.Database;

namespace WEBP.WebAPI.Models
{
    public class ListPanelViewModel
    {
        public List<Product> Products { get; set; }

        public List<User> Users { get; set; }
    }
}
