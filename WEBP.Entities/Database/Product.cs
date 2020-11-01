using System;
using WEBP.Core.Entities;

namespace WEBP.Entities.Database
{
    public class Product : IEntity
    {
        public int    Id         { get; set; }
        public string Title      { get; set; }
        public string Description    { get; set; }

        public Guid   UniqueId   { get; set; }
        public int    UserId   { get; set; }
        public bool   AktifMi    { get; set; }
    }
}
