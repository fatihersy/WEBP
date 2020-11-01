using System.Collections.Generic;
using WEBP.Entities.UI;

namespace WEBP.WebAPI.Models
{
    public class SearchViewModel
    {
        public IEnumerable<UiProduct> Products { get; set; }
    }
}