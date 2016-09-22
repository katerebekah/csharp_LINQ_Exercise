using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using LINQ_Practice.Models;
using System.Linq;

namespace LINQ_Practice
{
    [TestClass]
    public class LINQ_Practice_First
    {
        /*
        * IMPORTANT NOTE:
        * This Test Class covers .First() 
        * which throws an exception if there is not an item that matches the condition
        * and returns the first occurance of an item that matches the condition if there is one
        * And .FirstOrDefault()
        * which returns null if there is not an item that matches condition
        * but still returns the first occurance of an item that matched the condition if there is one
       */
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
        public void GetFirstCohortWherePrimaryInstructorIsKate()
        {
            var ActualCohort = PracticeData.FirstOrDefault(c => c.PrimaryInstructor.FirstName == "Kate");
            Assert.AreEqual(ActualCohort, CohortBuilder.Cohort4);
        }


        [TestMethod]
        public void GetFirstCohortWithThreeJuniorInstructors()
        {
            var ActualCohort = PracticeData.FirstOrDefault(c => c.JuniorInstructors.Count == 3);
            Assert.AreEqual(ActualCohort, CohortBuilder.Cohort3);
        }

        [TestMethod]
        public void GetFirstCohortThatIsFullTimeAndPrimaryInstructorBirthdayInTheFuture()
        {
            var ActualCohort = PracticeData.FirstOrDefault(c => c.FullTime && c.PrimaryInstructor.Birthday > DateTime.Now);
            Assert.AreEqual(ActualCohort, CohortBuilder.Cohort2);
        }

        [TestMethod]
        public void GetFirstCohortWithInstructorNamedZeldaOrNull()
        {
            var ActualCohort = PracticeData.FirstOrDefault(c => c.PrimaryInstructor.FirstName == "Zelda");
            Assert.IsNull(ActualCohort);
        }

        [TestMethod]
        [ExpectedException(typeof(System.InvalidOperationException))]
        public void GetFirstCohortThatIsBothNotActiveAndNotFullTimeOrThrowException()
        {
            var shouldThrowException = PracticeData.First(c => c.Active == false && c.FullTime == false);
        }

        [TestMethod]
        public void GetFirstCohortWith2JuniorInstructors()
        {
            var ActualCohort = PracticeData.FirstOrDefault(c => c.JuniorInstructors.Count == 2);
            Assert.AreEqual(ActualCohort, CohortBuilder.Cohort1);
        }


    }
}
