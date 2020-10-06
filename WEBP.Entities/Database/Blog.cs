using System;
using System.ComponentModel.DataAnnotations;
using WEBP.Core.Entities;

namespace WEBP.Entities.Database
{
    public class Blog : IEntity
    {
        public int id { get; set; }

        public string title { get; set; }

        public string content { get; set; }

        public Guid uniqueid { get; set; }

        public int authorId { get; set; }

        public int categoryid { get; set; }

        public bool aktifmi { get; set; }
    }
}
