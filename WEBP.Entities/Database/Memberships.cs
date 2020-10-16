using System;
using WEBP.Core.Entities;

namespace WEBP.Entities.Database
{
    public class Memberships : IEntity
    {
        public int    Id                  { get; set; }
        public Guid   RelatedUniqueNo     { get; set; }
        public string AccountEmailAddress { get; set; }
        public string AccountPhoneNumber  { get; set; }
        
        //private int    _relatedRoleId; RESTORED FOR USE LATER
    }
}