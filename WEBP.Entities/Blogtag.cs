using System;
using System.Collections.Generic;
using System.Text;
using WEBP.Core.Entities;

namespace WEBP.Entities
{
    public class Blogtag: IEntity
    {
        public int id { get; set; }

        public int blogid { get; set; }

        public int tagid { get; set; }
    }
}
