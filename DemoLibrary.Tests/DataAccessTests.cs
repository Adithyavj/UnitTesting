using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DemoLibrary;
using DemoLibrary.Models;

namespace DemoLibrary.Tests
{
    public class DataAccessTests
    {
        [Fact]
        public void AddPersonToPeopleList_ShouldWork()
        {
            PersonModel newPerson = new PersonModel { FirstName = "Adithya", LastName = "Vijay" };
            List<PersonModel> people = new List<PersonModel>();

            DataAccess.AddPersonToPeopleList(people, newPerson);

            Assert.True(people.Count == 1);
            Assert.Contains<PersonModel>(newPerson, people);
        }

        [Theory]
        [InlineData("Adithya", "", "LastName")]
        [InlineData("", "Vijay", "FirstName")]
        public void AddPersonToPeopleList_ShouldFail(string firstName, string lastName, string param)
        {
            PersonModel newPerson = new PersonModel { FirstName = firstName, LastName = lastName };
            List<PersonModel> people = new List<PersonModel>();

            Assert.Throws<ArgumentException>(param, () => DataAccess.AddPersonToPeopleList(people, newPerson));
        }

        [Fact]
        public void ConvertModelsToCSV_ShouldWork()
        {
            PersonModel newPerson1 = new PersonModel { FirstName = "Adithya", LastName = "Vijay" };
            PersonModel newPerson2 = new PersonModel { FirstName = "Tim", LastName = "Corey" };
            List<PersonModel> people = new List<PersonModel>();
            people.Add(newPerson1);
            people.Add(newPerson2);
            List<string> lines = DataAccess.ConvertModelsToCSV(people);

            Assert.True(lines.Count == 2);
            
        }
    }
}
