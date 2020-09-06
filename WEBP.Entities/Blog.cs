using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WEBP.Core.Entities;

namespace WEBP.Entities
{
    public class Blog:IEntity
    {
        public int    id          { get; set; }

        [Required]
        public string title       { get; set; }

        [Required]
        public string description { get; set; }

        [Required]
        public string content     { get; set; }

        [Required]
        public int    authorId    { get; set; }

        [Required]
        public int categoryid { get; set; }
    }
}
