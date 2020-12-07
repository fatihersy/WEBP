using System;
using WEBP.Core.Entities;
using WEBP.Entities.UI;

namespace WEBP.Entities.Database
{
    public class Product : IEntity
    {
        public int    Id             { get; set; }
        public string Title          { get; set; }
        public string Description    { get; set; }
        public float  Price          { get; set; }
        public Guid   UniqueId       { get; set; }
        public int    UserId         { get; set; }
        public bool   IsActive        { get; set; }
    }
}
