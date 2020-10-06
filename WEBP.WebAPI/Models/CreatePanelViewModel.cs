using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WEBP.Entities.Database;
using WEBP.Entities.UI;

namespace WEBP.WebAPI.Models
{
    public class CreatePanelViewModel
    {
        public UiBlog blog { get; set; }

        public List<string> categories { get; set; }
    }
}
