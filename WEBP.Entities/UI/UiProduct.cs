using System;
using System.ComponentModel.DataAnnotations;

namespace WEBP.Entities.UI
{
    public class UiProduct
    {
        [Required( ErrorMessage = "Bu Alan Zorunludur")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        public string Description { get; set; }

        public Guid UniqueId { get; set; }

        public string User { get; set; }

        [Display(Name = "Aktif Mi?")]
        public bool Aktifmi { get; set; }
    }
}
