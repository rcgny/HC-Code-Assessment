using HC_CodeAssessment.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HC_CodeAssessment.Models;
using Newtonsoft.Json.Linq;

namespace HC_CodeAssessment.Controllers
{
    public class ValuesController : ApiController
    {
        // DB functionality
        // Note: It's a common practice to implement the repository pattern in order to create 
        // an abstraction layer between your controller and the data access layer.  I omitted due to
        // to the simple nature of this assignment
        private PersonContext db = new PersonContext();


        // GET api/values
        public List<Person> Get()
        {
            // Using LINQ to Entity query to return all info. for each person, including interests
            var persons = from p in db.Persons
                          select p;

            return persons.ToList();        
        }               

        // GET api/values/FirstName or LastName
        public List<Person> Get(string searchString)
        {
            var persons = from p in db.Persons
                          select p;

            if (!String.IsNullOrEmpty(searchString))
            {
                persons = persons.Where(p => p.FirstName.Contains(searchString)
                                       || p.LastName.Contains(searchString));
            }

            return persons.ToList();
        }

        // POST api/values/Person
        public void Post([FromBody]Person person)
        {
            db.Persons.Add(person);
            db.SaveChanges();
        }      
    }
}



 