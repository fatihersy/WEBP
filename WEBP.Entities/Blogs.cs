using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WEBP.Core.Entities;

namespace WEBP.Entities
{
    public class Blogs:IEntity
    {
        public int    id        { get; set; }

        public string title     { get; set; }

        public string content   { get; set; }

        public int    authorId  { get; set; }
    }
}
