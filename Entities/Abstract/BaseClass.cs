using Core.Entities;
using System;
using System.Text.Json.Serialization;

namespace Entities.Abstract
{
    public class BaseEntity : IEntity
    {
        [JsonIgnore]
        public DateTime DateCreated { get; set; } = DateTime.Now;
        [JsonIgnore]
        public DateTime? DateModified { get; set; }
        [JsonIgnore]
        public string LastUser { get; set; }
        [JsonIgnore]
        public bool? IsDeleted { get; set; } = false;

    }
}
