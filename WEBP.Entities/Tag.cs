using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WEBP.Core.Entities;

namespace WEBP.Entities
{
    public class Tag: IEntity
    {
        public int    id   { get; set; }

        [Required]
        public string name { get; set; }
    }
}
