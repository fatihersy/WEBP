using System.Collections.Generic;
using WEBP.Entities;

namespace WEBP.WebAPI.Models
{
    public class ListViewModel
    {
        public List<Blog> blogs { get; set; }

        public List<Category> categories { get; set; }

        public List<Author> authors { get; set; }
    }
}
