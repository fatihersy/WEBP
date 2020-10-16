using System.Collections.Generic;
using WEBP.Entities.UI;

namespace WEBP.Web.Models
{
    public class CreatePanelViewModel
    {
        public UiBlog blog { get; set; }

        public List<string> categories { get; set; }
    }
}
