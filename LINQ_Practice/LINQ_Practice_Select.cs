using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using LINQ_Practice.Models;
using System.Linq;

namespace LINQ_Practice
{
    [TestClass]
    public class LINQ_Practice_Select
    /*
     * This unit test class covers .Select and .SelectMany
     * .Select projects each element of a sequence into a new form
     * .Select will return objects of different type than the data source
     * ListOfAuthors.Select(author => author.FirstName) //returns IEnumberable<string> (the first names of all the authors)
     * .Select will NOT JOIN collections together if they are what is selected
     * ListOfAuthors.Select(author => author.Books) //returns IEnumerable<List<Book>> <--Yikes!
     * 
     * .SelectMany projects each element of a sequence to an IEnumerable and flattens the resulting sequences into ONE sequence
     * .SelectMany will return one IEnumerable that includes all the elements in each element in the sequence 
     * ListOfAuthors.SelectMany(author => author.Books) //returns IEnumerable<Book> <--Much more usable!
     */
    {
        public List<Cohort> PracticeData { get; set; }
        public CohortBuilder CohortBuilder { get; set; }

        [TestInitialize]
        public void SetUp()
        {
            CohortBuilder = new CohortBuilder();
            PracticeData = CohortBuilder.GenerateCohorts();
        }

        [TestCleanup]
        public void TearDown()
        {
            CohortBuilder = null;
            PracticeData = null;
        }

        [TestMethod]
        public void GetAllPrimaryInstructorsInAllCohorts()
        {
            var expected = PracticeData.Select(cohort => cohort.PrimaryInstructor).ToList();
            CollectionAssert.AreEqual(expected, new List<Instructor> { CohortBuilder.Instructor2, CohortBuilder.Instructor6, CohortBuilder.Instructor3, CohortBuilder.Instructor1});
        }
        
        [TestMethod]
        public void GetAllStudents()
        {
            var expected = PracticeData.SelectMany(cohort => cohort.Students).ToList();
            CollectionAssert.AreEqual(expected, new List<Student> { CohortBuilder.Student1, CohortBuilder.Student2, CohortBuilder.Student3, CohortBuilder.Student4, CohortBuilder.Student5, CohortBuilder.Student6, CohortBuilder.Student7, CohortBuilder.Student8, CohortBuilder.Student9, CohortBuilder.Student10, CohortBuilder.Student11, CohortBuilder.Student12, CohortBuilder.Student13, CohortBuilder.Student14, CohortBuilder.Student15, CohortBuilder.Student16, CohortBuilder.Student17, CohortBuilder.Student18, CohortBuilder.Student19, CohortBuilder.Student20 });
        }

        [TestMethod]
        public void GetAllPrimaryInstructorFirstNames()
        {
            var expected = PracticeData.Select(cohort => cohort.PrimaryInstructor.FirstName).ToList();
            CollectionAssert.AreEqual(expected, new List<string> { "Jurnell", "Zachary", "Blaise", "Kate" });
        }
        
        [TestMethod]
        public void GetAllCohortNames()
        {
            var expected = PracticeData.Select(cohort => cohort.Name).ToList();
            CollectionAssert.AreEqual(expected, new List<string> { "Evening Five", "Cohort of the Future", "Evening Ninja Warriors", "Day Backgammon Geeks" });
        }

    }
}
