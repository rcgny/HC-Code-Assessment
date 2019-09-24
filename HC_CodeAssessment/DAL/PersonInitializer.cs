using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HC_CodeAssessment.Models;

namespace HC_CodeAssessment.DAL
{
    // NOTE: When you deploy an application to a production web server, 
    // you must remove or disable this code since it DROPS and re-creates the database!!! 
    public class PersonInitializer : DropCreateDatabaseIfModelChanges<PersonContext>
    {
        protected override void Seed(PersonContext context)
        {
            var persons = new List<Person>
            {
               new Person{FirstName="Sid", LastName="Green",Age=30},
               new Person{FirstName="Walker", LastName="Aballo",Age=40},
               new Person{FirstName="Lindsey", LastName="Williams",Age=15},
               new Person{FirstName="Afredo", LastName="Valdez",Age=50},
               new Person{FirstName="Jim", LastName="Bo",Age=28} 
            };

            persons.ForEach(s => context.Persons.Add(s));
            context.SaveChanges();
           
            var intersets = new List<Interest>
            {
            new Interest{PersonID=1, Curiosity="Running"},
            new Interest{PersonID=1, Curiosity="Tennis"},
            new Interest{PersonID=2, Curiosity="Sailing"},
            new Interest{PersonID=2, Curiosity="Golf"},
            new Interest{PersonID=3, Curiosity="Baseball"},
            new Interest{PersonID=3, Curiosity="Football"},
            new Interest{PersonID=3, Curiosity="Running"},
            new Interest{PersonID=4, Curiosity="Chess"},
            new Interest{PersonID=5, Curiosity="Travel"} 
            };
            intersets.ForEach(s => context.Interests.Add(s));
            context.SaveChanges();
        }
    }
}