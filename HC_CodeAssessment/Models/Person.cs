using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HC_CodeAssessment.Models
{
    public class Person
    {
        public int ID { get; set; } // Primary key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        // Navigation property
        public virtual ICollection<Interest> Interests { get; set; }
    }
} 