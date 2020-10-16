using System.Collections.Generic;
using WEBP.Entities.Database;

namespace WEBP.WebAPI.Models
{
    public class ListPanelViewModel
    {
        public List<Blog> Blogs { get; set; }

        public List<Category> Categories { get; set; }

        public List<Author> Authors { get; set; }
    }
}
