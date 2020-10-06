using System.ComponentModel.DataAnnotations;
using WEBP.Core.Entities;

namespace WEBP.Entities.Database
{
    public class Tag : IEntity
    {
        public int id { get; set; }

        [Required]
        public string name { get; set; }
    }
}
