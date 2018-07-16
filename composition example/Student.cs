using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composition_example
{
    class Student
    {
        public Student()
        {
            Schedule = new List<Course>();
        }
        public int StudentID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        // DateTime? is alias for nullable <DateTime>
        public DateTime? DateOfBirth { get; set; }

        public List<Course> Schedule { get; set; }
    }
}
