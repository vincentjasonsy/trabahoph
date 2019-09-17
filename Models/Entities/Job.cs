using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabahoPH.Models.Entities
{
    public class Job : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Salary { get; set; }
        public Account CreatedBy { get; set; }
    }
}