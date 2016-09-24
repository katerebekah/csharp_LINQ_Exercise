using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using LINQ_Practice.Models;
using System.Linq;

namespace LINQ_Practice
{
    [TestClass]
    public class LINQ_Practice_OrderBy
        /*
         * .OrderBy returns ascending
         * .OrderByDescending returns descending
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
        public void GetAllCohortsByName()
        {
            var expected = PracticeData/*FILL IN LINQ EXPRESSION*/.ToList();
            CollectionAssert.AreEqual(expected, new List<Cohort> { CohortBuilder.Cohort2, CohortBuilder.Cohort4, CohortBuilder.Cohort1, CohortBuilder.Cohort3 });
        }
        
        [TestMethod]
        public void GetAllStudentsInCohort1ByBirthday()
        {
            var expected = PracticeData/*FILL IN LINQ EXPRESSION*/.ToList(); //HINT: Cohort1 is PracticeData[0]
            CollectionAssert.AreEqual(expected, new List<Student> { CohortBuilder.Student5, CohortBuilder.Student1, CohortBuilder.Student4, CohortBuilder.Student2, CohortBuilder.Student3 });
        }

        [TestMethod]
        public void GetAllStudentsInCohort1ByBirthdayYoungestFirst()
        {
            var expected = PracticeData/*FILL IN LINQ EXPRESSION*/.ToList(); //HINT: Cohort1 is PracticeData[0]
            CollectionAssert.AreEqual(expected, new List<Student> { CohortBuilder.Student3, CohortBuilder.Student2, CohortBuilder.Student4, CohortBuilder.Student1, CohortBuilder.Student5 });
        }

        [TestMethod]
        public void GetAllJuniorInstructorsInCohort3ByLastName()
        {
            var expected = PracticeData/*FILL IN LINQ EXPRESSION*/.ToList();
            CollectionAssert.AreEqual(expected, new List<Instructor> { CohortBuilder.Instructor4, CohortBuilder.Instructor1, CohortBuilder.Instructor6 });
        }
    }
}
