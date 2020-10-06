using WEBP.Core.Entities;

namespace WEBP.Entities.Database
{
    public class Blogtag : IEntity
    {
        public int id { get; set; }

        public int blogid { get; set; }

        public int tagid { get; set; }
    }
}
