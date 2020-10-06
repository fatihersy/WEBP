using System;
using System.ComponentModel.DataAnnotations;

namespace WEBP.Entities.UI
{
    public class UiBlog
    {
        [Required( ErrorMessage = "Bu Alan Zorunludur")]
        [Display(Name = "Title")]
        public string title { get; set; }

        public string content { get; set; }

        public Guid uniqueid { get; set; }

        public string author { get; set; }

        [Required(ErrorMessage = "Bu Alan Zorunludur")]
        [Display(Name = "Kategori")]
        public string category { get; set; }

        [Display(Name = "Aktif Mi?")]
        public bool aktifmi { get; set; }
    }
}
