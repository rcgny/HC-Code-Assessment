using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HC_CodeAssessment;
using HC_CodeAssessment.Controllers;
using HC_CodeAssessment.Models;

namespace HC_CodeAssessment.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {  //rcgtemp
        [TestMethod]
        public void GetPersons()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            List<Person> result = controller.Get();
            var firstName = result.FirstOrDefault<Person>().FirstName;
            var lastName = result.FirstOrDefault<Person>().LastName;
             
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(5, result.Count());
            Assert.AreEqual("Sid", firstName );
            Assert.AreEqual("Green", lastName );
        }

        [TestMethod]
        public void GetPersonBySearch()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act

            List<Person> result = controller.Get("Walker");
            var firstName = result.FirstOrDefault<Person>().FirstName;
            var lastName = result.FirstOrDefault<Person>().LastName;

            // Assert
            Assert.IsNotNull(result);           
            Assert.AreEqual("Walker", firstName);
            Assert.AreEqual("Aballo", lastName);
        }

        // This will require more research as it would not be good to write into the database with a unit test.
        //[TestMethod]
        //public void AddPerson()
        //{
        //    // Arrange
        //    ValuesController controller = new ValuesController();

        //    // Act
        //    Person person = new Person { FirstName = "Mike", LastName = "Mahoney", Age = 45 };         
        //    Interest interest = new Interest { Curiosity = "Astronomy" };
        //    controller.Post(person);           

        //    // Assert
           
        //}
    }
}
