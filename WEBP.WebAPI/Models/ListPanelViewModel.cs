using System.Collections.Generic;
using WEBP.Entities.Database;

namespace WEBP.WebAPI.Models
{
    public class ListPanelViewModel
    {
        public List<Blog> blogs { get; set; }

        public List<Category> categories { get; set; }

        public List<Author> authors { get; set; }
    }
}
