using System;
using WEBP.Core.Entities;

namespace WEBP.Entities.Database
{
    public class User : IEntity
    {
        public int    Id        { get; set; }
        public Guid   UniqueNo  { get; set; }
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public string UserName  { get; set; }
        
    }
}