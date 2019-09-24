using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HC_CodeAssessment.Models
{
    public class Interest
    {
        public int InterestID { get; set; } // PK
        public int PersonID { get; set; } //FK
        public string Curiosity {get; set;}

        // Nav
        public virtual Person Person { get; set; }

    }
}