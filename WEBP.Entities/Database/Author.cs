using System.ComponentModel.DataAnnotations;
using WEBP.Core.Entities;

namespace WEBP.Entities.Database
{
    public class Author : IEntity
    {
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string lastname { get; set; }

        [Required]
        public string email { get; set; }

        public string tel { get; set; }
    }
}
