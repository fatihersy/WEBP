using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WEBP.Core.Entities;

namespace WEBP.Entities.Database
{
    public class Navitem : IEntity
    {
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string controller { get; set; }

        [Required]
        public string action { get; set; }

        [Required]
        public bool aktifmi { get; set; }

    }
}
