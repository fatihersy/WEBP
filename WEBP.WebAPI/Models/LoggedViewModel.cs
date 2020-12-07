using System.Collections.Generic;
using WEBP.Entities.UI;

namespace WEBP.WebAPI.Models
{
    public class LoggedViewModel
    {
        public List<UiProduct> Products { get; set; }

        public string UserName { get; set; }
    }
}