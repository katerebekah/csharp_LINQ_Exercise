using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LINQ_Practice.Models;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Practice
{
    [TestClass]
    public class LINQ_Practice_Where
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
        public void GetAllActiveCohorts()
        {
            List<Cohort> ActualCohorts = PracticeData/*FILL IN LINQ EXPRESSION*/.ToList(); 
            CollectionAssert.AreEqual(ActualCohorts, new List<Cohort> { CohortBuilder.Cohort1, CohortBuilder.Cohort3 });
        }

        [TestMethod]
        public void GetAllFullTimeCohorts()
        {
            List<Cohort> ActualCohorts = PracticeData/*FILL IN LINQ EXPRESSION*/.ToList();
            CollectionAssert.AreEqual(ActualCohorts, new List<Cohort> { CohortBuilder.Cohort2, CohortBuilder.Cohort4 });
        }

        [TestMethod]
        public void GetAllCohortsWherePrimaryInstructorIsJurnell()
        {
            List<Cohort> ActualCohorts = PracticeData/*FILL IN LINQ EXPRESSION*/.ToList();
            CollectionAssert.AreEqual(ActualCohorts, new List<Cohort> { CohortBuilder.Cohort1 });
        }
        
        [TestMethod]
        public void GetAllCohortsWithThreeJuniorInstructors()
        {
            var ActualCohorts = PracticeData/*FILL IN LINQ EXPRESSION*/.ToList();
            CollectionAssert.AreEqual(ActualCohorts, new List<Cohort> { CohortBuilder.Cohort3 });
        }
        
    }
}
