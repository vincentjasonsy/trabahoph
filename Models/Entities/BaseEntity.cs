using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabahoPH.Models.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Deleted { get; set; }
    }
}