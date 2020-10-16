using System.Collections.Generic;
using WEBP.Entities.UI;

namespace WEBP.WebAPI.Models
{
    public class CreatePanelViewModel
    {
        public UiBlog Blog { get; set; }

        public List<string> Categories { get; set; }
    }
}
