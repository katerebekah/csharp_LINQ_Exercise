using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice.Models
{
    public class Cohort
    {
        public string Name { get; set; }
        public bool FullTime { get; set; }
        public bool Active { get; set; }
        public List<Student> Students { get; set; }
        public Instructor PrimaryInstructor { get; set; }
        public List<Instructor> JuniorInstructors { get; set; }
    }
}
