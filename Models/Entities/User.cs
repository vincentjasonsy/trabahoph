using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabahoPH.Models.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
    }
}