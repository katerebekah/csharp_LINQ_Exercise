using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using LINQ_Practice.Models;
using System.Linq;

namespace LINQ_Practice
{
    [TestClass]
    public class LINQ_Practice_Single 
        /*
         * IMPORTANT NOTE:
         * This Test Class covers .Single() 
         * which throws an exception if there is not an item that matches the condition
         * or if more than one item matches condition
         * And .SingleOrDefault()
         * which returns null if there is not an item that matches condition
         * but throws an exception if there is more than one item that matches condition
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
        public void GetOnlyCohortWithThreeJuniorInstructors()
        {
            var ActualCohort = PracticeData.Single(cohort => cohort.JuniorInstructors.Count == 3);
            Assert.AreEqual(ActualCohort, CohortBuilder.Cohort3);
        }

        [TestMethod]
        public void GetOnlyCohortThatIsFullTimeAndPrimaryInstructorBirthdayInTheFuture()
        {
            var ActualCohort = PracticeData.Single(cohort => cohort.FullTime == true && cohort.PrimaryInstructor.Birthday.Year > 2016);
            Assert.AreEqual(ActualCohort, CohortBuilder.Cohort2);
        }

        [TestMethod]
        public void GetOnlyCohortWithInstructorNamedZeldaOrNull()
        {
            var ActualCohort = PracticeData.SingleOrDefault(cohort => cohort.PrimaryInstructor.FirstName == "Zelda");
            Assert.IsNull(ActualCohort);
        }

        [TestMethod]
        [ExpectedException(typeof(System.InvalidOperationException))]
        public void GetOnlyCohortThatIsBothNotActiveAndNotFullTimeOrThrowException()
        {
            var shouldThrowException = PracticeData.Single(cohort => cohort.Active == false && cohort.FullTime == false);
        }

        [TestMethod]
        [ExpectedException(typeof(System.InvalidOperationException))]
        public void GetOnlyCohortWith2JuniorInstructorsOrThrowException()
        {
            var shouldThrowException = PracticeData.Single(cohort => cohort.JuniorInstructors.Count == 2);
        }
    }
}
