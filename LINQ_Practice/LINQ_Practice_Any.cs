using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using LINQ_Practice.Models;
using System.Linq;

namespace LINQ_Practice
{
    [TestClass]
    public class LINQ_Practice_Any
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
        public void DoAnyCohortsHavePrimaryInstructorsBornIn1980s()
        {
            var doAll = PracticeData/*FILL IN LINQ EXPRESSION*/;
            Assert.IsTrue(true); //<-- change true to doAll
        }

        [TestMethod]
        public void DoAnyCohortsHaveActivePrimaryInstructors()
        {
            var doAll = PracticeData/*FILL IN LINQ EXPRESSION*/;
            Assert.IsTrue(true); //<-- change true to doAll
        }

        [TestMethod]
        public void DoAnyActiveCohortsHave3JuniorInstructors()
        {
            var doAll = PracticeData/*FILL IN LINQ EXPRESSION*/;
            Assert.IsTrue(true); //<-- change true to doAll
        }

        [TestMethod]
        public void AreAnyCohortsBothFullTimeAndNotActive()
        {
            var doAll = PracticeData/*FILL IN LINQ EXPRESSION*/;
            Assert.IsTrue(true); //<-- change true to doAll
        }

        [TestMethod]
        public void AreAnyStudentsInCohort3NotActiveAndBornInOctober()
        {
            var doAll = PracticeData/*FILL IN LINQ EXPRESSION*/;  //HINT: Cohort3 is PracticeData[2]
            Assert.IsFalse(true); //<-- change true to doAll
        }

        [TestMethod]
        public void AreAnyJuniorInstructorsInCohort4NotActive()
        {
            var doAll = PracticeData/*FILL IN LINQ EXPRESSION*/;  //HINT: Cohort4 is PracticeData[3]
            Assert.IsFalse(true); //<-- change true to doAll
        }
    }
}
