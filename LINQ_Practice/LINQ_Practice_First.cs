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
            var ActualCohort = PracticeData.First<Cohort>(cohort => cohort.PrimaryInstructor.FirstName.ToLower() == "kate");
            Assert.AreEqual(ActualCohort, CohortBuilder.Cohort4);
        }


        [TestMethod]
        public void GetFirstCohortWithThreeJuniorInstructors()
        {
            var ActualCohort = PracticeData.First<Cohort>(cohort => cohort.JuniorInstructors.Count() == 3);
            Assert.AreEqual(ActualCohort, CohortBuilder.Cohort3);
        }

        [TestMethod]
        public void GetFirstCohortThatIsFullTimeAndPrimaryInstructorBirthdayInTheFuture()
        {
            var ActualCohort = PracticeData.First<Cohort>(cohort => (cohort.FullTime == true) && (cohort.PrimaryInstructor.Birthday.Year > 2016));
            Assert.AreEqual(ActualCohort, CohortBuilder.Cohort2);
        }

        [TestMethod]
        public void GetFirstCohortWithInstructorNamedZeldaOrNull()
        {
            var ActualCohort = PracticeData.FirstOrDefault(cohort => cohort.PrimaryInstructor.FirstName == "Zelda");
            Assert.IsNull(ActualCohort);
        }

        [TestMethod]
        [ExpectedException(typeof(System.InvalidOperationException))]
        public void GetFirstCohortThatIsBothNotActiveAndNotFullTimeOrThrowException()
        {
            var shouldThrowException = PracticeData.First(cohort => cohort.Active == false & cohort.FullTime == false);
        }

        [TestMethod]
        public void GetFirstCohortWith2JuniorInstructors()
        {
            var ActualCohort = PracticeData.First(cohort => cohort.JuniorInstructors.Count == 2);
            Assert.AreEqual(ActualCohort, CohortBuilder.Cohort1);
        }


    }
}
