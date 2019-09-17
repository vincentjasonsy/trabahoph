using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabahoPH.Models.Entities
{
    public class Account : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public User User { get; set; }
    }
}