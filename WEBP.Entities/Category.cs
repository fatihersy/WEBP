using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WEBP.Core.Entities;

namespace WEBP.Entities
{
    public class Category : IEntity
    {
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string postcolor { get; set; }
    }
}
