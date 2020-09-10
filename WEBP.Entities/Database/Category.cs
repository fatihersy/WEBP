using System.ComponentModel.DataAnnotations;
using WEBP.Core.Entities;

namespace WEBP.Entities.Database
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
