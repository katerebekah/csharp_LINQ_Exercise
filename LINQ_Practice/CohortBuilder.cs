using LINQ_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{

    public class CohortBuilder
    {
        public Student Student1 { get; set; }
        public Student Student2 { get; set; }
        public Student Student3 { get; set; }
        public Student Student4 { get; set; }
        public Student Student5 { get; set; }
        public Student Student6 { get; set; }
        public Student Student7 { get; set; }
        public Student Student8 { get; set; }
        public Student Student9 { get; set; }
        public Student Student10 { get; set; }
        public Student Student11 { get; set; }
        public Student Student12 { get; set; }
        public Student Student13 { get; set; }
        public Student Student14 { get; set; }
        public Student Student15 { get; set; }
        public Student Student16 { get; set; }
        public Student Student17 { get; set; }
        public Student Student18 { get; set; }
        public Student Student19 { get; set; }
        public Student Student20 { get; set; }

        public Instructor Instructor1 { get; set; }
        public Instructor Instructor2 { get; set; }
        public Instructor Instructor3 { get; set; }
        public Instructor Instructor4 { get; set; }
        public Instructor Instructor5 { get; set; }
        public Instructor Instructor6 { get; set; }

        public Cohort Cohort1 { get; set; }
        public Cohort Cohort2 { get; set; }
        public Cohort Cohort3 { get; set; }
        public Cohort Cohort4 { get; set; }

        public List<Cohort> GenerateCohorts()
        {
            Student1 = new Student
            {
                FirstName = "Anne",
                LastName = "Appleton",
                Birthday = new DateTime(1978, 2, 4),
                Active = true
            };
            Student2 = new Student
            {
                FirstName = "Bobbie",
                LastName = "Bradshaw",
                Birthday = new DateTime(1988, 7, 14),
                Active = false
            };
            Student3 = new Student
            {
                FirstName = "Carrie",
                LastName = "Cooper",
                Birthday = new DateTime(1996, 2, 4),
                Active = true
            };
            Student4 = new Student
            {
                FirstName = "Derek",
                LastName = "Dickinson",
                Birthday = new DateTime(1984, 9, 29),
                Active = true
            };
            Student5 = new Student
            {
                FirstName = "Ethel",
                LastName = "Erikson",
                Birthday = new DateTime(1971, 11, 24),
                Active = true
            };
            Student6 = new Student
            {
                FirstName = "Francis",
                LastName = "Foster",
                Birthday = new DateTime(1983, 4, 18),
                Active = true
            };
            Student7 = new Student
            {
                FirstName = "Gary",
                LastName = "Gaines",
                Birthday = new DateTime(1968, 7, 14),
                Active = true
            };
            Student8 = new Student
            {
                FirstName = "Howard",
                LastName = "Harrison",
                Birthday = new DateTime(1973, 8, 24),
                Active = true
            };
            Student9 = new Student
            {
                FirstName = "Ingrid",
                LastName = "Ibanez",
                Birthday = new DateTime(1991, 1, 8),
                Active = true
            };
            Student10 = new Student
            {
                FirstName = "Jacob",
                LastName = "Jiminez",
                Birthday = new DateTime(1984, 5, 26),
                Active = true
            };
            Student11 = new Student
            {
                FirstName = "Kate",
                LastName = "Kristov",
                Birthday = new DateTime(1987, 8, 13),
                Active = false
            };
            Student12 = new Student
            {
                FirstName = "Louis",
                LastName = "Lancaster",
                Birthday = new DateTime(1978, 3, 24),
                Active = false
            };
            Student13 = new Student
            {
                FirstName = "Matt",
                LastName = "Michaelson",
                Birthday = new DateTime(1972, 11, 14),
                Active = true
            };
            Student14 = new Student
            {
                FirstName = "Nancy",
                LastName = "Newton",
                Birthday = new DateTime(1976, 7, 31),
                Active = true
            };
            Student15 = new Student
            {
                FirstName = "Ophelia",
                LastName = "Otterson",
                Birthday = new DateTime(1984, 12, 24),
                Active = true
            };
            Student16 = new Student
            {
                FirstName = "Paul",
                LastName = "Pritchard",
                Birthday = new DateTime(1989, 1, 28),
                Active = true
            };
            Student17 = new Student
            {
                FirstName = "Quincy",
                LastName = "Queensland",
                Birthday = new DateTime(1958, 8, 3),
                Active = false
            };
            Student18 = new Student
            {
                FirstName = "Richard",
                LastName = "Ridley",
                Birthday = new DateTime(1948, 10, 31),
                Active = true
            };
            Student19 = new Student
            {
                FirstName = "Steve",
                LastName = "Southard",
                Birthday = new DateTime(1965, 7, 8),
                Active = true
            };
            Student20 = new Student
            {
                FirstName = "Terrence",
                LastName = "Thompson",
                Birthday = new DateTime(1989, 10, 19),
                Active = true
            };

            Instructor1 = new Instructor
            {
                FirstName = "Kate",
                LastName = "Williams",
                Birthday = new DateTime(1987, 8, 13),
                Active = true
            };
            Instructor2 = new Instructor
            {
                FirstName = "Jurnell",
                LastName = "Cockhren",
                Birthday = new DateTime(1983, 10, 5),
                Active = true
            };
            Instructor3 = new Instructor
            {
                FirstName = "Blaise",
                LastName = "Gratton",
                Birthday = new DateTime(1989, 3, 2),
                Active = true
            };
            Instructor4 = new Instructor
            {
                FirstName = "Terry",
                LastName = "TerribleInstructor",
                Birthday = new DateTime(1975, 9, 2),
                Active = false
            };
            Instructor5 = new Instructor
            {
                FirstName = "Jason",
                LastName = "JavaFanBoy",
                Birthday = new DateTime(1986, 6, 16),
                Active = true
            };
            Instructor6 = new Instructor
            {
                FirstName = "Zachary",
                LastName = "Zohan",
                Birthday = new DateTime(2298, 1, 1),
                Active = true
            };

            Cohort1 = new Cohort
            {
                Name = "Evening Five",
                Active = true,
                FullTime = false,
                JuniorInstructors = new List<Instructor> { Instructor1, Instructor3 },
                PrimaryInstructor = Instructor2,
                Students = new List<Student> { Student1, Student2, Student3, Student4, Student5 }
            };

            Cohort2 = new Cohort
            {
                Name = "Cohort of the Future",
                Active = false,
                FullTime = true,
                JuniorInstructors = new List<Instructor> { Instructor5, Instructor4 },
                PrimaryInstructor = Instructor6,
                Students = new List<Student> { Student6, Student7, Student8, Student9, Student10 }
            };

            Cohort3 = new Cohort
            {
                Name = "Evening Ninja Warriors",
                Active = true,
                FullTime = false,
                JuniorInstructors = new List<Instructor> { Instructor4, Instructor6, Instructor1 },
                PrimaryInstructor = Instructor3,
                Students = new List<Student> { Student11, Student12, Student13, Student14, Student15 }
            };

            Cohort4 = new Cohort
            {
                Name = "Day Backgammon Geeks",
                Active = false,
                FullTime = true,
                JuniorInstructors = new List<Instructor> { Instructor5, Instructor3 },
                PrimaryInstructor = Instructor1,
                Students = new List<Student> { Student16, Student17, Student18, Student19, Student20 }
            };

            return new List<Cohort> { Cohort1, Cohort2, Cohort3, Cohort4 };
        }
    }

}
